namespace Dyplomka
{
    partial class FormReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SchoolCanteenDataSet5 = new Dyplomka.SchoolCanteenDataSet5();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel10 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.MainPanel10 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordersTableAdapter = new Dyplomka.SchoolCanteenDataSet5TableAdapters.OrdersTableAdapter();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolCanteenDataSet5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.MainPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // SchoolCanteenDataSet5
            // 
            this.SchoolCanteenDataSet5.DataSetName = "SchoolCanteenDataSet5";
            this.SchoolCanteenDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 100);
            this.panel2.TabIndex = 0;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.SchoolCanteenDataSet5;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(906, 0);
            this.labelClosingTheForm.Name = "labelClosingTheForm";
            this.labelClosingTheForm.Size = new System.Drawing.Size(30, 36);
            this.labelClosingTheForm.TabIndex = 1;
            this.labelClosingTheForm.Text = "x";
            this.labelClosingTheForm.Click += new System.EventHandler(this.labelClosingTheForm_Click);
            this.labelClosingTheForm.MouseEnter += new System.EventHandler(this.labelClosingTheForm_MouseEnter);
            this.labelClosingTheForm.MouseLeave += new System.EventHandler(this.labelClosingTheForm_MouseLeave);
            // 
            // TopPanel10
            // 
            this.TopPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel10.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel10.ForeColor = System.Drawing.Color.White;
            this.TopPanel10.Location = new System.Drawing.Point(0, 0);
            this.TopPanel10.Name = "TopPanel10";
            this.TopPanel10.Size = new System.Drawing.Size(936, 100);
            this.TopPanel10.TabIndex = 0;
            this.TopPanel10.Text = "Отчет работы столовой";
            this.TopPanel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel10_MouseDown);
            this.TopPanel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel10_MouseMove);
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
            this.buttonBack.Location = new System.Drawing.Point(761, 597);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(163, 53);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            this.buttonBack.MouseEnter += new System.EventHandler(this.buttonBack_MouseEnter);
            // 
            // MainPanel10
            // 
            this.MainPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel10.Controls.Add(this.reportViewer1);
            this.MainPanel10.Controls.Add(this.buttonBack);
            this.MainPanel10.Controls.Add(this.panel2);
            this.MainPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel10.Location = new System.Drawing.Point(0, 0);
            this.MainPanel10.Name = "MainPanel10";
            this.MainPanel10.Size = new System.Drawing.Size(936, 662);
            this.MainPanel10.TabIndex = 3;
            this.MainPanel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel10_MouseDown);
            this.MainPanel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel10_MouseMove);
            // 
            // reportViewer1
            // 
            reportDataSource10.Name = "DataSetCanteenOperation";
            reportDataSource10.Value = this.ordersBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dyplomka.ReportCanteenOperationReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(914, 485);
            this.reportViewer1.TabIndex = 6;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.SchoolCanteenDataSet5;
            // 
            // ordersBindingSource3
            // 
            this.ordersBindingSource3.DataMember = "Orders";
            this.ordersBindingSource3.DataSource = this.SchoolCanteenDataSet5;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 662);
            this.Controls.Add(this.MainPanel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolCanteenDataSet5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.MainPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private SchoolCanteenDataSet5 SchoolCanteenDataSet5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel10;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel MainPanel10;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private SchoolCanteenDataSet5TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.BindingSource ordersBindingSource3;
    }
}