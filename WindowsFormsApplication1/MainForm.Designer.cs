namespace WindowsFormsApplication1
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSendDown = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StudentdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TeacherdataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnterAdmin = new System.Windows.Forms.Button();
            this.buttonExitAdmin = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupShow = new System.Windows.Forms.Button();
            this.Guide = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).BeginInit();
            this.AdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(1, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 45);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSendDown
            // 
            this.buttonSendDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSendDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendDown.Location = new System.Drawing.Point(1, 75);
            this.buttonSendDown.Name = "buttonSendDown";
            this.buttonSendDown.Size = new System.Drawing.Size(119, 45);
            this.buttonSendDown.TabIndex = 1;
            this.buttonSendDown.Text = "Отчислить";
            this.buttonSendDown.UseVisualStyleBackColor = false;
            this.buttonSendDown.Click += new System.EventHandler(this.buttonSendDown_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMove.Location = new System.Drawing.Point(1, 126);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(119, 45);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Перевести";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(143, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(579, 606);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StudentdataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(571, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StudentdataGridView
            // 
            this.StudentdataGridView.AllowUserToAddRows = false;
            this.StudentdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.StudentdataGridView.Location = new System.Drawing.Point(6, 3);
            this.StudentdataGridView.Name = "StudentdataGridView";
            this.StudentdataGridView.Size = new System.Drawing.Size(560, 576);
            this.StudentdataGridView.TabIndex = 0;
            this.StudentdataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentdataGridView_CellValidated);
            this.StudentdataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.StudentdataGridView_CellValidating);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Группа";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Средний балл";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Статус";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TeacherdataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(571, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сотрудники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TeacherdataGridView
            // 
            this.TeacherdataGridView.AllowUserToAddRows = false;
            this.TeacherdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.TeacherdataGridView.Location = new System.Drawing.Point(6, 3);
            this.TeacherdataGridView.Name = "TeacherdataGridView";
            this.TeacherdataGridView.Size = new System.Drawing.Size(560, 576);
            this.TeacherdataGridView.TabIndex = 0;
            this.TeacherdataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TeacherdataGridView_CellValidating);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ФИО";
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Должность";
            this.Column6.Name = "Column6";
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.label2);
            this.AdminPanel.Controls.Add(this.buttonLoad);
            this.AdminPanel.Controls.Add(this.buttonSave);
            this.AdminPanel.Controls.Add(this.buttonAdd);
            this.AdminPanel.Controls.Add(this.buttonSendDown);
            this.AdminPanel.Controls.Add(this.buttonMove);
            this.AdminPanel.Location = new System.Drawing.Point(12, 105);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(121, 441);
            this.AdminPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // buttonLoad
            // 
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Location = new System.Drawing.Point(3, 400);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(115, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(3, 342);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // buttonEnterAdmin
            // 
            this.buttonEnterAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnterAdmin.Location = new System.Drawing.Point(6, 37);
            this.buttonEnterAdmin.Name = "buttonEnterAdmin";
            this.buttonEnterAdmin.Size = new System.Drawing.Size(131, 23);
            this.buttonEnterAdmin.TabIndex = 7;
            this.buttonEnterAdmin.Text = "Войти как админ";
            this.buttonEnterAdmin.UseVisualStyleBackColor = true;
            this.buttonEnterAdmin.Click += new System.EventHandler(this.buttonEnterAdmin_Click);
            // 
            // buttonExitAdmin
            // 
            this.buttonExitAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitAdmin.Location = new System.Drawing.Point(6, 37);
            this.buttonExitAdmin.Name = "buttonExitAdmin";
            this.buttonExitAdmin.Size = new System.Drawing.Size(131, 23);
            this.buttonExitAdmin.TabIndex = 8;
            this.buttonExitAdmin.Text = "Выйти";
            this.buttonExitAdmin.UseVisualStyleBackColor = true;
            this.buttonExitAdmin.Visible = false;
            this.buttonExitAdmin.Click += new System.EventHandler(this.buttonExitAdmin_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вывести группу";
            // 
            // GroupShow
            // 
            this.GroupShow.BackColor = System.Drawing.Color.White;
            this.GroupShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupShow.Location = new System.Drawing.Point(30, 346);
            this.GroupShow.Name = "GroupShow";
            this.GroupShow.Size = new System.Drawing.Size(75, 23);
            this.GroupShow.TabIndex = 11;
            this.GroupShow.Text = "Вывести";
            this.GroupShow.UseVisualStyleBackColor = false;
            this.GroupShow.Click += new System.EventHandler(this.GroupShow_Click);
            // 
            // Guide
            // 
            this.Guide.BackColor = System.Drawing.Color.Gray;
            this.Guide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guide.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guide.ForeColor = System.Drawing.Color.Blue;
            this.Guide.Location = new System.Drawing.Point(701, 0);
            this.Guide.Name = "Guide";
            this.Guide.Size = new System.Drawing.Size(27, 27);
            this.Guide.TabIndex = 12;
            this.Guide.Text = "?";
            this.Guide.UseVisualStyleBackColor = false;
            this.Guide.Click += new System.EventHandler(this.Guide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 630);
            this.Controls.Add(this.Guide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupShow);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonExitAdmin);
            this.Controls.Add(this.buttonEnterAdmin);
            this.Controls.Add(this.AdminPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MianForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentdataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeacherdataGridView)).EndInit();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSendDown;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView StudentdataGridView;
        private System.Windows.Forms.DataGridView TeacherdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnterAdmin;
        private System.Windows.Forms.Button buttonExitAdmin;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GroupShow;
        private System.Windows.Forms.Button Guide;
    }
}

