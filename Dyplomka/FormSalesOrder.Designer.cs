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
            System.Windows.Forms.Label id_productLabel;
            System.Windows.Forms.Label клиентLabel;
            System.Windows.Forms.Label наименование_продуктаLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label количествоLabel;
            this.MainPanel6 = new System.Windows.Forms.Panel();
            this.id_productTextBox = new System.Windows.Forms.TextBox();
            this.ordersBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.клиентTextBox = new System.Windows.Forms.TextBox();
            this.наименование_продуктаTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel6 = new System.Windows.Forms.Label();
            this.ordersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet1 = new Dyplomka.SchoolCanteenDataSet1();
            this.ordersTableAdapter = new Dyplomka.SchoolCanteenDataSet1TableAdapters.OrdersTableAdapter();
            this.schoolCanteenDataSet2 = new Dyplomka.SchoolCanteenDataSet2();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new Dyplomka.SchoolCanteenDataSet2TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter2 = new Dyplomka.SchoolCanteenDataSet3TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Dyplomka.SchoolCanteenDataSet3TableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonPrint1 = new System.Windows.Forms.Button();
            id_productLabel = new System.Windows.Forms.Label();
            клиентLabel = new System.Windows.Forms.Label();
            наименование_продуктаLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            this.MainPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // id_productLabel
            // 
            id_productLabel.AutoSize = true;
            id_productLabel.ForeColor = System.Drawing.Color.White;
            id_productLabel.Location = new System.Drawing.Point(653, 179);
            id_productLabel.Name = "id_productLabel";
            id_productLabel.Size = new System.Drawing.Size(75, 17);
            id_productLabel.TabIndex = 18;
            id_productLabel.Text = "id product:";
            // 
            // клиентLabel
            // 
            клиентLabel.AutoSize = true;
            клиентLabel.ForeColor = System.Drawing.Color.White;
            клиентLabel.Location = new System.Drawing.Point(653, 207);
            клиентLabel.Name = "клиентLabel";
            клиентLabel.Size = new System.Drawing.Size(60, 17);
            клиентLabel.TabIndex = 20;
            клиентLabel.Text = "Клиент:";
            // 
            // наименование_продуктаLabel
            // 
            наименование_продуктаLabel.AutoSize = true;
            наименование_продуктаLabel.ForeColor = System.Drawing.Color.White;
            наименование_продуктаLabel.Location = new System.Drawing.Point(653, 235);
            наименование_продуктаLabel.Name = "наименование_продуктаLabel";
            наименование_продуктаLabel.Size = new System.Drawing.Size(175, 17);
            наименование_продуктаLabel.TabIndex = 22;
            наименование_продуктаLabel.Text = "Наименование продукта:";
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.ForeColor = System.Drawing.Color.White;
            ценаLabel.Location = new System.Drawing.Point(653, 263);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(47, 17);
            ценаLabel.TabIndex = 24;
            ценаLabel.Text = "Цена:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.ForeColor = System.Drawing.Color.White;
            количествоLabel.Location = new System.Drawing.Point(653, 291);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(90, 17);
            количествоLabel.TabIndex = 26;
            количествоLabel.Text = "Количество:";
            // 
            // MainPanel6
            // 
            this.MainPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel6.Controls.Add(this.buttonPrint1);
            this.MainPanel6.Controls.Add(id_productLabel);
            this.MainPanel6.Controls.Add(this.id_productTextBox);
            this.MainPanel6.Controls.Add(клиентLabel);
            this.MainPanel6.Controls.Add(this.клиентTextBox);
            this.MainPanel6.Controls.Add(наименование_продуктаLabel);
            this.MainPanel6.Controls.Add(this.наименование_продуктаTextBox);
            this.MainPanel6.Controls.Add(ценаLabel);
            this.MainPanel6.Controls.Add(this.ценаTextBox);
            this.MainPanel6.Controls.Add(количествоLabel);
            this.MainPanel6.Controls.Add(this.количествоTextBox);
            this.MainPanel6.Controls.Add(this.dataGridView1);
            this.MainPanel6.Controls.Add(this.buttonPrint);
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
            // id_productTextBox
            // 
            this.id_productTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource6, "id_product", true));
            this.id_productTextBox.Location = new System.Drawing.Point(834, 176);
            this.id_productTextBox.Name = "id_productTextBox";
            this.id_productTextBox.Size = new System.Drawing.Size(100, 22);
            this.id_productTextBox.TabIndex = 19;
            // 
            // ordersBindingSource6
            // 
            this.ordersBindingSource6.DataMember = "Orders";
            this.ordersBindingSource6.DataSource = this.schoolCanteenDataSet3;
            // 
            // schoolCanteenDataSet3
            // 
            this.schoolCanteenDataSet3.DataSetName = "SchoolCanteenDataSet3";
            this.schoolCanteenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентTextBox
            // 
            this.клиентTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource6, "Клиент", true));
            this.клиентTextBox.Location = new System.Drawing.Point(834, 204);
            this.клиентTextBox.Name = "клиентTextBox";
            this.клиентTextBox.Size = new System.Drawing.Size(100, 22);
            this.клиентTextBox.TabIndex = 21;
            // 
            // наименование_продуктаTextBox
            // 
            this.наименование_продуктаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource6, "Наименование продукта", true));
            this.наименование_продуктаTextBox.Location = new System.Drawing.Point(834, 232);
            this.наименование_продуктаTextBox.Name = "наименование_продуктаTextBox";
            this.наименование_продуктаTextBox.Size = new System.Drawing.Size(100, 22);
            this.наименование_продуктаTextBox.TabIndex = 23;
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource6, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(834, 260);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 22);
            this.ценаTextBox.TabIndex = 25;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource6, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(834, 288);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 22);
            this.количествоTextBox.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.наименованиеПродуктаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 281);
            this.dataGridView1.TabIndex = 18;
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "id_product";
            this.idproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            // 
            // наименованиеПродуктаDataGridViewTextBoxColumn
            // 
            this.наименованиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "Наименование продукта";
            this.наименованиеПродуктаDataGridViewTextBoxColumn.HeaderText = "Наименование продукта";
            this.наименованиеПродуктаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеПродуктаDataGridViewTextBoxColumn.Name = "наименованиеПродуктаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(12, 393);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(318, 53);
            this.buttonPrint.TabIndex = 17;
            this.buttonPrint.Text = "Поместить в Word";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            this.buttonPrint.MouseEnter += new System.EventHandler(this.buttonPrint_MouseEnter);
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
            // ordersBindingSource4
            // 
            this.ordersBindingSource4.DataMember = "Orders";
            this.ordersBindingSource4.DataSource = this.schoolCanteenDataSet3;
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
            // schoolCanteenDataSet2
            // 
            this.schoolCanteenDataSet2.DataSetName = "SchoolCanteenDataSet2";
            this.schoolCanteenDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.schoolCanteenDataSet2;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.schoolCanteenDataSet3;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "Orders";
            this.ordersBindingSource3.DataSource = this.schoolCanteenDataSet3;
            // 
            // ordersBindingSource5
            // 
            this.ordersBindingSource5.DataMember = "Orders";
            this.ordersBindingSource5.DataSource = this.schoolCanteenDataSet3;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter2;
            this.tableAdapterManager.UpdateOrder = Dyplomka.SchoolCanteenDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonPrint1
            // 
            this.buttonPrint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonPrint1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint1.FlatAppearance.BorderSize = 0;
            this.buttonPrint1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonPrint1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonPrint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint1.ForeColor = System.Drawing.Color.White;
            this.buttonPrint1.Location = new System.Drawing.Point(432, 393);
            this.buttonPrint1.Name = "buttonPrint1";
            this.buttonPrint1.Size = new System.Drawing.Size(163, 53);
            this.buttonPrint1.TabIndex = 28;
            this.buttonPrint1.Text = "Печать";
            this.buttonPrint1.UseVisualStyleBackColor = false;
            this.buttonPrint1.Click += new System.EventHandler(this.buttonPrint1_Click);
            this.buttonPrint1.MouseEnter += new System.EventHandler(this.buttonPrint1_MouseEnter);
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
            this.MainPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource5)).EndInit();
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
        private SchoolCanteenDataSet2 schoolCanteenDataSet2;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private SchoolCanteenDataSet2TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private SchoolCanteenDataSet3TableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private System.Windows.Forms.BindingSource ordersBindingSource4;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.BindingSource ordersBindingSource5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource6;
        private System.Windows.Forms.TextBox id_productTextBox;
        private System.Windows.Forms.TextBox клиентTextBox;
        private System.Windows.Forms.TextBox наименование_продуктаTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private SchoolCanteenDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonPrint1;
    }
}