namespace Dyplomka
{
    partial class FormTheReportOfOrdersOfTheEmployees
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTheReportOfOrdersOfTheEmployees));
            this.Employee_s_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SchoolCanteenDataSet3 = new Dyplomka.SchoolCanteenDataSet3();
            this.MainPanel10 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel10 = new System.Windows.Forms.Label();
            this.Employee_s_orderTableAdapter = new Dyplomka.SchoolCanteenDataSet3TableAdapters.Employee_s_orderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_s_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolCanteenDataSet3)).BeginInit();
            this.MainPanel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_s_orderBindingSource
            // 
            this.Employee_s_orderBindingSource.DataMember = "Employee\'s order";
            this.Employee_s_orderBindingSource.DataSource = this.SchoolCanteenDataSet3;
            // 
            // SchoolCanteenDataSet3
            // 
            this.SchoolCanteenDataSet3.DataSetName = "SchoolCanteenDataSet3";
            this.SchoolCanteenDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.MainPanel10.Size = new System.Drawing.Size(935, 661);
            this.MainPanel10.TabIndex = 4;
            this.MainPanel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel10_MouseDown);
            this.MainPanel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel10_MouseMove);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Employee_s_orderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Dyplomka.TheReportOfOrdersOfTheEmployees.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(911, 484);
            this.reportViewer1.TabIndex = 6;
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
            this.buttonBack.Location = new System.Drawing.Point(760, 596);
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
            this.panel2.Controls.Add(this.TopPanel10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelClosingTheForm
            // 
            this.labelClosingTheForm.AutoSize = true;
            this.labelClosingTheForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosingTheForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClosingTheForm.ForeColor = System.Drawing.Color.White;
            this.labelClosingTheForm.Location = new System.Drawing.Point(905, 0);
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
            this.TopPanel10.Size = new System.Drawing.Size(935, 100);
            this.TopPanel10.TabIndex = 0;
            this.TopPanel10.Text = "Отчет заказов сотрудников";
            this.TopPanel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel10_MouseDown);
            this.TopPanel10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel10_MouseMove);
            // 
            // Employee_s_orderTableAdapter
            // 
            this.Employee_s_orderTableAdapter.ClearBeforeFill = true;
            // 
            // FormTheReportOfOrdersOfTheEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 661);
            this.Controls.Add(this.MainPanel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTheReportOfOrdersOfTheEmployees";
            this.Text = "FormTheReportOfOrdersOfTheEmployees";
            this.Load += new System.EventHandler(this.FormTheReportOfOrdersOfTheEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_s_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolCanteenDataSet3)).EndInit();
            this.MainPanel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel10;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel10;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Employee_s_orderBindingSource;
        private SchoolCanteenDataSet3 SchoolCanteenDataSet3;
        private SchoolCanteenDataSet3TableAdapters.Employee_s_orderTableAdapter Employee_s_orderTableAdapter;
    }
}