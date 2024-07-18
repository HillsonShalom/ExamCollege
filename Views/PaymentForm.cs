using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamCollege.DAL;
using static ExamCollege.Config.Services;

namespace ExamCollege.Views
{
    public partial class PaymentForm : Form
    {
        private string name;
        private DBContext db;
        int nameID;
        public PaymentForm(string name)
        {
            this.name = name;
            db = new DBContext(GetConnectionString());
            SqlParameter[] par = { new SqlParameter("@name", name) };
            nameID = int.Parse(db.ExecuteScalar("select ID from Students where Name = @name", par).ToString());
            InitializeComponent();
            InitializeList();
            RefreshSum();
        }

        public void InitializeList()
        {
            SqlParameter[] par = { new SqlParameter("@nameID", nameID) };
            DataTable table = db.ExecuteQuery(@"
select c.Name + ' ' + cast(c.Starts as varchar) as Name from Enroll e
join Students s on e.StudentID = s.ID
join Courses c on e.CourseID = c.ID
where s.ID = @nameID", par);
            string[] cats = table.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            foreach (string cat in cats)
            {
                listViewCourses.Items.Add(cat);
            }
        }

        public void RefreshSum()
        {
            SqlParameter[] par = { new SqlParameter("@id", nameID) };
            sum.Text = db.ExecuteScalar("select Owes from Students where ID = @id", par).ToString();
        }


        private void PreventWrongCharacters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            TextBox curr = (TextBox)sender;
            if (e.KeyChar == '.' && curr.Text.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            string sum = textBoxSum.Text;
            if (string.IsNullOrEmpty(sum))
            {
                MessageBox.Show("הכנס סכום");
                return;
            }
            SqlParameter[] pars = { new SqlParameter("@sid", nameID),
                                    new SqlParameter("@sum", double.Parse(sum))};
            int answer = db.ExecuteNonQuery(@"
begin transaction
begin try
	insert into Payments(StudentID, Sum, Time)
	values (@sid, @sum, GETDATE())
	update Students set Owes = Owes - @sum
	where ID = @sid
	commit transaction
end try
begin catch
	rollback transaction
end catch", pars);
            if (answer < 1)
            {
                MessageBox.Show("לא הצליח");
                return;
            }
            else
            {
                MessageBox.Show("הצליח");
            }
            RefreshSum();
        }
    }
}
