using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Password
    {
        public string Enter()
        {
            try
            {
                StreamReader myread = new StreamReader("Pass.pass");
                string s = "";
                s = myread.ReadLine();
                myread.Close();
                return s;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "0000";
            }
        }

        public bool ChangePass(string s1, string s2,string s3)
        {
            if (s2 == s3 && s1 == Enter())
            {
                try
                {
                    StreamWriter mywriter = new StreamWriter("Pass.pass");
                    mywriter.WriteLine(s2);
                    mywriter.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }

            else
            {
                return false;
            }

        }
    }
}