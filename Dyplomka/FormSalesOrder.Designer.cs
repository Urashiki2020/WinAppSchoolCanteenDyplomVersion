namespace Dyplomka
{
    partial class FormSalesOrder
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
            this.MainPanel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource11 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet5 = new Dyplomka.SchoolCanteenDataSet5();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel6 = new System.Windows.Forms.Label();
            this.ordersBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet1 = new Dyplomka.SchoolCanteenDataSet1();
            this.ordersTableAdapter = new Dyplomka.SchoolCanteenDataSet1TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ordersBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource9 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter4 = new Dyplomka.SchoolCanteenDataSet5TableAdapters.OrdersTableAdapter();
            this.MainPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource10)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel6
            // 
            this.MainPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel6.Controls.Add(this.dataGridView1);
            this.MainPanel6.Controls.Add(this.buttonReport);
            this.MainPanel6.Controls.Add(this.buttonBack);
            this.MainPanel6.Controls.Add(this.panel2);
            this.MainPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel6.Location = new System.Drawing.Point(0, 0);
            this.MainPanel6.Name = "MainPanel6";
            this.MainPanel6.Size = new System.Drawing.Size(983, 458);
            this.MainPanel6.TabIndex = 2;
            this.MainPanel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel6_MouseDown);
            this.MainPanel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel6_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.продуктDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource11;
            this.dataGridView1.Location = new System.Drawing.Point(10, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(961, 281);
            this.dataGridView1.TabIndex = 29;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "id_product";
            this.idproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductDataGridViewTextBoxColumn.Width = 125;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            this.клиентDataGridViewTextBoxColumn.Width = 125;
            // 
            // продуктDataGridViewTextBoxColumn
            // 
            this.продуктDataGridViewTextBoxColumn.DataPropertyName = "Продукт";
            this.продуктDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.продуктDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.продуктDataGridViewTextBoxColumn.Name = "продуктDataGridViewTextBoxColumn";
            this.продуктDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource11
            // 
            this.ordersBindingSource11.DataMember = "Orders";
            this.ordersBindingSource11.DataSource = this.schoolCanteenDataSet5;
            // 
            // schoolCanteenDataSet5
            // 
            this.schoolCanteenDataSet5.DataSetName = "SchoolCanteenDataSet5";
            this.schoolCanteenDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.ForeColor = System.Drawing.Color.White;
            this.buttonReport.Location = new System.Drawing.Point(315, 393);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(276, 53);
            this.buttonReport.TabIndex = 28;
            this.buttonReport.Text = "Сформировать отчет";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            this.buttonReport.MouseEnter += new System.EventHandler(this.buttonReport_MouseEnter);
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
            this.buttonBack.Location = new System.Drawing.Point(808, 393);
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
            this.panel2.Controls.Add(this.TopPanel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(950, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel6
            // 
            this.TopPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel6.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel6.ForeColor = System.Drawing.Color.White;
            this.TopPanel6.Location = new System.Drawing.Point(0, 0);
            this.TopPanel6.Name = "TopPanel6";
            this.TopPanel6.Size = new System.Drawing.Size(983, 100);
            this.TopPanel6.TabIndex = 0;
            this.TopPanel6.Text = "Заказы клиентов";
            this.TopPanel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel6_MouseDown);
            this.TopPanel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel6_MouseMove);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.schoolCanteenDataSet1;
            // 
            // schoolCanteenDataSet1
            // 
            this.schoolCanteenDataSet1.DataSetName = "SchoolCanteenDataSet1";
            this.schoolCanteenDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource7
            // 
            this.ordersBindingSource7.DataMember = "Orders";
            // 
            // schoolCanteenDataSet5BindingSource
            // 
            this.schoolCanteenDataSet5BindingSource.DataSource = this.schoolCanteenDataSet5;
            this.schoolCanteenDataSet5BindingSource.Position = 0;
            // 
            // ordersBindingSource10
            // 
            this.ordersBindingSource10.DataMember = "Orders";
            this.ordersBindingSource10.DataSource = this.schoolCanteenDataSet5;
            // 
            // ordersTableAdapter4
            // 
            this.ordersTableAdapter4.ClearBeforeFill = true;
            // 
            // FormSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 458);
            this.Controls.Add(this.MainPanel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSalesOrder";
            this.Text = "FormSalesOrder";
            this.Load += new System.EventHandler(this.FormSalesOrder_Load);
            this.MainPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel6;
        private SchoolCanteenDataSet1 schoolCanteenDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private SchoolCanteenDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.BindingSource ordersBindingSource4;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private System.Windows.Forms.BindingSource ordersBindingSource5;
        private System.Windows.Forms.BindingSource ordersBindingSource6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.BindingSource ordersBindingSource7;
        private System.Windows.Forms.BindingSource ordersBindingSource8;
        private System.Windows.Forms.BindingSource schoolCanteenDataSet4BindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource9;
        private System.Windows.Forms.BindingSource schoolCanteenDataSet3BindingSource;
        private System.Windows.Forms.BindingSource schoolCanteenDataSet5BindingSource;
        private SchoolCanteenDataSet5 schoolCanteenDataSet5;
        private System.Windows.Forms.BindingSource ordersBindingSource10;
        private SchoolCanteenDataSet5TableAdapters.OrdersTableAdapter ordersTableAdapter4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn продуктDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource11;
    }
}