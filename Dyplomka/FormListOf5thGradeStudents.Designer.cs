namespace Dyplomka
{
    partial class FormListOf5thGradeStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListOf5thGradeStudents));
            this.MainPanel12 = new System.Windows.Forms.Panel();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAddAStudent = new System.Windows.Forms.Button();
            this.labelPaidInTheAmountOfАFood = new System.Windows.Forms.Label();
            this.labelThePaymentStatusOfThePower = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxPaidInTheAmountOf = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelAddAStudent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idschoolchieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплаченовразмереDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listOf5thGradeStudentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel12 = new System.Windows.Forms.Label();
            this.listOf5thGradeStudentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listOf5thGradeStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_of_5th_grade_studentsTableAdapter = new Dyplomka.SchoolCanteenDataSet3TableAdapters.List_of_5th_grade_studentsTableAdapter();
            this.MainPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOf5thGradeStudentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOf5thGradeStudentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOf5thGradeStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel12
            // 
            this.MainPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel12.Controls.Add(this.buttonDeleteStudent);
            this.MainPanel12.Controls.Add(this.buttonAddAStudent);
            this.MainPanel12.Controls.Add(this.labelPaidInTheAmountOfАFood);
            this.MainPanel12.Controls.Add(this.labelThePaymentStatusOfThePower);
            this.MainPanel12.Controls.Add(this.labelMiddleName);
            this.MainPanel12.Controls.Add(this.labelName);
            this.MainPanel12.Controls.Add(this.labelSurname);
            this.MainPanel12.Controls.Add(this.textBoxPaidInTheAmountOf);
            this.MainPanel12.Controls.Add(this.comboBoxPaymentStatus);
            this.MainPanel12.Controls.Add(this.textBoxMiddleName);
            this.MainPanel12.Controls.Add(this.textBoxName);
            this.MainPanel12.Controls.Add(this.textBoxSurname);
            this.MainPanel12.Controls.Add(this.labelAddAStudent);
            this.MainPanel12.Controls.Add(this.dataGridView1);
            this.MainPanel12.Controls.Add(this.buttonBack);
            this.MainPanel12.Controls.Add(this.panel2);
            this.MainPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel12.Location = new System.Drawing.Point(0, 0);
            this.MainPanel12.Name = "MainPanel12";
            this.MainPanel12.Size = new System.Drawing.Size(1034, 531);
            this.MainPanel12.TabIndex = 3;
            this.MainPanel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel12_MouseDown);
            this.MainPanel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel12_MouseMove);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteStudent.FlatAppearance.BorderSize = 0;
            this.buttonDeleteStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonDeleteStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(12, 466);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(262, 53);
            this.buttonDeleteStudent.TabIndex = 19;
            this.buttonDeleteStudent.Text = "Удалить учащегося";
            this.buttonDeleteStudent.UseVisualStyleBackColor = false;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            this.buttonDeleteStudent.MouseEnter += new System.EventHandler(this.buttonDeleteStudent_MouseEnter);
            // 
            // buttonAddAStudent
            // 
            this.buttonAddAStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonAddAStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddAStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonAddAStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonAddAStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAStudent.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddAStudent.Location = new System.Drawing.Point(363, 466);
            this.buttonAddAStudent.Name = "buttonAddAStudent";
            this.buttonAddAStudent.Size = new System.Drawing.Size(289, 53);
            this.buttonAddAStudent.TabIndex = 18;
            this.buttonAddAStudent.Text = "Добавить учащегося";
            this.buttonAddAStudent.UseVisualStyleBackColor = false;
            this.buttonAddAStudent.Click += new System.EventHandler(this.buttonAddAStudent_Click);
            this.buttonAddAStudent.MouseEnter += new System.EventHandler(this.buttonAddAStudent_MouseEnter);
            // 
            // labelPaidInTheAmountOfАFood
            // 
            this.labelPaidInTheAmountOfАFood.AutoSize = true;
            this.labelPaidInTheAmountOfАFood.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaidInTheAmountOfАFood.ForeColor = System.Drawing.Color.White;
            this.labelPaidInTheAmountOfАFood.Location = new System.Drawing.Point(82, 424);
            this.labelPaidInTheAmountOfАFood.Name = "labelPaidInTheAmountOfАFood";
            this.labelPaidInTheAmountOfАFood.Size = new System.Drawing.Size(295, 25);
            this.labelPaidInTheAmountOfАFood.TabIndex = 17;
            this.labelPaidInTheAmountOfАFood.Text = "Оплачено в размере питание:";
            // 
            // labelThePaymentStatusOfThePower
            // 
            this.labelThePaymentStatusOfThePower.AutoSize = true;
            this.labelThePaymentStatusOfThePower.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThePaymentStatusOfThePower.ForeColor = System.Drawing.Color.White;
            this.labelThePaymentStatusOfThePower.Location = new System.Drawing.Point(150, 394);
            this.labelThePaymentStatusOfThePower.Name = "labelThePaymentStatusOfThePower";
            this.labelThePaymentStatusOfThePower.Size = new System.Drawing.Size(236, 25);
            this.labelThePaymentStatusOfThePower.TabIndex = 16;
            this.labelThePaymentStatusOfThePower.Text = "Статус оплаты питания:";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiddleName.ForeColor = System.Drawing.Color.White;
            this.labelMiddleName.Location = new System.Drawing.Point(310, 364);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(104, 25);
            this.labelMiddleName.TabIndex = 15;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(368, 336);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 25);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Имя:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.Color.White;
            this.labelSurname.Location = new System.Drawing.Point(312, 309);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(102, 25);
            this.labelSurname.TabIndex = 13;
            this.labelSurname.Text = "Фамилия:";
            // 
            // textBoxPaidInTheAmountOf
            // 
            this.textBoxPaidInTheAmountOf.Location = new System.Drawing.Point(446, 424);
            this.textBoxPaidInTheAmountOf.Name = "textBoxPaidInTheAmountOf";
            this.textBoxPaidInTheAmountOf.Size = new System.Drawing.Size(306, 22);
            this.textBoxPaidInTheAmountOf.TabIndex = 12;
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.FormattingEnabled = true;
            this.comboBoxPaymentStatus.Items.AddRange(new object[] {
            "Оплачено",
            "Не оплачено"});
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(446, 394);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(306, 24);
            this.comboBoxPaymentStatus.TabIndex = 11;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(446, 366);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(306, 22);
            this.textBoxMiddleName.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(446, 338);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(306, 22);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(446, 310);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(306, 22);
            this.textBoxSurname.TabIndex = 8;
            // 
            // labelAddAStudent
            // 
            this.labelAddAStudent.AutoSize = true;
            this.labelAddAStudent.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddAStudent.ForeColor = System.Drawing.Color.White;
            this.labelAddAStudent.Location = new System.Drawing.Point(356, 259);
            this.labelAddAStudent.Name = "labelAddAStudent";
            this.labelAddAStudent.Size = new System.Drawing.Size(313, 37);
            this.labelAddAStudent.TabIndex = 7;
            this.labelAddAStudent.Text = "Добавить учащегося";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idschoolchieldDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.статусоплатыDataGridViewTextBoxColumn,
            this.оплаченовразмереDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listOf5thGradeStudentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // idschoolchieldDataGridViewTextBoxColumn
            // 
            this.idschoolchieldDataGridViewTextBoxColumn.DataPropertyName = "id_schoolchield";
            this.idschoolchieldDataGridViewTextBoxColumn.HeaderText = "id_schoolchield";
            this.idschoolchieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idschoolchieldDataGridViewTextBoxColumn.Name = "idschoolchieldDataGridViewTextBoxColumn";
            this.idschoolchieldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // статусоплатыDataGridViewTextBoxColumn
            // 
            this.статусоплатыDataGridViewTextBoxColumn.DataPropertyName = "Статус_оплаты";
            this.статусоплатыDataGridViewTextBoxColumn.HeaderText = "Статус_оплаты";
            this.статусоплатыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусоплатыDataGridViewTextBoxColumn.Name = "статусоплатыDataGridViewTextBoxColumn";
            // 
            // оплаченовразмереDataGridViewTextBoxColumn
            // 
            this.оплаченовразмереDataGridViewTextBoxColumn.DataPropertyName = "Оплачено_в_размере";
            this.оплаченовразмереDataGridViewTextBoxColumn.HeaderText = "Оплачено_в_размере";
            this.оплаченовразмереDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.оплаченовразмереDataGridViewTextBoxColumn.Name = "оплаченовразмереDataGridViewTextBoxColumn";
            // 
            // listOf5thGradeStudentsBindingSource1
            // 
            this.listOf5thGradeStudentsBindingSource1.DataMember = "List of 5th grade students";
            this.listOf5thGradeStudentsBindingSource1.DataSource = this.schoolCanteenDataSet3;
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
            this.buttonBack.Location = new System.Drawing.Point(859, 466);
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
            this.panel2.Controls.Add(this.TopPanel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(1004, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel12
            // 
            this.TopPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel12.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel12.ForeColor = System.Drawing.Color.White;
            this.TopPanel12.Location = new System.Drawing.Point(0, 0);
            this.TopPanel12.Name = "TopPanel12";
            this.TopPanel12.Size = new System.Drawing.Size(1034, 100);
            this.TopPanel12.TabIndex = 0;
            this.TopPanel12.Text = "Список учащихся 5-го класса";
            this.TopPanel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel12_MouseDown);
            this.TopPanel12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel12_MouseMove);
            // 
            // listOf5thGradeStudentsBindingSource2
            // 
            this.listOf5thGradeStudentsBindingSource2.DataMember = "List of 5th grade students";
            this.listOf5thGradeStudentsBindingSource2.DataSource = this.schoolCanteenDataSet3;
            // 
            // listOf5thGradeStudentsBindingSource
            // 
            this.listOf5thGradeStudentsBindingSource.DataMember = "List of 5th grade students";
            this.listOf5thGradeStudentsBindingSource.DataSource = this.schoolCanteenDataSet3;
            // 
            // list_of_5th_grade_studentsTableAdapter
            // 
            this.list_of_5th_grade_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // FormListOf5thGradeStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 531);
            this.Controls.Add(this.MainPanel12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListOf5thGradeStudents";
            this.Text = "FormListOf5thGradeStudents";
            this.Load += new System.EventHandler(this.FormListOf5thGradeStudents_Load);
            this.MainPanel12.ResumeLayout(false);
            this.MainPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOf5thGradeStudentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOf5thGradeStudentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOf5thGradeStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel12;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel12;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.BindingSource listOf5thGradeStudentsBindingSource;
        private SchoolCanteenDataSet3TableAdapters.List_of_5th_grade_studentsTableAdapter list_of_5th_grade_studentsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idschoolchieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплаченовразмереDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listOf5thGradeStudentsBindingSource1;
        private System.Windows.Forms.Button buttonAddAStudent;
        private System.Windows.Forms.Label labelPaidInTheAmountOfАFood;
        private System.Windows.Forms.Label labelThePaymentStatusOfThePower;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxPaidInTheAmountOf;
        private System.Windows.Forms.ComboBox comboBoxPaymentStatus;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelAddAStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.BindingSource listOf5thGradeStudentsBindingSource2;
    }
}