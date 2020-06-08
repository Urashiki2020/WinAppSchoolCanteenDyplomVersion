namespace Dyplomka
{
    partial class FormDiningRoomMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiningRoomMenu));
            this.MainPanel7 = new System.Windows.Forms.Panel();
            this.buttonCompleteTheOrder = new System.Windows.Forms.Button();
            this.buttonTakeAnOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеБлюдаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diningRoomMenuBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel7 = new System.Windows.Forms.Label();
            this.dining_room_menuTableAdapter1 = new Dyplomka.SchoolCanteenDataSet3TableAdapters.Dining_room_menuTableAdapter();
            this.MainPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel7
            // 
            this.MainPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel7.Controls.Add(this.buttonCompleteTheOrder);
            this.MainPanel7.Controls.Add(this.buttonTakeAnOrder);
            this.MainPanel7.Controls.Add(this.dataGridView1);
            this.MainPanel7.Controls.Add(this.buttonBack);
            this.MainPanel7.Controls.Add(this.panel2);
            this.MainPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel7.Location = new System.Drawing.Point(0, 0);
            this.MainPanel7.Name = "MainPanel7";
            this.MainPanel7.Size = new System.Drawing.Size(805, 458);
            this.MainPanel7.TabIndex = 3;
            this.MainPanel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel7_MouseDown);
            this.MainPanel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel7_MouseMove);
            // 
            // buttonCompleteTheOrder
            // 
            this.buttonCompleteTheOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonCompleteTheOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompleteTheOrder.FlatAppearance.BorderSize = 0;
            this.buttonCompleteTheOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonCompleteTheOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonCompleteTheOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompleteTheOrder.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCompleteTheOrder.ForeColor = System.Drawing.Color.White;
            this.buttonCompleteTheOrder.Location = new System.Drawing.Point(338, 385);
            this.buttonCompleteTheOrder.Name = "buttonCompleteTheOrder";
            this.buttonCompleteTheOrder.Size = new System.Drawing.Size(257, 53);
            this.buttonCompleteTheOrder.TabIndex = 8;
            this.buttonCompleteTheOrder.Text = "Удалить продукт";
            this.buttonCompleteTheOrder.UseVisualStyleBackColor = false;
            this.buttonCompleteTheOrder.Click += new System.EventHandler(this.buttonCompleteTheOrder_Click);
            this.buttonCompleteTheOrder.MouseEnter += new System.EventHandler(this.buttonCompleteTheOrder_MouseEnter);
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
            this.buttonTakeAnOrder.Location = new System.Drawing.Point(12, 385);
            this.buttonTakeAnOrder.Name = "buttonTakeAnOrder";
            this.buttonTakeAnOrder.Size = new System.Drawing.Size(257, 53);
            this.buttonTakeAnOrder.TabIndex = 7;
            this.buttonTakeAnOrder.Text = "Добавить продукт";
            this.buttonTakeAnOrder.UseVisualStyleBackColor = false;
            this.buttonTakeAnOrder.Click += new System.EventHandler(this.buttonTakeAnOrder_Click);
            this.buttonTakeAnOrder.MouseEnter += new System.EventHandler(this.buttonTakeAnOrder_MouseEnter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.наименованиеБлюдаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diningRoomMenuBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 273);
            this.dataGridView1.TabIndex = 6;
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
            // diningRoomMenuBindingSource3
            // 
            this.diningRoomMenuBindingSource3.DataMember = "Dining room menu";
            this.diningRoomMenuBindingSource3.DataSource = this.schoolCanteenDataSet3;
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
            this.panel2.Controls.Add(this.TopPanel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(775, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel7
            // 
            this.TopPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel7.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel7.ForeColor = System.Drawing.Color.White;
            this.TopPanel7.Location = new System.Drawing.Point(0, 0);
            this.TopPanel7.Name = "TopPanel7";
            this.TopPanel7.Size = new System.Drawing.Size(805, 100);
            this.TopPanel7.TabIndex = 0;
            this.TopPanel7.Text = "Меню";
            this.TopPanel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel7_MouseDown);
            this.TopPanel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel7_MouseMove);
            // 
            // dining_room_menuTableAdapter1
            // 
            this.dining_room_menuTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDiningRoomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 458);
            this.Controls.Add(this.MainPanel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiningRoomMenu";
            this.Text = "FormDiningRoomMenu";
            this.Load += new System.EventHandler(this.FormDiningRoomMenu_Load);
            this.MainPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diningRoomMenuBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolCanteenDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel7;
        private System.Windows.Forms.Button buttonCompleteTheOrder;
        private System.Windows.Forms.Button buttonTakeAnOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеБлюдаDataGridViewTextBoxColumn;
        private SchoolCanteenDataSet3 schoolCanteenDataSet3;
        private System.Windows.Forms.BindingSource diningRoomMenuBindingSource3;
        private SchoolCanteenDataSet3TableAdapters.Dining_room_menuTableAdapter dining_room_menuTableAdapter1;
    }
}