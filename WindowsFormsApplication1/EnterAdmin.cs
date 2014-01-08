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
    public partial class EnterAdmin : Form
    {
        Password si = new Password();

        public EnterAdmin()
        {
            InitializeComponent();
        }

        private void OKClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public bool AdminEnter()
        {
            
            if (textBox1.Text == si.Enter())
            {
                return true;
            }
            else return false;
        }

        private void EnterAdminLoad(object sender, EventArgs e)
        {
            textBox1.PasswordChar ='*';
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (si.ChangePass(textBox2.Text, textBox3.Text, textBox4.Text))
            {
                panel1.Visible = false;
                panelEnter.Visible = true;
            }
            else
            {
                MessageBox.Show("Неверно введён старый пароль\n или неверно повторён новый пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelEnter.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelEnter.Visible = false;
        }

        private void panelEnter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}