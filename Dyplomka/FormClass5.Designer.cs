namespace Dyplomka
{
    partial class FormClass5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClass5));
            this.MainPanel2 = new System.Windows.Forms.Panel();
            this.list_of_5th_grade_studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_of_5th_grade_studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idattendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньнеделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоучащихсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceOf5thGradeStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelStudentAttendance = new System.Windows.Forms.Label();
            this.labelListOfStudents = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel2 = new System.Windows.Forms.Label();
            this.attendance_of_5th_grade_studentsTableAdapter = new Dyplomka.SchoolCanteenDataSet3TableAdapters.Attendance_of_5th_grade_studentsTableAdapter();
            this.list_of_5th_grade_studentsTableAdapter = new Dyplomka.SchoolCanteenDataSet3TableAdapters.List_of_5th_grade_studentsTableAdapter();
            this.tableAdapterManager = new Dyplomka.SchoolCanteenDataSet3TableAdapters.TableAdapterManager();
            this.MainPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_5th_grade_studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_5th_grade_studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceOf5thGradeStudentsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel2
            // 
            this.MainPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel2.Controls.Add(this.list_of_5th_grade_studentsDataGridView);
            this.MainPanel2.Controls.Add(this.button1);
            this.MainPanel2.Controls.Add(this.dataGridView2);
            this.MainPanel2.Controls.Add(this.labelStudentAttendance);
            this.MainPanel2.Controls.Add(this.labelListOfStudents);
            this.MainPanel2.Controls.Add(this.buttonBack);
            this.MainPanel2.Controls.Add(this.panel2);
            this.MainPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel2.Location = new System.Drawing.Point(0, 0);
            this.MainPanel2.Name = "MainPanel2";
            this.MainPanel2.Size = new System.Drawing.Size(1012, 565);
            this.MainPanel2.TabIndex = 2;
            this.MainPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel2_MouseDown);
            this.MainPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel2_MouseMove);
            // 
            // list_of_5th_grade_studentsDataGridView
            // 
            this.list_of_5th_grade_studentsDataGridView.AutoGenerateColumns = false;
            this.list_of_5th_grade_studentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.list_of_5th_grade_studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_of_5th_grade_studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.list_of_5th_grade_studentsDataGridView.DataSource = this.list_of_5th_grade_studentsBindingSource;
            this.list_of_5th_grade_studentsDataGridView.Location = new System.Drawing.Point(3, 134);
            this.list_of_5th_grade_studentsDataGridView.Name = "list_of_5th_grade_studentsDataGridView";
            this.list_of_5th_grade_studentsDataGridView.RowHeadersWidth = 51;
            this.list_of_5th_grade_studentsDataGridView.RowTemplate.Height = 24;
            this.list_of_5th_grade_studentsDataGridView.Size = new System.Drawing.Size(1006, 159);
            this.list_of_5th_grade_studentsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_schoolchield";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_schoolchield";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Статус_оплаты";
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус_оплаты";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Оплачено_в_размере";
            this.dataGridViewTextBoxColumn6.HeaderText = "Оплачено_в_размере";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // list_of_5th_grade_studentsBindingSource
            // 
            this.list_of_5th_grade_studentsBindingSource.DataMember = "List of 5th grade students";
            this.list_of_5th_grade_studentsBindingSource.DataSource = this.schoolCanteenDataSet3;
            // 
            // schoolCanteenDataSet3
            // 
            this.schoolCanteenDataSet3.DataSetName = "SchoolCanteenDataSet3";
            this.schoolCanteenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Заказать продукты";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idattendanceDataGridViewTextBoxColumn,
            this.деньнеделиDataGridViewTextBoxColumn,
            this.количествоучащихсяDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.attendanceOf5thGradeStudentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(205, 336);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(580, 150);
            this.dataGridView2.TabIndex = 10;
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
            // labelStudentAttendance
            // 
            this.labelStudentAttendance.AutoSize = true;
            this.labelStudentAttendance.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentAttendance.ForeColor = System.Drawing.Color.White;
            this.labelStudentAttendance.Location = new System.Drawing.Point(307, 296);
            this.labelStudentAttendance.Name = "labelStudentAttendance";
            this.labelStudentAttendance.Size = new System.Drawing.Size(373, 37);
            this.labelStudentAttendance.TabIndex = 9;
            this.labelStudentAttendance.Text = "Посещаемость учащихся";
            // 
            // labelListOfStudents
            // 
            this.labelListOfStudents.AutoSize = true;
            this.labelListOfStudents.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListOfStudents.ForeColor = System.Drawing.Color.White;
            this.labelListOfStudents.Location = new System.Drawing.Point(366, 103);
            this.labelListOfStudents.Name = "labelListOfStudents";
            this.labelListOfStudents.Size = new System.Drawing.Size(264, 37);
            this.labelListOfStudents.TabIndex = 8;
            this.labelListOfStudents.Text = "Список учащихся";
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
            this.buttonBack.Location = new System.Drawing.Point(829, 487);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(163, 53);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(974, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel2
            // 
            this.TopPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel2.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel2.ForeColor = System.Drawing.Color.White;
            this.TopPanel2.Location = new System.Drawing.Point(0, 0);
            this.TopPanel2.Name = "TopPanel2";
            this.TopPanel2.Size = new System.Drawing.Size(1012, 100);
            this.TopPanel2.TabIndex = 0;
            this.TopPanel2.Text = "5-ый класс";
            this.TopPanel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel2_MouseDown);
            this.TopPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel2_MouseMove);
            // 
            // attendance_of_5th_grade_studentsTableAdapter
            // 
            this.attendance_of_5th_grade_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // list_of_5th_grade_studentsTableAdapter
            // 
            this.list_of_5th_grade_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Attendance_of_10th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.Attendance_of_11th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.Attendance_of_5th_grade_studentsTableAdapter = this.attendance_of_5th_grade_studentsTableAdapter;
            this.tableAdapterManager.Attendance_of_6th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.Attendance_of_7th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.Attendance_of_8th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.Attendance_of_9th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Dining_room_menuTableAdapter = null;
            this.tableAdapterManager.Employee_s_orderTableAdapter = null;
            this.tableAdapterManager.Employee_work_scheduleTableAdapter = null;
            this.tableAdapterManager.List_of_10th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.List_of_11th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.List_of_5th_grade_studentsTableAdapter = this.list_of_5th_grade_studentsTableAdapter;
            this.tableAdapterManager.List_of_6th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.List_of_7th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.List_of_8th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.List_of_9th_grade_studentsTableAdapter = null;
            this.tableAdapterManager.List_of_classesTableAdapter = null;
            this.tableAdapterManager.List_of_employeesTableAdapter = null;
            this.tableAdapterManager.Orders_TableAdapter = null;
            this.tableAdapterManager.The_report_of_the_school_cafeteriaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dyplomka.SchoolCanteenDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // FormClass5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 565);
            this.Controls.Add(this.MainPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClass5";
            this.Text = "FormClass5";
            this.Load += new System.EventHandler(this.FormClass5_Load);
            this.MainPanel2.ResumeLayout(false);
            this.MainPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_5th_grade_studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_of_5th_grade_studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceOf5thGradeStudentsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel2;
        private System.Windows.Forms.Button buttonBack;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelStudentAttendance;
        private System.Windows.Forms.Label labelListOfStudents;
        private SchoolCanteenDataSet3TableAdapters.Attendance_of_5th_grade_studentsTableAdapter attendance_of_5th_grade_studentsTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idattendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньнеделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоучащихсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource attendanceOf5thGradeStudentsBindingSource;
        private System.Windows.Forms.BindingSource list_of_5th_grade_studentsBindingSource;
        private SchoolCanteenDataSet3TableAdapters.List_of_5th_grade_studentsTableAdapter list_of_5th_grade_studentsTableAdapter;
        private SchoolCanteenDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView list_of_5th_grade_studentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}