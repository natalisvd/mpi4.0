using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Teacher
    {
        public void SaveTeacher(DataGridView dataGridView2)
        {
            StreamWriter myWriter = new StreamWriter("Teachers.txt");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        myWriter.Write(dataGridView2.Rows[i].Cells[j].Value.ToString() + "Æ");
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

        public void LoadTeachers(DataGridView dataGridView2)
        {
            StreamReader myRead = new StreamReader("Teachers.txt");
            string[] str;
            int num = 0;

            try
            {
                string[] str1 = myRead.ReadToEnd().Split('\n');
                num = str1.Count() - 1;
                dataGridView2.RowCount = num;
                for (int i = 0; i < num; i++)
                {
                    str = str1[i].Split('Æ');
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        try
                        {
                            dataGridView2.Rows[i].Cells[j].Value = str[j];
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
                myRead.Close();
            }
        }
    }
}
