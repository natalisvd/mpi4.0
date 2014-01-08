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
    public partial class GroupShow : Form
    {
        List<List<string>> ListOfStudentsInOneGroup = new List<List<string>>();

        public GroupShow(string group, List<List<string>> ListOfStudentsInOneGroup)
        {
            InitializeComponent();
            this.ListOfStudentsInOneGroup = ListOfStudentsInOneGroup;
            label1.Text += group;
        }

        private void GroupShow_Load(object sender, EventArgs e)
        {
            List<string> row = new List<string>();
            int k = 0;            
            for (int i = 0; i < ListOfStudentsInOneGroup.Count; i++)
            {
                row = ListOfStudentsInOneGroup[i];

                if (row.Count != 0)
                {
                    StudentdataGridView.Rows.Add(row[0], row[1], row[2], row[3]);
                    k++;
                }

                else continue;
            }

            Student student = new Student();
            student.StateColored(StudentdataGridView);
        }
    }
}