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
    public partial class MainForm : Form
    {
        private DBContext db;
        DataTable tableOfCourses;
        public MainForm()
        {
            InitializeComponent();
            db = new DBContext(GetConnectionString());
            tableOfCourses = db.ExecuteQuery("SELECT Name, Starts, ID FROM Courses", null);
            InitializeComboCourses();
        }

        public void InitializeComboCourses()
        {
            foreach (DataRow row in tableOfCourses.Rows)
            {
                string r = row[0].ToString() + " " + row[1].ToString() + row[2].ToString();
                comboBoxCourses.Items.Add(r.Replace("00:00:00", ""));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameText = textBoxName.Text;
            if (string.IsNullOrEmpty(nameText))
            {
                MessageBox.Show("הכנס שם!");
                return;
            }
            string selectedCourse = comboBoxCourses.Text;
            if (string.IsNullOrEmpty(selectedCourse))
            {
                MessageBox.Show("בחר קורס!");
                return;
            }
            int selID = int.Parse(selectedCourse[selectedCourse.Length - 1].ToString());

            SqlParameter[] pars = {new SqlParameter("@name", nameText),
                                    new SqlParameter("@courseID", selID)};
            int answer = db.ExecuteNonQuery(@"
begin transaction
begin try
	declare @n varchar(30) = @name
	if not exists(select Name from Students where Name = @n)
	begin
		insert into Students(Name, Owes) values (@n, 0)
	end
	
	declare @p decimal
	select @p = Price from Courses where ID = @courseID

	declare @i int
	select @i = ID from Students where Name = @n
	insert into Enroll(StudentID, CourseID) values(@i, @courseID)

	update Students set Owes = Owes + @p where ID = @i

	COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;

END CATCH;", pars);
            if (answer < 1)
            {
                MessageBox.Show("לא הצליח");
                return;
            }
            else
            {
                MessageBox.Show("נרשמת בהצלחה!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            PaymentForm pay = new PaymentForm(name);
            pay.ShowDialog();
        }
    }
}
