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
    public partial class MoveGroup : Form
    {
        MainForm f1 = new MainForm();

        public MoveGroup()
        {
            InitializeComponent();
        }

        public string Group()
        {
            return textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.Match(textBox1.Text, "^[А-Я]+[/-]{1}[0-9]+$").Success == false && System.Text.RegularExpressions.Regex.Match(textBox1.Text, "^[А-Я]+[/-]{1}[0-9]+[/-]{1}[0-9]+$").Success == false)
            {
                MessageBox.Show("Введено некорректное значение поля \"Группа\"!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
