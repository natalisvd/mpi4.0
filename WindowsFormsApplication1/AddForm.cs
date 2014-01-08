using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddForm : Form
    {
        Color EmptyColor;

        public AddForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panelStudent.Visible = true;
                panelTeacher.Visible = false;
            }

            if (textBox1.Text == "") { textBox1.BackColor = EmptyColor; }
            else textBox1.BackColor = Color.White;
            if (textBox2.Text == "") { textBox2.BackColor = EmptyColor; }
            else textBox2.BackColor = Color.White;

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panelStudent.Visible = false;
                panelTeacher.Visible = true;
            }

            if (textBox1.Text == "") { textBox1.BackColor = EmptyColor; }
            else textBox1.BackColor = Color.White;
            if (textBox2.Text == "") { textBox2.BackColor = EmptyColor; }
            else textBox2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Trim();
            textBox2.Text = textBox2.Text.Trim();
            textBox3.Text = textBox3.Text.Trim();
            textBox4.Text = textBox4.Text.Trim();
            textBox5.Text = textBox5.Text.Trim();
            textBox6.Text = textBox6.Text.Trim();

            if (System.Text.RegularExpressions.Regex.Match(textBox1.Text, "^[А-ИК-ЩЭ-Я][а-я]+$").Success == false && System.Text.RegularExpressions.Regex.Match(textBox1.Text, "^[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+$").Success == false)
            {
                MessageBox.Show("Введено некорректное значение поля \"Фамилия\"!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (System.Text.RegularExpressions.Regex.Match(textBox2.Text, "^[А-ИК-ЩЭ-Я][а-я]+$").Success == false && System.Text.RegularExpressions.Regex.Match(textBox1.Text, "^[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+$").Success == false)
            {
                MessageBox.Show("Введено некорректное значение поля \"Имя\"!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (textBox3.Text!="" && System.Text.RegularExpressions.Regex.Match(textBox3.Text, "^[А-ИК-ЩЭ-Я][а-я]+$").Success == false)
            {
                MessageBox.Show("Введено некорректное значение поля \"Отчество\"!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (System.Text.RegularExpressions.Regex.Match(textBox4.Text, "^[А-Я]+[/-]{1}[0-9]+$").Success == false && System.Text.RegularExpressions.Regex.Match(textBox4.Text, "^[А-Я]+[/-]{1}[0-9]+[/-]{1}[0-9]+$").Success == false)
            {
                MessageBox.Show("Введено некорректное значение поля \"Группа\"!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
        
        public int Change()
        {
            if (radioButton1.Checked == true) return 1;
            else if (radioButton2.Checked == true) return 2;
            else return 0;
        }
        public string FullName()
        {
            return textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
        }

        public string Group()
        {
            return textBox4.Text;
        }
        public string Gpa()
        {
            return textBox5.Text;
        }

        public string Major()
        {
            return textBox6.Text;
        }

        public void EmptyBoxStudent()
        {
            if (textBox5.Text == "" || textBox4.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = false;
            }

            else
            {
                button1.Enabled = true;
            }

            if (textBox1.Text != "") textBox1.BackColor = Color.White;
            else textBox1.BackColor = EmptyColor;
            if (textBox2.Text != "") textBox2.BackColor = Color.White;
            else textBox2.BackColor = EmptyColor;
            if (textBox4.Text != "") textBox4.BackColor = Color.White;
            else textBox4.BackColor = EmptyColor;
        }

        public void EmptyBoxTeacher()
        {
            if (textBox6.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = false;
            }

            else
            {
                button1.Enabled = true;
            }

            if (textBox1.Text != "") textBox1.BackColor = Color.White;
            else textBox1.BackColor = EmptyColor;
            if (textBox2.Text != "") textBox2.BackColor = Color.White;
            else textBox2.BackColor = EmptyColor;
            if (textBox6.Text != "") textBox6.BackColor = Color.White;
            else textBox6.BackColor = EmptyColor;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double a;

            if (!double.TryParse(textBox5.Text, out a))
            {
                textBox5.BackColor = EmptyColor;
                label7.Text = "Вы ввели некорекное значение \"Средний балл\"";                
                button1.Enabled = false;

            }

            else  if (Convert.ToDouble(textBox5.Text) > 5 || Convert.ToDouble(textBox5.Text) < 0) 
            { 
                label7.Text = "Значение не должно быть больше 5 или меньше 0";
                textBox5.BackColor = EmptyColor;
            }

            else if (textBox4.Text != "" && textBox1.Text != "")
            {
                button1.Enabled = true;
                textBox5.BackColor = Color.White;
                label7.Text = "";
                
            }

            else
            {
                textBox5.BackColor = Color.White;
                label7.Text = "";
                button1.Enabled = false;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                EmptyBoxStudent();
            }
            if (radioButton2.Checked == true)
            {
                EmptyBoxTeacher();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                EmptyBoxStudent();
            }
            if (radioButton2.Checked == true)
            {
                EmptyBoxTeacher();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            EmptyBoxStudent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            EmptyColor = Color.OrangeRed;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            EmptyBoxTeacher();
        }
    }
}