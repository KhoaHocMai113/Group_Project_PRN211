namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmFeedbackHistory
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
            txtDay = new System.Windows.Forms.TextBox();
            lbDay = new System.Windows.Forms.Label();
            txtFloorName = new System.Windows.Forms.TextBox();
            rtbDescription = new System.Windows.Forms.RichTextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtDeviceName = new System.Windows.Forms.TextBox();
            txtRoomName = new System.Windows.Forms.TextBox();
            lbDescription = new System.Windows.Forms.Label();
            lbQuantity = new System.Windows.Forms.Label();
            lbDeviceName = new System.Windows.Forms.Label();
            lbRoomName = new System.Windows.Forms.Label();
            lbFloorName = new System.Windows.Forms.Label();
            btnExit = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            dgvFeedbackList = new System.Windows.Forms.DataGridView();
            lbContent = new System.Windows.Forms.Label();
            lbCompleted = new System.Windows.Forms.Label();
            txtCompleted = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            txtDeviceId = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            txtStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).BeginInit();
            SuspendLayout();
            // 
            // txtDay
            // 
            txtDay.Location = new System.Drawing.Point(512, 406);
            txtDay.Name = "txtDay";
            txtDay.Size = new System.Drawing.Size(166, 27);
            txtDay.TabIndex = 66;
            // 
            // lbDay
            // 
            lbDay.AutoSize = true;
            lbDay.Location = new System.Drawing.Point(405, 408);
            lbDay.Name = "lbDay";
            lbDay.Size = new System.Drawing.Size(35, 20);
            lbDay.TabIndex = 65;
            lbDay.Text = "Day";
            // 
            // txtFloorName
            // 
            txtFloorName.Location = new System.Drawing.Point(202, 357);
            txtFloorName.Name = "txtFloorName";
            txtFloorName.Size = new System.Drawing.Size(166, 27);
            txtFloorName.TabIndex = 64;
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            rtbDescription.Location = new System.Drawing.Point(840, 356);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new System.Drawing.Size(235, 76);
            rtbDescription.TabIndex = 63;
            rtbDescription.Text = "";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(512, 357);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(166, 27);
            txtQuantity.TabIndex = 62;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new System.Drawing.Point(204, 453);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(166, 27);
            txtDeviceName.TabIndex = 61;
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new System.Drawing.Point(204, 405);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new System.Drawing.Size(166, 27);
            txtRoomName.TabIndex = 60;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(718, 359);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(88, 20);
            lbDescription.TabIndex = 59;
            lbDescription.Text = "Description:";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(405, 360);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(68, 20);
            lbQuantity.TabIndex = 58;
            lbQuantity.Text = "Quantity:";
            // 
            // lbDeviceName
            // 
            lbDeviceName.AutoSize = true;
            lbDeviceName.Location = new System.Drawing.Point(97, 456);
            lbDeviceName.Name = "lbDeviceName";
            lbDeviceName.Size = new System.Drawing.Size(101, 20);
            lbDeviceName.TabIndex = 57;
            lbDeviceName.Text = "Device Name:";
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Location = new System.Drawing.Point(98, 409);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new System.Drawing.Size(76, 20);
            lbRoomName.TabIndex = 56;
            lbRoomName.Text = "Room No:";
            // 
            // lbFloorName
            // 
            lbFloorName.AutoSize = true;
            lbFloorName.Location = new System.Drawing.Point(98, 360);
            lbFloorName.Name = "lbFloorName";
            lbFloorName.Size = new System.Drawing.Size(91, 20);
            lbFloorName.TabIndex = 55;
            lbFloorName.Text = "Floor name: ";
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(981, 540);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 54;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(981, 505);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 53;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(512, 505);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 52;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvFeedbackList
            // 
            dgvFeedbackList.AllowUserToAddRows = false;
            dgvFeedbackList.AllowUserToDeleteRows = false;
            dgvFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedbackList.Location = new System.Drawing.Point(100, 119);
            dgvFeedbackList.Name = "dgvFeedbackList";
            dgvFeedbackList.ReadOnly = true;
            dgvFeedbackList.RowHeadersWidth = 51;
            dgvFeedbackList.RowTemplate.Height = 29;
            dgvFeedbackList.Size = new System.Drawing.Size(975, 188);
            dgvFeedbackList.TabIndex = 50;
            dgvFeedbackList.CellDoubleClick += dgvFeedbackList_CellDoubleClick;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(426, 38);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(280, 48);
            lbContent.TabIndex = 49;
            lbContent.Text = "Feedback History";
            // 
            // lbCompleted
            // 
            lbCompleted.AutoSize = true;
            lbCompleted.Location = new System.Drawing.Point(405, 456);
            lbCompleted.Name = "lbCompleted";
            lbCompleted.Size = new System.Drawing.Size(83, 20);
            lbCompleted.TabIndex = 67;
            lbCompleted.Text = "Completed";
            // 
            // txtCompleted
            // 
            txtCompleted.Location = new System.Drawing.Point(512, 453);
            txtCompleted.Name = "txtCompleted";
            txtCompleted.Size = new System.Drawing.Size(166, 27);
            txtCompleted.TabIndex = 68;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(67, 609);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(18, 27);
            txtId.TabIndex = 71;
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new System.Drawing.Point(35, 609);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new System.Drawing.Size(21, 27);
            txtDeviceId.TabIndex = 70;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(612, 505);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(612, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 73;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new System.Drawing.Point(5, 609);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new System.Drawing.Size(24, 27);
            txtStatus.TabIndex = 74;
            // 
            // frmFeedbackHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1141, 579);
            Controls.Add(txtStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtId);
            Controls.Add(txtDeviceId);
            Controls.Add(txtCompleted);
            Controls.Add(lbCompleted);
            Controls.Add(txtDay);
            Controls.Add(lbDay);
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
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(dgvFeedbackList);
            Controls.Add(lbContent);
            Name = "frmFeedbackHistory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmFeedbackHistory";
            Load += frmFeedbackHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.TextBox txtFloorName;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbFloorName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvFeedbackList;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbCompleted;
        private System.Windows.Forms.TextBox txtCompleted;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtStatus;
    }
}