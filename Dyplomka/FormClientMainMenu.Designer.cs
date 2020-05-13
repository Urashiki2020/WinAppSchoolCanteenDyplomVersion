namespace Dyplomka
{
    partial class FormClientMainMenu
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
            this.MainPanel3 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel3 = new System.Windows.Forms.Label();
            this.MainPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel3
            // 
            this.MainPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel3.Controls.Add(this.buttonExit);
            this.MainPanel3.Controls.Add(this.panel2);
            this.MainPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel3.Location = new System.Drawing.Point(0, 0);
            this.MainPanel3.Name = "MainPanel3";
            this.MainPanel3.Size = new System.Drawing.Size(800, 450);
            this.MainPanel3.TabIndex = 2;
            this.MainPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel3_MouseDown);
            this.MainPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel3_MouseMove);
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
            this.panel2.Controls.Add(this.TopPanel3);
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
            // TopPanel3
            // 
            this.TopPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel3.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel3.ForeColor = System.Drawing.Color.White;
            this.TopPanel3.Location = new System.Drawing.Point(0, 0);
            this.TopPanel3.Name = "TopPanel3";
            this.TopPanel3.Size = new System.Drawing.Size(800, 100);
            this.TopPanel3.TabIndex = 0;
            this.TopPanel3.Text = "Главное меню клиента";
            this.TopPanel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel3_MouseDown);
            this.TopPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel3_MouseMove);
            // 
            // FormClientMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientMainMenu";
            this.Text = "FormClientMainMenu";
            this.MainPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel3;
    }
}