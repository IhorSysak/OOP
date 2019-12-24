<<<<<<< HEAD
﻿namespace Turniket_OOP
=======
﻿namespace OOP_Turniket
>>>>>>> Work Project
{
    partial class Form2
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
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1_group1 = new System.Windows.Forms.Button();
            this.button1_group2 = new System.Windows.Forms.Button();
            this.button1_All = new System.Windows.Forms.Button();
            this.button_Sort_by_Missed = new System.Windows.Forms.Button();
            this.button_Cheak_student = new System.Windows.Forms.Button();
            this.button_Prev = new System.Windows.Forms.Button();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.textBox_Mess2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_Clear_file = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button_Late_Student = new System.Windows.Forms.Button();
            this.button_Present_Student = new System.Windows.Forms.Button();
            this.textBox_Found_Student = new System.Windows.Forms.TextBox();
            this.button_Found_Student = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(442, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 238);
            this.listBox1.TabIndex = 0;
            // 
            // button1_group1
            // 
            this.button1_group1.Location = new System.Drawing.Point(57, 41);
            this.button1_group1.Name = "button1_group1";
            this.button1_group1.Size = new System.Drawing.Size(67, 32);
            this.button1_group1.TabIndex = 3;
            this.button1_group1.Text = "IS-81";
            this.button1_group1.UseVisualStyleBackColor = true;
            this.button1_group1.Click += new System.EventHandler(this.button1_group1_Click);
            // 
            // button1_group2
            // 
            this.button1_group2.Location = new System.Drawing.Point(181, 41);
            this.button1_group2.Name = "button1_group2";
            this.button1_group2.Size = new System.Drawing.Size(65, 32);
            this.button1_group2.TabIndex = 4;
            this.button1_group2.Text = "IS-82";
            this.button1_group2.UseVisualStyleBackColor = true;
            this.button1_group2.Click += new System.EventHandler(this.button1_group2_Click);
            // 
            // button1_All
            // 
            this.button1_All.Location = new System.Drawing.Point(282, 41);
            this.button1_All.Name = "button1_All";
            this.button1_All.Size = new System.Drawing.Size(67, 31);
            this.button1_All.TabIndex = 5;
            this.button1_All.Text = "All group";
            this.button1_All.UseVisualStyleBackColor = true;
            this.button1_All.Click += new System.EventHandler(this.button1_All_Click);
            // 
            // button_Sort_by_Missed
            // 
            this.button_Sort_by_Missed.Location = new System.Drawing.Point(171, 98);
            this.button_Sort_by_Missed.Name = "button_Sort_by_Missed";
            this.button_Sort_by_Missed.Size = new System.Drawing.Size(92, 36);
            this.button_Sort_by_Missed.TabIndex = 7;
            this.button_Sort_by_Missed.Text = "Missed";
            this.button_Sort_by_Missed.UseVisualStyleBackColor = true;
            this.button_Sort_by_Missed.Click += new System.EventHandler(this.button_Sort_by_Missed_Click);
            // 
            // button_Cheak_student
            // 
            this.button_Cheak_student.Location = new System.Drawing.Point(171, 163);
            this.button_Cheak_student.Name = "button_Cheak_student";
            this.button_Cheak_student.Size = new System.Drawing.Size(92, 36);
            this.button_Cheak_student.TabIndex = 8;
            this.button_Cheak_student.Text = "Cheak student";
            this.button_Cheak_student.UseVisualStyleBackColor = true;
            this.button_Cheak_student.Click += new System.EventHandler(this.button_Cheak_student_Click);
            // 
            // button_Prev
            // 
            this.button_Prev.Location = new System.Drawing.Point(27, 292);
            this.button_Prev.Name = "button_Prev";
            this.button_Prev.Size = new System.Drawing.Size(69, 26);
            this.button_Prev.TabIndex = 9;
            this.button_Prev.Text = "Prev";
            this.button_Prev.UseVisualStyleBackColor = true;
            this.button_Prev.Click += new System.EventHandler(this.button_Prev_Click);
            // 
            // button1_Clear
            // 
            this.button1_Clear.Location = new System.Drawing.Point(137, 292);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(62, 26);
            this.button1_Clear.TabIndex = 10;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // textBox_Mess2
            // 
            this.textBox_Mess2.Location = new System.Drawing.Point(314, 292);
            this.textBox_Mess2.Name = "textBox_Mess2";
            this.textBox_Mess2.Size = new System.Drawing.Size(130, 20);
            this.textBox_Mess2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // button_Clear_file
            // 
            this.button_Clear_file.Location = new System.Drawing.Point(219, 292);
            this.button_Clear_file.Name = "button_Clear_file";
            this.button_Clear_file.Size = new System.Drawing.Size(64, 26);
            this.button_Clear_file.TabIndex = 13;
            this.button_Clear_file.Text = "Clear file";
            this.button_Clear_file.UseVisualStyleBackColor = true;
            this.button_Clear_file.Click += new System.EventHandler(this.button_Clear_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // button_Late_Student
            // 
            this.button_Late_Student.Location = new System.Drawing.Point(57, 102);
            this.button_Late_Student.Name = "button_Late_Student";
            this.button_Late_Student.Size = new System.Drawing.Size(67, 29);
            this.button_Late_Student.TabIndex = 15;
            this.button_Late_Student.Text = "Late";
            this.button_Late_Student.UseVisualStyleBackColor = true;
            this.button_Late_Student.Click += new System.EventHandler(this.button_Late_Student_Click);
            // 
            // button_Present_Student
            // 
            this.button_Present_Student.Location = new System.Drawing.Point(57, 163);
            this.button_Present_Student.Name = "button_Present_Student";
            this.button_Present_Student.Size = new System.Drawing.Size(67, 29);
            this.button_Present_Student.TabIndex = 16;
            this.button_Present_Student.Text = "Present";
            this.button_Present_Student.UseVisualStyleBackColor = true;
            this.button_Present_Student.Click += new System.EventHandler(this.button_Present_Student_Click);
            // 
            // textBox_Found_Student
            // 
            this.textBox_Found_Student.Location = new System.Drawing.Point(282, 234);
            this.textBox_Found_Student.Name = "textBox_Found_Student";
            this.textBox_Found_Student.Size = new System.Drawing.Size(154, 20);
            this.textBox_Found_Student.TabIndex = 17;
            this.textBox_Found_Student.Text = "Сисак Ігор";
            // 
            // button_Found_Student
            // 
            this.button_Found_Student.Location = new System.Drawing.Point(171, 219);
            this.button_Found_Student.Name = "button_Found_Student";
            this.button_Found_Student.Size = new System.Drawing.Size(92, 35);
            this.button_Found_Student.TabIndex = 18;
            this.button_Found_Student.Text = "Found";
            this.button_Found_Student.UseVisualStyleBackColor = true;
            this.button_Found_Student.Click += new System.EventHandler(this.button_Found_Student_Click);
>>>>>>> Work Project
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.button_Found_Student);
            this.Controls.Add(this.textBox_Found_Student);
            this.Controls.Add(this.button_Present_Student);
            this.Controls.Add(this.button_Late_Student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Clear_file);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Mess2);
            this.Controls.Add(this.button1_Clear);
            this.Controls.Add(this.button_Prev);
            this.Controls.Add(this.button_Cheak_student);
            this.Controls.Add(this.button_Sort_by_Missed);
            this.Controls.Add(this.button1_All);
            this.Controls.Add(this.button1_group2);
            this.Controls.Add(this.button1_group1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> Work Project

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1_group1;
        private System.Windows.Forms.Button button1_group2;
        private System.Windows.Forms.Button button1_All;
        private System.Windows.Forms.Button button_Sort_by_Missed;
        private System.Windows.Forms.Button button_Cheak_student;
        private System.Windows.Forms.Button button_Prev;
        private System.Windows.Forms.Button button1_Clear;
        private System.Windows.Forms.TextBox textBox_Mess2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_Clear_file;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Late_Student;
        private System.Windows.Forms.Button button_Present_Student;
        private System.Windows.Forms.TextBox textBox_Found_Student;
        private System.Windows.Forms.Button button_Found_Student;
>>>>>>> Work Project
    }
}