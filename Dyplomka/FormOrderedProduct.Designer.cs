namespace Dyplomka
{
    partial class FormOrderedProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderedProduct));
            this.MainPanel4 = new System.Windows.Forms.Panel();
            this.buttonToOrder = new System.Windows.Forms.Button();
            this.labelNumberOfProductSets = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деньнеделиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествонаборовпродуктовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxNumberOfProductSets = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel4 = new System.Windows.Forms.Label();
            this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.employee_s_orderTableAdapter = new Dyplomka.SchoolCanteenDataSet3TableAdapters.Employee_s_orderTableAdapter();
            this.MainPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel4
            // 
            this.MainPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel4.Controls.Add(this.buttonToOrder);
            this.MainPanel4.Controls.Add(this.labelNumberOfProductSets);
            this.MainPanel4.Controls.Add(this.dataGridView1);
            this.MainPanel4.Controls.Add(this.labelDayOfWeek);
            this.MainPanel4.Controls.Add(this.buttonBack);
            this.MainPanel4.Controls.Add(this.textBoxNumberOfProductSets);
            this.MainPanel4.Controls.Add(this.panel2);
            this.MainPanel4.Controls.Add(this.comboBoxDayOfWeek);
            this.MainPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel4.Location = new System.Drawing.Point(0, 0);
            this.MainPanel4.Name = "MainPanel4";
            this.MainPanel4.Size = new System.Drawing.Size(798, 450);
            this.MainPanel4.TabIndex = 3;
            this.MainPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel4_MouseDown);
            this.MainPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel4_MouseMove);
            // 
            // buttonToOrder
            // 
            this.buttonToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonToOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToOrder.FlatAppearance.BorderSize = 0;
            this.buttonToOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonToOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToOrder.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToOrder.ForeColor = System.Drawing.Color.White;
            this.buttonToOrder.Location = new System.Drawing.Point(241, 385);
            this.buttonToOrder.Name = "buttonToOrder";
            this.buttonToOrder.Size = new System.Drawing.Size(254, 53);
            this.buttonToOrder.TabIndex = 23;
            this.buttonToOrder.Text = "Заказать продукты";
            this.buttonToOrder.UseVisualStyleBackColor = false;
            this.buttonToOrder.Click += new System.EventHandler(this.buttonToOrder_Click);
            this.buttonToOrder.MouseEnter += new System.EventHandler(this.buttonToOrder_MouseEnter);
            // 
            // labelNumberOfProductSets
            // 
            this.labelNumberOfProductSets.AutoSize = true;
            this.labelNumberOfProductSets.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfProductSets.ForeColor = System.Drawing.Color.White;
            this.labelNumberOfProductSets.Location = new System.Drawing.Point(27, 324);
            this.labelNumberOfProductSets.Name = "labelNumberOfProductSets";
            this.labelNumberOfProductSets.Size = new System.Drawing.Size(313, 25);
            this.labelNumberOfProductSets.TabIndex = 22;
            this.labelNumberOfProductSets.Text = "Количество наборов продуктов:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.деньнеделиDataGridViewTextBoxColumn,
            this.количествонаборовпродуктовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeesOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "id_order";
            this.idorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // деньнеделиDataGridViewTextBoxColumn
            // 
            this.деньнеделиDataGridViewTextBoxColumn.DataPropertyName = "День_недели";
            this.деньнеделиDataGridViewTextBoxColumn.HeaderText = "День_недели";
            this.деньнеделиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.деньнеделиDataGridViewTextBoxColumn.Name = "деньнеделиDataGridViewTextBoxColumn";
            // 
            // количествонаборовпродуктовDataGridViewTextBoxColumn
            // 
            this.количествонаборовпродуктовDataGridViewTextBoxColumn.DataPropertyName = "Количество_наборов_продуктов";
            this.количествонаборовпродуктовDataGridViewTextBoxColumn.HeaderText = "Количество_наборов_продуктов";
            this.количествонаборовпродуктовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествонаборовпродуктовDataGridViewTextBoxColumn.Name = "количествонаборовпродуктовDataGridViewTextBoxColumn";
            // 
            // employeesOrderBindingSource
            // 
            this.employeesOrderBindingSource.DataMember = "Employee\'s order";
            this.employeesOrderBindingSource.DataSource = this.schoolCanteenDataSet3;
            // 
            // schoolCanteenDataSet3
            // 
            this.schoolCanteenDataSet3.DataSetName = "SchoolCanteenDataSet3";
            this.schoolCanteenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayOfWeek.ForeColor = System.Drawing.Color.White;
            this.labelDayOfWeek.Location = new System.Drawing.Point(243, 294);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(138, 25);
            this.labelDayOfWeek.TabIndex = 21;
            this.labelDayOfWeek.Text = "День недели:";
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
            // textBoxNumberOfProductSets
            // 
            this.textBoxNumberOfProductSets.Location = new System.Drawing.Point(433, 324);
            this.textBoxNumberOfProductSets.Name = "textBoxNumberOfProductSets";
            this.textBoxNumberOfProductSets.Size = new System.Drawing.Size(212, 22);
            this.textBoxNumberOfProductSets.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(767, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel4
            // 
            this.TopPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel4.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel4.ForeColor = System.Drawing.Color.White;
            this.TopPanel4.Location = new System.Drawing.Point(0, 0);
            this.TopPanel4.Name = "TopPanel4";
            this.TopPanel4.Size = new System.Drawing.Size(798, 100);
            this.TopPanel4.TabIndex = 0;
            this.TopPanel4.Text = "Заказать продукты";
            this.TopPanel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel4_MouseDown);
            this.TopPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel4_MouseMove);
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
            this.comboBoxDayOfWeek.Location = new System.Drawing.Point(433, 294);
            this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            this.comboBoxDayOfWeek.Size = new System.Drawing.Size(212, 24);
            this.comboBoxDayOfWeek.TabIndex = 19;
            // 
            // employee_s_orderTableAdapter
            // 
            this.employee_s_orderTableAdapter.ClearBeforeFill = true;
            // 
            // FormOrderedProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.MainPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrderedProduct";
            this.Text = "FormOrderedProduct";
            this.Load += new System.EventHandler(this.FormOrderedProduct_Load);
            this.MainPanel4.ResumeLayout(false);
            this.MainPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.BindingSource employeesOrderBindingSource;
        private SchoolCanteenDataSet3TableAdapters.Employee_s_orderTableAdapter employee_s_orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn деньнеделиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествонаборовпродуктовDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonToOrder;
        private System.Windows.Forms.Label labelNumberOfProductSets;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.TextBox textBoxNumberOfProductSets;
        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
    }
}