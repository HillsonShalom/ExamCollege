namespace ExamCollege.Views
{
    partial class MainForm
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
            textBoxName = new TextBox();
            comboBoxCourses = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14F);
            textBoxName.Location = new Point(41, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.Size = new Size(348, 39);
            textBoxName.TabIndex = 4;
            // 
            // comboBoxCourses
            // 
            comboBoxCourses.Font = new Font("Segoe UI", 16F);
            comboBoxCourses.FormattingEnabled = true;
            comboBoxCourses.Location = new Point(41, 180);
            comboBoxCourses.Name = "comboBoxCourses";
            comboBoxCourses.RightToLeft = RightToLeft.Yes;
            comboBoxCourses.Size = new Size(348, 45);
            comboBoxCourses.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(155, 265);
            button1.Name = "button1";
            button1.Size = new Size(184, 52);
            button1.TabIndex = 6;
            button1.Text = "הרשמה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(253, 509);
            button2.Name = "button2";
            button2.Size = new Size(184, 52);
            button2.TabIndex = 7;
            button2.Text = "עבור לתשלום";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(41, 509);
            button3.Name = "button3";
            button3.Size = new Size(184, 52);
            button3.TabIndex = 8;
            button3.Text = "צור קשר";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 636);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxCourses);
            Controls.Add(textBoxName);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxName;
        private ComboBox comboBoxCourses;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}