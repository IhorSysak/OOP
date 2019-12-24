<<<<<<< HEAD
﻿namespace Turniket_OOP
=======
﻿namespace OOP_Turniket
>>>>>>> Work Project
{
    partial class Form1
    {
        /// <summary>
<<<<<<< HEAD
        /// Required designer variable.
=======
        /// Обязательная переменная конструктора.
>>>>>>> Work Project
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
<<<<<<< HEAD
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
=======
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
>>>>>>> Work Project
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

<<<<<<< HEAD
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
=======
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Photo_User = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_University = new System.Windows.Forms.TextBox();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.button_Cheak = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button1_Close = new System.Windows.Forms.Button();
            this.textBox_Mess = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Photo_User
            // 
            this.Photo_User.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Photo_User.Location = new System.Drawing.Point(525, 38);
            this.Photo_User.Name = "Photo_User";
            this.Photo_User.Size = new System.Drawing.Size(222, 218);
            this.Photo_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo_User.TabIndex = 1;
            this.Photo_User.TabStop = false;
            this.Photo_User.Click += new System.EventHandler(this.Photo_User_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "University";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Group";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(211, 66);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(136, 20);
            this.textBox_Name.TabIndex = 5;
            this.textBox_Name.Text = "Ігор";
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(211, 95);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(136, 20);
            this.textBox_Surname.TabIndex = 6;
            this.textBox_Surname.Text = "Сисак";
            // 
            // textBox_University
            // 
            this.textBox_University.Location = new System.Drawing.Point(211, 132);
            this.textBox_University.Name = "textBox_University";
            this.textBox_University.Size = new System.Drawing.Size(136, 20);
            this.textBox_University.TabIndex = 7;
            this.textBox_University.Text = "KPI";
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(211, 169);
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(136, 20);
            this.textBox_Group.TabIndex = 8;
            this.textBox_Group.Text = "IS-81";
            // 
            // button_Cheak
            // 
            this.button_Cheak.Location = new System.Drawing.Point(46, 298);
            this.button_Cheak.Name = "button_Cheak";
            this.button_Cheak.Size = new System.Drawing.Size(68, 29);
            this.button_Cheak.TabIndex = 9;
            this.button_Cheak.Text = "Cheak";
            this.button_Cheak.UseVisualStyleBackColor = true;
            this.button_Cheak.Click += new System.EventHandler(this.button_Cheak_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(149, 298);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(68, 29);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(685, 298);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(62, 29);
            this.button_Next.TabIndex = 11;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button1_Close
            // 
            this.button1_Close.Location = new System.Drawing.Point(255, 298);
            this.button1_Close.Name = "button1_Close";
            this.button1_Close.Size = new System.Drawing.Size(74, 29);
            this.button1_Close.TabIndex = 12;
            this.button1_Close.Text = "Close";
            this.button1_Close.UseVisualStyleBackColor = true;
            this.button1_Close.Click += new System.EventHandler(this.button1_Close_Click);
            // 
            // textBox_Mess
            // 
            this.textBox_Mess.Location = new System.Drawing.Point(211, 236);
            this.textBox_Mess.Name = "textBox_Mess";
            this.textBox_Mess.Size = new System.Drawing.Size(259, 20);
            this.textBox_Mess.TabIndex = 13;
>>>>>>> Work Project
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
=======
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.textBox_Mess);
            this.Controls.Add(this.button1_Close);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Cheak);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.textBox_University);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Photo_User);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Photo_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> Work Project

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
    }
}
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Photo_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_University;
        private System.Windows.Forms.TextBox textBox_Group;
        private System.Windows.Forms.Button button_Cheak;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button1_Close;
        private System.Windows.Forms.TextBox textBox_Mess;
    }
}

>>>>>>> Work Project
