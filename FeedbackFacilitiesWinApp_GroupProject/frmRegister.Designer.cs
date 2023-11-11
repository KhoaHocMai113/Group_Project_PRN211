namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmRegister
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
            lbUsername = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnRegister = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            lbContent = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new System.Drawing.Point(92, 116);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new System.Drawing.Size(78, 20);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(92, 168);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(104, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email address:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(92, 219);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(283, 113);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(172, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(283, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(172, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(283, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(172, 27);
            txtPassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(65, 285);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(94, 29);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(223, 285);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(390, 285);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(65, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(94, 29);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(201, 36);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(143, 48);
            lbContent.TabIndex = 12;
            lbContent.Text = "Register";
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(574, 389);
            Controls.Add(lbContent);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Name = "frmRegister";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbContent;
    }
}