namespace Dyplomka
{
    partial class FormMakeAnOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMakeAnOrder));
            this.diningRoomMenuBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.diningRoomMenuBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel8 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonTakeAnOrder = new System.Windows.Forms.Button();
            this.comboBoxNameOfProduct = new System.Windows.Forms.ComboBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDiningRoomMenu = new System.Windows.Forms.Label();
            this.labelOrderedProduct = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.MainPanel8 = new System.Windows.Forms.Panel();
            this.dining_room_menuTableAdapter1 = new Dyplomka.SchoolCanteenDataSet3TableAdapters.Dining_room_menuTableAdapter();
            this.usersTableAdapter1 = new Dyplomka.SchoolCanteenDataSet2TableAdapters.UsersTableAdapter();
            this.usersTableAdapter2 = new Dyplomka.SchoolCanteenDataSet3TableAdapters.UsersTableAdapter();
            this.usersTableAdapter = new Dyplomka.SchoolCanteenDataSetTableAdapters.UsersTableAdapter();
            this.dining_room_menuTableAdapter = new Dyplomka.SchoolCanteenDataSet1TableAdapters.Dining_room_menuTableAdapter();
            this.schoolCanteenDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource8)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MainPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diningRoomMenuBindingSource6
            // 
            this.diningRoomMenuBindingSource6.DataMember = "Dining room menu";
            this.diningRoomMenuBindingSource6.DataSource = this.schoolCanteenDataSet3;
            // 
            // schoolCanteenDataSet3
            // 
            this.schoolCanteenDataSet3.DataSetName = "SchoolCanteenDataSet3";
            this.schoolCanteenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diningRoomMenuBindingSource7
            // 
            this.diningRoomMenuBindingSource7.DataMember = "Dining room menu";
            this.diningRoomMenuBindingSource7.DataSource = this.schoolCanteenDataSet3;
            // 
            // usersBindingSource8
            // 
            this.usersBindingSource8.DataMember = "Users";
            this.usersBindingSource8.DataSource = this.schoolCanteenDataSet3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(1098, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel8
            // 
            this.TopPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel8.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel8.ForeColor = System.Drawing.Color.White;
            this.TopPanel8.Location = new System.Drawing.Point(0, 0);
            this.TopPanel8.Name = "TopPanel8";
            this.TopPanel8.Size = new System.Drawing.Size(1128, 100);
            this.TopPanel8.TabIndex = 0;
            this.TopPanel8.Text = "Сделать заказ";
            this.TopPanel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel8_MouseDown);
            this.TopPanel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel8_MouseMove);
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
            this.buttonBack.Location = new System.Drawing.Point(953, 439);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(163, 53);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            // 
            // buttonTakeAnOrder
            // 
            this.buttonTakeAnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonTakeAnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTakeAnOrder.FlatAppearance.BorderSize = 0;
            this.buttonTakeAnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonTakeAnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonTakeAnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeAnOrder.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTakeAnOrder.ForeColor = System.Drawing.Color.White;
            this.buttonTakeAnOrder.Location = new System.Drawing.Point(175, 356);
            this.buttonTakeAnOrder.Name = "buttonTakeAnOrder";
            this.buttonTakeAnOrder.Size = new System.Drawing.Size(230, 53);
            this.buttonTakeAnOrder.TabIndex = 7;
            this.buttonTakeAnOrder.Text = "В корзину";
            this.buttonTakeAnOrder.UseVisualStyleBackColor = false;
            this.buttonTakeAnOrder.Click += new System.EventHandler(this.buttonTakeAnOrder_Click);
            this.buttonTakeAnOrder.MouseEnter += new System.EventHandler(this.buttonTakeAnOrder_MouseEnter);
            // 
            // comboBoxNameOfProduct
            // 
            this.comboBoxNameOfProduct.DataSource = this.diningRoomMenuBindingSource7;
            this.comboBoxNameOfProduct.DisplayMember = "Наименование блюда";
            this.comboBoxNameOfProduct.FormattingEnabled = true;
            this.comboBoxNameOfProduct.Location = new System.Drawing.Point(389, 238);
            this.comboBoxNameOfProduct.Name = "comboBoxNameOfProduct";
            this.comboBoxNameOfProduct.Size = new System.Drawing.Size(247, 24);
            this.comboBoxNameOfProduct.TabIndex = 10;
            this.comboBoxNameOfProduct.ValueMember = "id_product";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(389, 277);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(247, 22);
            this.textBoxQuantity.TabIndex = 11;
            this.textBoxQuantity.Enter += new System.EventHandler(this.textBoxQuantity_Enter);
            this.textBoxQuantity.Leave += new System.EventHandler(this.textBoxQuantity_Leave);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.White;
            this.labelClient.Location = new System.Drawing.Point(1, 201);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(298, 25);
            this.labelClient.TabIndex = 23;
            this.labelClient.Text = "Выберите свой логин клиента:";
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.ForeColor = System.Drawing.Color.White;
            this.labelProduct.Location = new System.Drawing.Point(110, 237);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(189, 25);
            this.labelProduct.TabIndex = 24;
            this.labelProduct.Text = "Выберите продукт:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.White;
            this.labelQuantity.Location = new System.Drawing.Point(173, 276);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(126, 25);
            this.labelQuantity.TabIndex = 25;
            this.labelQuantity.Text = "Количество:";
            // 
            // labelDiningRoomMenu
            // 
            this.labelDiningRoomMenu.AutoSize = true;
            this.labelDiningRoomMenu.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiningRoomMenu.ForeColor = System.Drawing.Color.White;
            this.labelDiningRoomMenu.Location = new System.Drawing.Point(786, 103);
            this.labelDiningRoomMenu.Name = "labelDiningRoomMenu";
            this.labelDiningRoomMenu.Size = new System.Drawing.Size(237, 37);
            this.labelDiningRoomMenu.TabIndex = 26;
            this.labelDiningRoomMenu.Text = "Меню столовой";
            // 
            // labelOrderedProduct
            // 
            this.labelOrderedProduct.AutoSize = true;
            this.labelOrderedProduct.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderedProduct.ForeColor = System.Drawing.Color.White;
            this.labelOrderedProduct.Location = new System.Drawing.Point(158, 143);
            this.labelOrderedProduct.Name = "labelOrderedProduct";
            this.labelOrderedProduct.Size = new System.Drawing.Size(269, 37);
            this.labelOrderedProduct.TabIndex = 27;
            this.labelOrderedProduct.Text = "Заказать продукт";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.наименованиеБлюдаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diningRoomMenuBindingSource6;
            this.dataGridView1.Location = new System.Drawing.Point(687, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 290);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "id_product";
            this.idproductDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеБлюдаDataGridViewTextBoxColumn
            // 
            this.наименованиеБлюдаDataGridViewTextBoxColumn.DataPropertyName = "Наименование блюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.HeaderText = "Наименование блюда";
            this.наименованиеБлюдаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеБлюдаDataGridViewTextBoxColumn.Name = "наименованиеБлюдаDataGridViewTextBoxColumn";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.usersBindingSource8;
            this.comboBoxClient.DisplayMember = "login";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(389, 202);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(247, 24);
            this.comboBoxClient.TabIndex = 29;
            this.comboBoxClient.ValueMember = "id_user";
            // 
            // MainPanel8
            // 
            this.MainPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel8.Controls.Add(this.comboBoxClient);
            this.MainPanel8.Controls.Add(this.dataGridView1);
            this.MainPanel8.Controls.Add(this.labelOrderedProduct);
            this.MainPanel8.Controls.Add(this.labelDiningRoomMenu);
            this.MainPanel8.Controls.Add(this.labelQuantity);
            this.MainPanel8.Controls.Add(this.labelProduct);
            this.MainPanel8.Controls.Add(this.labelClient);
            this.MainPanel8.Controls.Add(this.textBoxQuantity);
            this.MainPanel8.Controls.Add(this.comboBoxNameOfProduct);
            this.MainPanel8.Controls.Add(this.buttonTakeAnOrder);
            this.MainPanel8.Controls.Add(this.buttonBack);
            this.MainPanel8.Controls.Add(this.panel2);
            this.MainPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel8.Location = new System.Drawing.Point(0, 0);
            this.MainPanel8.Name = "MainPanel8";
            this.MainPanel8.Size = new System.Drawing.Size(1128, 504);
            this.MainPanel8.TabIndex = 3;
            this.MainPanel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel8_MouseDown);
            this.MainPanel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel8_MouseMove);
            // 
            // dining_room_menuTableAdapter1
            // 
            this.dining_room_menuTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dining_room_menuTableAdapter
            // 
            this.dining_room_menuTableAdapter.ClearBeforeFill = true;
            // 
            // FormMakeAnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 504);
            this.Controls.Add(this.MainPanel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMakeAnOrder";
            this.Text = "FormMakeAnOrder";
            this.Load += new System.EventHandler(this.FormMakeAnOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource8)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MainPanel8.ResumeLayout(false);
            this.MainPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource diningRoomMenuBindingSource6;
        private System.Windows.Forms.BindingSource diningRoomMenuBindingSource7;
        private System.Windows.Forms.BindingSource usersBindingSource8;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel8;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonTakeAnOrder;
        private System.Windows.Forms.ComboBox comboBoxNameOfProduct;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDiningRoomMenu;
        private System.Windows.Forms.Label labelOrderedProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеБлюдаDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.Panel MainPanel8;
        private SchoolCanteenDataSet3TableAdapters.Dining_room_menuTableAdapter dining_room_menuTableAdapter1;
        private SchoolCanteenDataSet2TableAdapters.UsersTableAdapter usersTableAdapter1;
        private SchoolCanteenDataSet3TableAdapters.UsersTableAdapter usersTableAdapter2;
        private SchoolCanteenDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private SchoolCanteenDataSet1TableAdapters.Dining_room_menuTableAdapter dining_room_menuTableAdapter;
        private System.Windows.Forms.BindingSource schoolCanteenDataSet3BindingSource;
    }
}