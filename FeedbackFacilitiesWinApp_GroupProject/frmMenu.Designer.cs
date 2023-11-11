namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmMenu
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
            btnMemberMenegement = new System.Windows.Forms.Button();
            lbContent = new System.Windows.Forms.Label();
            btnStaffManagement = new System.Windows.Forms.Button();
            btnDeviceRoomManagement = new System.Windows.Forms.Button();
            btnDevice = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnFeedbackManagement = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnMemberMenegement
            // 
            btnMemberMenegement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnMemberMenegement.Location = new System.Drawing.Point(63, 142);
            btnMemberMenegement.Name = "btnMemberMenegement";
            btnMemberMenegement.Size = new System.Drawing.Size(283, 65);
            btnMemberMenegement.TabIndex = 0;
            btnMemberMenegement.Text = "MemberManagement";
            btnMemberMenegement.UseVisualStyleBackColor = true;
            btnMemberMenegement.Click += btnMemberMenegement_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(305, 47);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(109, 48);
            lbContent.TabIndex = 4;
            lbContent.Text = "Menu";
            // 
            // btnStaffManagement
            // 
            btnStaffManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStaffManagement.Location = new System.Drawing.Point(374, 142);
            btnStaffManagement.Name = "btnStaffManagement";
            btnStaffManagement.Size = new System.Drawing.Size(283, 65);
            btnStaffManagement.TabIndex = 5;
            btnStaffManagement.Text = "StaffManagement";
            btnStaffManagement.UseVisualStyleBackColor = true;
            btnStaffManagement.Click += btnStaffManagement_Click;
            // 
            // btnDeviceRoomManagement
            // 
            btnDeviceRoomManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDeviceRoomManagement.Location = new System.Drawing.Point(374, 232);
            btnDeviceRoomManagement.Name = "btnDeviceRoomManagement";
            btnDeviceRoomManagement.Size = new System.Drawing.Size(283, 65);
            btnDeviceRoomManagement.TabIndex = 6;
            btnDeviceRoomManagement.Text = "DeviceRoomManagement";
            btnDeviceRoomManagement.UseVisualStyleBackColor = true;
            btnDeviceRoomManagement.Click += btnDeviceRoomManagement_Click;
            // 
            // btnDevice
            // 
            btnDevice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDevice.Location = new System.Drawing.Point(63, 232);
            btnDevice.Name = "btnDevice";
            btnDevice.Size = new System.Drawing.Size(283, 65);
            btnDevice.TabIndex = 7;
            btnDevice.Text = "DeviceManagement";
            btnDevice.UseVisualStyleBackColor = true;
            btnDevice.Click += btnDevice_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(252, 408);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(374, 408);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFeedbackManagement
            // 
            btnFeedbackManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFeedbackManagement.Location = new System.Drawing.Point(63, 321);
            btnFeedbackManagement.Name = "btnFeedbackManagement";
            btnFeedbackManagement.Size = new System.Drawing.Size(283, 65);
            btnFeedbackManagement.TabIndex = 10;
            btnFeedbackManagement.Text = "Feedback Management";
            btnFeedbackManagement.UseVisualStyleBackColor = true;
            btnFeedbackManagement.Click += btnFeedbackManagement_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(736, 486);
            Controls.Add(btnFeedbackManagement);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnDevice);
            Controls.Add(btnDeviceRoomManagement);
            Controls.Add(btnStaffManagement);
            Controls.Add(lbContent);
            Controls.Add(btnMemberMenegement);
            Name = "frmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMemberMenegement;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnDeviceRoomManagement;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFeedbackManagement;
    }
}