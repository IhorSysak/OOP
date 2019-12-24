using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
=======
using System.IO;
>>>>>>> Work Project
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD

namespace Turniket_OOP
=======
using Turniket_OOP;

namespace OOP_Turniket
>>>>>>> Work Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Next_form = new Form2();
            Next_form.Show();
=======
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(220, 180);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = " ";
            textBox_Name.Clear();

            textBox_Surname.Text = " ";
            textBox_Surname.Clear();

            textBox_University.Text = " ";
            textBox_University.Clear();

            textBox_Group.Text = " ";
            textBox_Group.Clear();

            textBox_Mess.Text = " ";
            textBox_Mess.Clear();

            Photo_User.Image = null;
        }

        private void button_Cheak_Click(object sender, EventArgs e)
        {
            // Cheak

            if (string.IsNullOrEmpty(textBox_Name.Text) || string.IsNullOrEmpty(textBox_Surname.Text) || string.IsNullOrEmpty(textBox_Group.Text) || string.IsNullOrEmpty(textBox_University.Text))
            {
                textBox_Mess.Text = "Всі поля повинні бути заповненні";
            }
            else if (textBox_University.Text != "KPI")
            {
                textBox_Mess.Text = "Ви не є студентом КРІ";
                textBox_University.Clear();
            }
            else if (!File.Exists("D:\\Turniket_OOP/Turniket_OOP/" + textBox_Group.Text + ".txt"))
            {
                textBox_Mess.Text = "Такої групи не існує";
                textBox_Group.Clear();
            }
            else
            {
                Student traspasser = new Student(textBox_Name.Text, textBox_Surname.Text, textBox_Group.Text, textBox_University.Text);
                if (Terminal.Validete(traspasser))
                {
                    string allGroup = File.ReadAllText("D:\\Turniket_OOP/Turniket_OOP/" + textBox_Group.Text + ".txt", encoding: Encoding.GetEncoding(1251));
                    if (allGroup.Contains(traspasser.ToString()))
                    {
                        textBox_Mess.Text = " + ";
                        Decanat.GetDecanat().IsStudentLate(traspasser);
                    }
                    else
                    {
                        textBox_Mess.Text = "Ви не є студентом цієї групи";
                        textBox_Name.Clear();
                        textBox_Surname.Clear();
                    }
                   
                }
            }
        }

        private void Photo_User_Click(object sender, EventArgs e)
        {
            Photo_User.Image = Image.FromFile("D:\\Turniket_OOP/Turniket_OOP/thumb4.jpg");
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            Form2 Next_Form = new Form2();
            Next_Form.Show();
            Hide();
        }

        private void button1_Close_Click(object sender, EventArgs e)
        {
            Close();
>>>>>>> Work Project
        }
    }
}
