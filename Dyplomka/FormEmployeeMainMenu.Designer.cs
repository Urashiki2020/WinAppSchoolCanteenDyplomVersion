namespace Dyplomka
{
    partial class FormEmployeeMainMenu
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
            this.MainPanel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel2 = new System.Windows.Forms.Label();
            this.MainPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel2
            // 
            this.MainPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel2.Controls.Add(this.buttonExit);
            this.MainPanel2.Controls.Add(this.panel2);
            this.MainPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel2.Location = new System.Drawing.Point(0, 0);
            this.MainPanel2.Name = "MainPanel2";
            this.MainPanel2.Size = new System.Drawing.Size(800, 450);
            this.MainPanel2.TabIndex = 1;
            this.MainPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel2_MouseDown);
            this.MainPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel2_MouseMove);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(625, 385);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 53);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel2);
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
            // TopPanel2
            // 
            this.TopPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel2.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel2.ForeColor = System.Drawing.Color.White;
            this.TopPanel2.Location = new System.Drawing.Point(0, 0);
            this.TopPanel2.Name = "TopPanel2";
            this.TopPanel2.Size = new System.Drawing.Size(800, 100);
            this.TopPanel2.TabIndex = 0;
            this.TopPanel2.Text = "Главное меню сотрудника";
            this.TopPanel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel2_MouseDown);
            this.TopPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel2_MouseMove);
            // 
            // FormEmployeeMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeMainMenu";
            this.Text = "FormEmployeeMainMenu";
            this.MainPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel2;
    }
}