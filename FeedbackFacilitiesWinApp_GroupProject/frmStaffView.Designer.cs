namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmStaffView
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
            lbContent = new System.Windows.Forms.Label();
            dgvFeedbackList = new System.Windows.Forms.DataGridView();
            lbCompleted = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            rtbDescription = new System.Windows.Forms.RichTextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtDeviceName = new System.Windows.Forms.TextBox();
            txtRoomName = new System.Windows.Forms.TextBox();
            lbDescription = new System.Windows.Forms.Label();
            lbQuantity = new System.Windows.Forms.Label();
            lbDeviceName = new System.Windows.Forms.Label();
            lbRoomName = new System.Windows.Forms.Label();
            lbFloorName = new System.Windows.Forms.Label();
            txtFloorName = new System.Windows.Forms.TextBox();
            txtSenderId = new System.Windows.Forms.TextBox();
            lbDay = new System.Windows.Forms.Label();
            txtDay = new System.Windows.Forms.TextBox();
            txtDeviceId = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            cboStatus = new System.Windows.Forms.ComboBox();
            lbAssigned = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).BeginInit();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(488, 44);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(136, 48);
            lbContent.TabIndex = 0;
            lbContent.Text = "Mission";
            // 
            // dgvFeedbackList
            // 
            dgvFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedbackList.Location = new System.Drawing.Point(88, 125);
            dgvFeedbackList.Name = "dgvFeedbackList";
            dgvFeedbackList.RowHeadersWidth = 51;
            dgvFeedbackList.RowTemplate.Height = 29;
            dgvFeedbackList.Size = new System.Drawing.Size(975, 188);
            dgvFeedbackList.TabIndex = 1;
            dgvFeedbackList.CellDoubleClick += dgvFeedbackList_CellDoubleClick;
            // 
            // lbCompleted
            // 
            lbCompleted.AutoSize = true;
            lbCompleted.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbCompleted.Location = new System.Drawing.Point(85, 519);
            lbCompleted.Name = "lbCompleted";
            lbCompleted.Size = new System.Drawing.Size(98, 23);
            lbCompleted.TabIndex = 2;
            lbCompleted.Text = "Completed:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(500, 517);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(969, 517);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(969, 552);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            rtbDescription.Location = new System.Drawing.Point(828, 362);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new System.Drawing.Size(235, 76);
            rtbDescription.TabIndex = 40;
            rtbDescription.Text = "";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(500, 363);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(166, 27);
            txtQuantity.TabIndex = 39;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new System.Drawing.Point(192, 459);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(166, 27);
            txtDeviceName.TabIndex = 38;
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new System.Drawing.Point(192, 411);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new System.Drawing.Size(166, 27);
            txtRoomName.TabIndex = 37;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(706, 365);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(88, 20);
            lbDescription.TabIndex = 36;
            lbDescription.Text = "Description:";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(393, 366);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(68, 20);
            lbQuantity.TabIndex = 35;
            lbQuantity.Text = "Quantity:";
            // 
            // lbDeviceName
            // 
            lbDeviceName.AutoSize = true;
            lbDeviceName.Location = new System.Drawing.Point(85, 462);
            lbDeviceName.Name = "lbDeviceName";
            lbDeviceName.Size = new System.Drawing.Size(101, 20);
            lbDeviceName.TabIndex = 34;
            lbDeviceName.Text = "Device Name:";
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Location = new System.Drawing.Point(86, 415);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new System.Drawing.Size(76, 20);
            lbRoomName.TabIndex = 33;
            lbRoomName.Text = "Room No:";
            // 
            // lbFloorName
            // 
            lbFloorName.AutoSize = true;
            lbFloorName.Location = new System.Drawing.Point(86, 366);
            lbFloorName.Name = "lbFloorName";
            lbFloorName.Size = new System.Drawing.Size(91, 20);
            lbFloorName.TabIndex = 32;
            lbFloorName.Text = "Floor name: ";
            // 
            // txtFloorName
            // 
            txtFloorName.Location = new System.Drawing.Point(190, 363);
            txtFloorName.Name = "txtFloorName";
            txtFloorName.Size = new System.Drawing.Size(166, 27);
            txtFloorName.TabIndex = 41;
            // 
            // txtSenderId
            // 
            txtSenderId.Location = new System.Drawing.Point(0, 594);
            txtSenderId.Name = "txtSenderId";
            txtSenderId.Size = new System.Drawing.Size(23, 27);
            txtSenderId.TabIndex = 43;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Location = new System.Drawing.Point(393, 414);
            lbDay.Name = "lbDay";
            lbDay.Size = new System.Drawing.Size(35, 20);
            lbDay.TabIndex = 44;
            lbDay.Text = "Day";
            // 
            // txtDay
            // 
            txtDay.Location = new System.Drawing.Point(500, 412);
            txtDay.Name = "txtDay";
            txtDay.Size = new System.Drawing.Size(166, 27);
            txtDay.TabIndex = 45;
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new System.Drawing.Point(29, 594);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new System.Drawing.Size(21, 27);
            txtDeviceId.TabIndex = 46;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(61, 594);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(18, 27);
            txtId.TabIndex = 47;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "YES", "NO" });
            cboStatus.Location = new System.Drawing.Point(192, 518);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new System.Drawing.Size(164, 28);
            cboStatus.TabIndex = 48;
            // 
            // lbAssigned
            // 
            lbAssigned.AutoSize = true;
            lbAssigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbAssigned.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAssigned.Location = new System.Drawing.Point(88, 95);
            lbAssigned.Name = "lbAssigned";
            lbAssigned.Size = new System.Drawing.Size(2, 27);
            lbAssigned.TabIndex = 49;
            // 
            // frmStaffView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 595);
            Controls.Add(lbAssigned);
            Controls.Add(cboStatus);
            Controls.Add(txtId);
            Controls.Add(txtDeviceId);
            Controls.Add(txtDay);
            Controls.Add(lbDay);
            Controls.Add(txtSenderId);
            Controls.Add(txtFloorName);
            Controls.Add(rtbDescription);
            Controls.Add(txtQuantity);
            Controls.Add(txtDeviceName);
            Controls.Add(txtRoomName);
            Controls.Add(lbDescription);
            Controls.Add(lbQuantity);
            Controls.Add(lbDeviceName);
            Controls.Add(lbRoomName);
            Controls.Add(lbFloorName);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdate);
            Controls.Add(lbCompleted);
            Controls.Add(dgvFeedbackList);
            Controls.Add(lbContent);
            Name = "frmStaffView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaffView";
            Load += frmStaffView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.DataGridView dgvFeedbackList;
        private System.Windows.Forms.Label lbCompleted;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbFloorName;
        private System.Windows.Forms.TextBox txtFloorName;
        private System.Windows.Forms.TextBox txtSenderId;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lbAssigned;
    }
}