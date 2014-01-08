using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        Student student = new Student();
        Teacher teacher = new Teacher();
        List<string> listgroup = new List<string>();
        List<List<string>> ListOfStudentsInOneGroup = new List<List<string>>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddForm add = new AddForm();
                add.ShowDialog();

                if (add.DialogResult == DialogResult.OK && add.Change() == 1)
                {
                    StudentdataGridView.Rows.Add(add.FullName(), add.Group(), add.Gpa(), student.Stat(Convert.ToDouble(add.Gpa())));
                    student.StateColored(StudentdataGridView);
                }

                else if (add.DialogResult == DialogResult.OK && add.Change() == 2)
                {
                    TeacherdataGridView.Rows.Add(add.FullName(), add.Major());
                }

                RefreshCB();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        } // Добавление

        private void buttonMove_Click(object sender, EventArgs e)
        {
            MoveGroup move = new MoveGroup();
            move.ShowDialog();

            if (move.DialogResult == DialogResult.OK && tabControl.SelectedIndex == 0)
            {
                int ind = StudentdataGridView.SelectedCells[0].RowIndex;
                StudentdataGridView.Rows[ind].Cells[1].Value = move.Group();
                RefreshCB();
            }
            else if (move.DialogResult == DialogResult.Cancel) { }

            else
            {
                MessageBox.Show("Error");
            }


        } // Перевод

        private void buttonSendDown_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.DialogResult.No;

            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    int ind = StudentdataGridView.SelectedCells[0].RowIndex;
                    result = MessageBox.Show("Отчислить студента:\n" + StudentdataGridView.Rows[ind].Cells[0].Value + " ?", "Отчислить?", MessageBoxButtons.YesNo);
                }

                if (tabControl.SelectedIndex == 1)
                {
                    int ind = TeacherdataGridView.SelectedCells[0].RowIndex;
                    result = MessageBox.Show("Уволить сотрудника:\n" + TeacherdataGridView.Rows[ind].Cells[0].Value + " ?", "Уволить?", MessageBoxButtons.YesNo);
                }

                else { }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (result == DialogResult.Yes)
                {
                    if (tabControl.SelectedIndex == 0)
                    {
                        int ind = StudentdataGridView.SelectedCells[0].RowIndex;
                        StudentdataGridView.Rows.RemoveAt(ind);
                    }

                    else if (tabControl.SelectedIndex == 1)
                    {
                        int ind = TeacherdataGridView.SelectedCells[0].RowIndex;
                        TeacherdataGridView.Rows.RemoveAt(ind);
                    }

                    else { }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // Отчисление

        private void MianForm_Load(object sender, EventArgs e)
        {
            student.LoadStudents(StudentdataGridView);
            teacher.LoadTeachers(TeacherdataGridView);
            student.StateColored(StudentdataGridView);
            DefaultMode();
            RefreshCB();

            label2.Text = "Последняя правка:\n" + File.GetLastWriteTime("Students.txt");
        }

        private void StudentdataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    double cellValue = Convert.ToDouble(e.FormattedValue.ToString());
                    if (cellValue > 5 || cellValue < 0)
                    {
                        MessageBox.Show("Значение не может быть больше 5 или меньше 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Введено некорректное значение!\n ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }

            }

            if (e.ColumnIndex == 0)
            {
                try
                {
                    string cellValue = e.FormattedValue.ToString();

                    if (System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false)
                    {
                        MessageBox.Show("Введено некорректное значение!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void StudentdataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int ind = StudentdataGridView.SelectedCells[0].RowIndex;
                StudentdataGridView.Rows[ind].Cells[3].Value = student.Stat(Convert.ToDouble(StudentdataGridView.Rows[ind].Cells[2].Value));
                student.StateColored(StudentdataGridView);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            student.SaveStudent(StudentdataGridView);
            teacher.SaveTeacher(TeacherdataGridView);
        }

        public void DefaultMode()
        {
            label1.Text = "Вы находитесь в:\nстандартном режиме";
            buttonExitAdmin.Visible = false;
            buttonEnterAdmin.Visible = true;
            AdminPanel.Visible = false;
            StudentdataGridView.ReadOnly = true;
            TeacherdataGridView.ReadOnly = true;
        }

        public void AdminMode()
        {
            buttonExitAdmin.Visible = true;
            buttonEnterAdmin.Visible = false;
            label1.Text = "Вы находитесь в:\nрежиме администратора";

            AdminPanel.Visible = true;
            StudentdataGridView.ReadOnly = false;
            StudentdataGridView.Columns[1].ReadOnly = true;
            StudentdataGridView.Columns[3].ReadOnly = true;
            TeacherdataGridView.ReadOnly = false;
        }

        public void RefreshCB()
        {
            listgroup.Clear();
            comboBox1.Items.Clear();
            listgroup = student.ListGroup(StudentdataGridView);
            for (int i = 0; i < listgroup.Count; i++)
            {
                comboBox1.Items.Add(listgroup[i]);
            }
        }

        private void buttonEnterAdmin_Click(object sender, EventArgs e)
        {
            EnterAdmin ea = new EnterAdmin();
            ea.ShowDialog();

            if (ea.DialogResult == DialogResult.OK && ea.AdminEnter() == true)
            {
                AdminMode();
            }

            else DefaultMode();
        }

        private void buttonExitAdmin_Click(object sender, EventArgs e)
        {
            DefaultMode();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            student.SaveStudent(StudentdataGridView);
            teacher.SaveTeacher(TeacherdataGridView);
            label2.Text = "Последняя правка:\n" + File.GetLastWriteTime("Students.txt");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            student.LoadStudents(StudentdataGridView);
            teacher.LoadTeachers(TeacherdataGridView);
            student.StateColored(StudentdataGridView);
        }

        private void TeacherdataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                try
                {
                    if (e.FormattedValue.ToString() == "")
                    {
                        MessageBox.Show("Введите значение!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (e.ColumnIndex == 0)
            {
                try
                {
                    string cellValue = e.FormattedValue.ToString();

                    if (System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false && System.Text.RegularExpressions.Regex.Match(cellValue, "^[' ']*[А-ИК-ЩЭ-Я][а-я]+[' ']+[А-ИК-ЩЭ-Я][а-я]+[/-]{1}[А-ИК-ЩЭ-Я][а-я]+[' ']*$").Success == false)
                    {
                        MessageBox.Show("Введено некорректное значение!\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void ListStudentInGroup()
        {
            ListOfStudentsInOneGroup.Clear();
            try
            {
                for (int i = 0; i < StudentdataGridView.Rows.Count; i++)
                {
                    List<string> row = new List<string>();

                    for (int j = 0; j < StudentdataGridView.ColumnCount; j++)
                    {
                        if (StudentdataGridView.Rows[i].Cells[1].Value.ToString() == comboBox1.SelectedItem.ToString())
                        {
                            row.Add(StudentdataGridView.Rows[i].Cells[j].Value.ToString());
                        }

                        else break;
                    }
                    ListOfStudentsInOneGroup.Add(row);
                }
            }
            catch { }
        }

        private void GroupShow_Click(object sender, EventArgs e)
        {
            try
            {
                ListStudentInGroup();
                GroupShow gs = new GroupShow(comboBox1.SelectedItem.ToString(), ListOfStudentsInOneGroup);
                gs.ShowDialog();
            }
            catch { }
        }

        private void Guide_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Firefox.exe",@"Guide/index.html");
        }
    }
}