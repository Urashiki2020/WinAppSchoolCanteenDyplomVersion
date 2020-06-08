namespace Dyplomka
{
    partial class FormAttendanceOf5thGradeStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttendanceOf5thGradeStudents));
            this.MainPanel12 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonStudentAttendance = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelNumberOfStudents = new System.Windows.Forms.Label();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.textBoxNumberOfStudents = new System.Windows.Forms.TextBox();
            this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idattendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньнеделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоучащихсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceOf5thGradeStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel13 = new System.Windows.Forms.Label();
            this.attendance_of_5th_grade_studentsTableAdapter = new Dyplomka.SchoolCanteenDataSet3TableAdapters.Attendance_of_5th_grade_studentsTableAdapter();
            this.MainPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceOf5thGradeStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel12
            // 
            this.MainPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel12.Controls.Add(this.buttonDelete);
            this.MainPanel12.Controls.Add(this.buttonStudentAttendance);
            this.MainPanel12.Controls.Add(this.labelHeader);
            this.MainPanel12.Controls.Add(this.labelNumberOfStudents);
            this.MainPanel12.Controls.Add(this.labelDayOfWeek);
            this.MainPanel12.Controls.Add(this.textBoxNumberOfStudents);
            this.MainPanel12.Controls.Add(this.comboBoxDayOfWeek);
            this.MainPanel12.Controls.Add(this.dataGridView1);
            this.MainPanel12.Controls.Add(this.buttonBack);
            this.MainPanel12.Controls.Add(this.panel2);
            this.MainPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel12.Location = new System.Drawing.Point(0, 0);
            this.MainPanel12.Name = "MainPanel12";
            this.MainPanel12.Size = new System.Drawing.Size(800, 450);
            this.MainPanel12.TabIndex = 4;
            this.MainPanel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel12_MouseDown);
            this.MainPanel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel12_MouseMove);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(12, 385);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(207, 53);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Удалить запись";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonDelete_MouseEnter);
            // 
            // buttonStudentAttendance
            // 
            this.buttonStudentAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonStudentAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudentAttendance.FlatAppearance.BorderSize = 0;
            this.buttonStudentAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonStudentAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonStudentAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentAttendance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudentAttendance.ForeColor = System.Drawing.Color.White;
            this.buttonStudentAttendance.Location = new System.Drawing.Point(236, 385);
            this.buttonStudentAttendance.Name = "buttonStudentAttendance";
            this.buttonStudentAttendance.Size = new System.Drawing.Size(305, 53);
            this.buttonStudentAttendance.TabIndex = 18;
            this.buttonStudentAttendance.Text = "Записать в базу данных";
            this.buttonStudentAttendance.UseVisualStyleBackColor = false;
            this.buttonStudentAttendance.Click += new System.EventHandler(this.buttonStudentAttendance_Click);
            this.buttonStudentAttendance.MouseEnter += new System.EventHandler(this.buttonStudentAttendance_MouseEnter);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(115, 256);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(572, 37);
            this.labelHeader.TabIndex = 17;
            this.labelHeader.Text = "Управление посещаемостью учащихся";
            // 
            // labelNumberOfStudents
            // 
            this.labelNumberOfStudents.AutoSize = true;
            this.labelNumberOfStudents.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfStudents.ForeColor = System.Drawing.Color.White;
            this.labelNumberOfStudents.Location = new System.Drawing.Point(130, 337);
            this.labelNumberOfStudents.Name = "labelNumberOfStudents";
            this.labelNumberOfStudents.Size = new System.Drawing.Size(223, 25);
            this.labelNumberOfStudents.TabIndex = 16;
            this.labelNumberOfStudents.Text = "Количество учащихся:";
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayOfWeek.ForeColor = System.Drawing.Color.White;
            this.labelDayOfWeek.Location = new System.Drawing.Point(231, 309);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(138, 25);
            this.labelDayOfWeek.TabIndex = 15;
            this.labelDayOfWeek.Text = "День недели:";
            // 
            // textBoxNumberOfStudents
            // 
            this.textBoxNumberOfStudents.Location = new System.Drawing.Point(399, 339);
            this.textBoxNumberOfStudents.Name = "textBoxNumberOfStudents";
            this.textBoxNumberOfStudents.Size = new System.Drawing.Size(121, 22);
            this.textBoxNumberOfStudents.TabIndex = 8;
            // 
            // comboBoxDayOfWeek
            // 
            this.comboBoxDayOfWeek.FormattingEnabled = true;
            this.comboBoxDayOfWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница"});
            this.comboBoxDayOfWeek.Location = new System.Drawing.Point(399, 309);
            this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            this.comboBoxDayOfWeek.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDayOfWeek.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idattendanceDataGridViewTextBoxColumn,
            this.деньнеделиDataGridViewTextBoxColumn,
            this.количествоучащихсяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceOf5thGradeStudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(122, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // idattendanceDataGridViewTextBoxColumn
            // 
            this.idattendanceDataGridViewTextBoxColumn.DataPropertyName = "id_attendance";
            this.idattendanceDataGridViewTextBoxColumn.HeaderText = "id_attendance";
            this.idattendanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idattendanceDataGridViewTextBoxColumn.Name = "idattendanceDataGridViewTextBoxColumn";
            this.idattendanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // деньнеделиDataGridViewTextBoxColumn
            // 
            this.деньнеделиDataGridViewTextBoxColumn.DataPropertyName = "День_недели";
            this.деньнеделиDataGridViewTextBoxColumn.HeaderText = "День_недели";
            this.деньнеделиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.деньнеделиDataGridViewTextBoxColumn.Name = "деньнеделиDataGridViewTextBoxColumn";
            // 
            // количествоучащихсяDataGridViewTextBoxColumn
            // 
            this.количествоучащихсяDataGridViewTextBoxColumn.DataPropertyName = "Количество_учащихся";
            this.количествоучащихсяDataGridViewTextBoxColumn.HeaderText = "Количество_учащихся";
            this.количествоучащихсяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоучащихсяDataGridViewTextBoxColumn.Name = "количествоучащихсяDataGridViewTextBoxColumn";
            // 
            // attendanceOf5thGradeStudentsBindingSource
            // 
            this.attendanceOf5thGradeStudentsBindingSource.DataMember = "Attendance of 5th grade students";
            this.attendanceOf5thGradeStudentsBindingSource.DataSource = this.schoolCanteenDataSet3;
            // 
            // schoolCanteenDataSet3
            // 
            this.schoolCanteenDataSet3.DataSetName = "SchoolCanteenDataSet3";
            this.schoolCanteenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(625, 385);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(163, 53);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(770, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel13
            // 
            this.TopPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel13.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel13.ForeColor = System.Drawing.Color.White;
            this.TopPanel13.Location = new System.Drawing.Point(0, 0);
            this.TopPanel13.Name = "TopPanel13";
            this.TopPanel13.Size = new System.Drawing.Size(800, 100);
            this.TopPanel13.TabIndex = 0;
            this.TopPanel13.Text = "Посещаемость учащихся 5-го класса";
            this.TopPanel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel13_MouseDown);
            this.TopPanel13.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel13_MouseMove);
            // 
            // attendance_of_5th_grade_studentsTableAdapter
            // 
            this.attendance_of_5th_grade_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAttendanceOf5thGradeStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAttendanceOf5thGradeStudents";
            this.Text = "FormAttendanceOf5thGradeStudents";
            this.Load += new System.EventHandler(this.FormAttendanceOf5thGradeStudents_Load);
            this.MainPanel12.ResumeLayout(false);
            this.MainPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceOf5thGradeStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel12;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.BindingSource attendanceOf5thGradeStudentsBindingSource;
        private SchoolCanteenDataSet3TableAdapters.Attendance_of_5th_grade_studentsTableAdapter attendance_of_5th_grade_studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idattendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньнеделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоучащихсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxNumberOfStudents;
        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelNumberOfStudents;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Button buttonStudentAttendance;
        private System.Windows.Forms.Button buttonDelete;
    }
}