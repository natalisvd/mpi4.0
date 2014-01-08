using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Student
    {
        public void SaveStudent(DataGridView StudentdataGridView)
        {
            StreamWriter myWriter = new StreamWriter("Students.txt");
            try
            {
                for (int i = 0; i < StudentdataGridView.RowCount; i++)
                {
                    for (int j = 0; j < StudentdataGridView.ColumnCount; j++)
                    {
                        myWriter.Write(StudentdataGridView.Rows[i].Cells[j].Value.ToString() + "Æ");
                    }
                    myWriter.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                myWriter.Close();
            }

        }

        public void LoadStudents(DataGridView StudentdataGridView)
        {
            StreamReader myread = new StreamReader("Students.txt");
            string[] str;
            int num = 0;

            try
            {
                string[] str1 = myread.ReadToEnd().Split('\n');
                num = str1.Count() - 1;
                StudentdataGridView.RowCount = num;
                for (int i = 0; i < num; i++)
                {
                    str = str1[i].Split('Æ');
                    for (int j = 0; j < StudentdataGridView.ColumnCount; j++)
                    {
                        try
                        {
                            StudentdataGridView.Rows[i].Cells[j].Value = str[j];
                        }
                        catch { }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                myread.Close();
            }
        }

        public string Stat(double gpa)
        {
            if (gpa < 3) return "На отчисление";
            else return "Всё ок";

        }

        public void StateColored(DataGridView StudentdataGridView)
        {
            for (int i = 0; i < StudentdataGridView.Rows.Count; i++)
            {
                if (Convert.ToDouble(StudentdataGridView.Rows[i].Cells[2].Value) < 3)
                {
                    StudentdataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Tomato;
                }
                else StudentdataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
            }
        }

        public List<string> ListGroup(DataGridView StudentdataGridView)
        {
            List<string> listgroup = new List<string>();

            for (int i = 0; i < StudentdataGridView.RowCount; i++)
            {
                listgroup.Add(StudentdataGridView.Rows[i].Cells[1].Value.ToString());
            }

            for (int i = 0; i < listgroup.Count; i++)
            {
                for (int j = 0; j < listgroup.Count; j++)
                {
                    if (i != j && listgroup[i] == listgroup[j]) listgroup.Remove(listgroup[j]);
                }
            }

            for (int i = 0; i < listgroup.Count; i++)
            {
                for (int j = 0; j < listgroup.Count; j++)
                {
                    if (i != j && listgroup[i] == listgroup[j]) listgroup.Remove(listgroup[j]);
                }
            }


            return listgroup;
        }
    }
}