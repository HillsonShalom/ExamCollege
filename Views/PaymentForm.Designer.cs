namespace ExamCollege.Views
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPay = new Button();
            listViewCourses = new ListView();
            textBoxSum = new TextBox();
            sum = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonPay
            // 
            buttonPay.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonPay.Location = new Point(188, 350);
            buttonPay.Name = "buttonPay";
            buttonPay.Size = new Size(130, 53);
            buttonPay.TabIndex = 0;
            buttonPay.Text = "תשלום";
            buttonPay.UseVisualStyleBackColor = true;
            buttonPay.Click += buttonPay_Click;
            // 
            // listViewCourses
            // 
            listViewCourses.Location = new Point(22, 133);
            listViewCourses.Name = "listViewCourses";
            listViewCourses.Size = new Size(467, 132);
            listViewCourses.TabIndex = 1;
            listViewCourses.UseCompatibleStateImageBehavior = false;
            listViewCourses.View = View.List;
            // 
            // textBoxSum
            // 
            textBoxSum.Font = new Font("Segoe UI", 14F);
            textBoxSum.Location = new Point(173, 293);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(156, 39);
            textBoxSum.TabIndex = 2;
            textBoxSum.KeyPress += PreventWrongCharacters;
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            sum.Location = new Point(131, 66);
            sum.Name = "sum";
            sum.Size = new Size(149, 37);
            sum.TabIndex = 3;
            sum.Text = "אין קורסים";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 80);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 4;
            label2.Text = "נשאר לתשלום";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 450);
            Controls.Add(label2);
            Controls.Add(sum);
            Controls.Add(textBoxSum);
            Controls.Add(listViewCourses);
            Controls.Add(buttonPay);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPay;
        private ListView listViewCourses;
        private TextBox textBoxSum;
        private Label sum;
        private Label label2;
    }
}