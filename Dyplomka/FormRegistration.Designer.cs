namespace Dyplomka
{
    partial class FormRegistration
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
            this.MainPanel1 = new System.Windows.Forms.Panel();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.textBoxRoleField = new System.Windows.Forms.TextBox();
            this.textBoxSurnameField = new System.Windows.Forms.TextBox();
            this.textBoxNameField = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClosingTheForm = new System.Windows.Forms.Label();
            this.TopPanel1 = new System.Windows.Forms.Label();
            this.MainPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel1
            // 
            this.MainPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(10)))), ((int)(((byte)(20)))));
            this.MainPanel1.Controls.Add(this.textBoxIdUser);
            this.MainPanel1.Controls.Add(this.textBoxRoleField);
            this.MainPanel1.Controls.Add(this.textBoxSurnameField);
            this.MainPanel1.Controls.Add(this.textBoxNameField);
            this.MainPanel1.Controls.Add(this.buttonRegister);
            this.MainPanel1.Controls.Add(this.textBoxPassword);
            this.MainPanel1.Controls.Add(this.pictureBox1);
            this.MainPanel1.Controls.Add(this.textBoxLogin);
            this.MainPanel1.Controls.Add(this.pictureBoxUser);
            this.MainPanel1.Controls.Add(this.panel2);
            this.MainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel1.Location = new System.Drawing.Point(0, 0);
            this.MainPanel1.Name = "MainPanel1";
            this.MainPanel1.Size = new System.Drawing.Size(800, 450);
            this.MainPanel1.TabIndex = 1;
            this.MainPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel1_MouseDown);
            this.MainPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel1_MouseMove);
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIdUser.Location = new System.Drawing.Point(6, 104);
            this.textBoxIdUser.Multiline = true;
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(107, 64);
            this.textBoxIdUser.TabIndex = 10;
            this.textBoxIdUser.Enter += new System.EventHandler(this.textBoxIdUser_Enter);
            this.textBoxIdUser.Leave += new System.EventHandler(this.textBoxIdUser_Leave);
            // 
            // textBoxRoleField
            // 
            this.textBoxRoleField.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRoleField.Location = new System.Drawing.Point(119, 244);
            this.textBoxRoleField.Multiline = true;
            this.textBoxRoleField.Name = "textBoxRoleField";
            this.textBoxRoleField.Size = new System.Drawing.Size(401, 64);
            this.textBoxRoleField.TabIndex = 9;
            this.textBoxRoleField.Enter += new System.EventHandler(this.textBoxRoleField_Enter);
            this.textBoxRoleField.Leave += new System.EventHandler(this.textBoxRoleField_Leave);
            // 
            // textBoxSurnameField
            // 
            this.textBoxSurnameField.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurnameField.Location = new System.Drawing.Point(119, 174);
            this.textBoxSurnameField.Multiline = true;
            this.textBoxSurnameField.Name = "textBoxSurnameField";
            this.textBoxSurnameField.Size = new System.Drawing.Size(401, 64);
            this.textBoxSurnameField.TabIndex = 8;
            this.textBoxSurnameField.Enter += new System.EventHandler(this.textBoxSurnameField_Enter);
            this.textBoxSurnameField.Leave += new System.EventHandler(this.textBoxSurnameField_Leave);
            // 
            // textBoxNameField
            // 
            this.textBoxNameField.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameField.Location = new System.Drawing.Point(119, 104);
            this.textBoxNameField.Multiline = true;
            this.textBoxNameField.Name = "textBoxNameField";
            this.textBoxNameField.Size = new System.Drawing.Size(401, 64);
            this.textBoxNameField.TabIndex = 6;
            this.textBoxNameField.Enter += new System.EventHandler(this.textBoxNameField_Enter);
            this.textBoxNameField.Leave += new System.EventHandler(this.textBoxNameField_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(43)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(49)))), ((int)(((byte)(18)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(79)))), ((int)(((byte)(29)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(526, 387);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(267, 53);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            this.buttonRegister.MouseEnter += new System.EventHandler(this.buttonRegister_MouseEnter);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(119, 383);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(401, 57);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dyplomka.Properties.Resources.Password;
            this.pictureBox1.Location = new System.Drawing.Point(48, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(119, 313);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(401, 64);
            this.textBoxLogin.TabIndex = 2;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.Image = global::Dyplomka.Properties.Resources.User;
            this.pictureBoxUser.Location = new System.Drawing.Point(48, 313);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUser.TabIndex = 1;
            this.pictureBoxUser.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.labelClosingTheForm);
            this.panel2.Controls.Add(this.TopPanel1);
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
            // TopPanel1
            // 
            this.TopPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel1.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopPanel1.ForeColor = System.Drawing.Color.White;
            this.TopPanel1.Location = new System.Drawing.Point(0, 0);
            this.TopPanel1.Name = "TopPanel1";
            this.TopPanel1.Size = new System.Drawing.Size(800, 100);
            this.TopPanel1.TabIndex = 0;
            this.TopPanel1.Text = "Регистрация";
            this.TopPanel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel1_MouseDown);
            this.TopPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel1_MouseMove);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.MainPanel1.ResumeLayout(false);
            this.MainPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClosingTheForm;
        private System.Windows.Forms.Label TopPanel1;
        private System.Windows.Forms.TextBox textBoxNameField;
        private System.Windows.Forms.TextBox textBoxSurnameField;
        private System.Windows.Forms.TextBox textBoxRoleField;
        private System.Windows.Forms.TextBox textBoxIdUser;
    }
}