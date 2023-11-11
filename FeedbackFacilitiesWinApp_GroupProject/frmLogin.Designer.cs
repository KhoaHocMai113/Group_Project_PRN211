namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmLogin
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
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            lbLogin = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(45, 105);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(45, 152);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(169, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(219, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(169, 149);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(219, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(45, 220);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(45, 270);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(94, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(169, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(294, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbLogin.Location = new System.Drawing.Point(169, 22);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new System.Drawing.Size(105, 48);
            lbLogin.TabIndex = 8;
            lbLogin.Text = "Login";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 322);
            Controls.Add(lbLogin);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbLogin;
    }
}