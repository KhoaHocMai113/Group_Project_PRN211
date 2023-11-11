namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmFeedback
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
            lbDeviceType = new System.Windows.Forms.Label();
            lbRoom = new System.Windows.Forms.Label();
            lbFloor = new System.Windows.Forms.Label();
            dgvDeviceList = new System.Windows.Forms.DataGridView();
            dgvRoomList = new System.Windows.Forms.DataGridView();
            dgvFloorList = new System.Windows.Forms.DataGridView();
            lbContent = new System.Windows.Forms.Label();
            lbFloorName = new System.Windows.Forms.Label();
            lbRoomName = new System.Windows.Forms.Label();
            lbDeviceName = new System.Windows.Forms.Label();
            lbQuantity = new System.Windows.Forms.Label();
            lbDescription = new System.Windows.Forms.Label();
            txtRoomName = new System.Windows.Forms.TextBox();
            txtDeviceName = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            rtbDescription = new System.Windows.Forms.RichTextBox();
            btnSend = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();
            cboFloorName = new System.Windows.Forms.ComboBox();
            btnViewHis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFloorList).BeginInit();
            SuspendLayout();
            // 
            // lbDeviceType
            // 
            lbDeviceType.AutoSize = true;
            lbDeviceType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDeviceType.Location = new System.Drawing.Point(851, 90);
            lbDeviceType.Name = "lbDeviceType";
            lbDeviceType.Size = new System.Drawing.Size(94, 35);
            lbDeviceType.TabIndex = 16;
            lbDeviceType.Text = "Device:";
            // 
            // lbRoom
            // 
            lbRoom.AutoSize = true;
            lbRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRoom.Location = new System.Drawing.Point(457, 90);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new System.Drawing.Size(86, 35);
            lbRoom.TabIndex = 15;
            lbRoom.Text = "Room:";
            // 
            // lbFloor
            // 
            lbFloor.AutoSize = true;
            lbFloor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFloor.Location = new System.Drawing.Point(47, 90);
            lbFloor.Name = "lbFloor";
            lbFloor.Size = new System.Drawing.Size(77, 35);
            lbFloor.TabIndex = 14;
            lbFloor.Text = "Floor:";
            // 
            // dgvDeviceList
            // 
            dgvDeviceList.AllowUserToAddRows = false;
            dgvDeviceList.AllowUserToDeleteRows = false;
            dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeviceList.Location = new System.Drawing.Point(851, 134);
            dgvDeviceList.Name = "dgvDeviceList";
            dgvDeviceList.ReadOnly = true;
            dgvDeviceList.RowHeadersWidth = 51;
            dgvDeviceList.RowTemplate.Height = 29;
            dgvDeviceList.Size = new System.Drawing.Size(357, 188);
            dgvDeviceList.TabIndex = 13;
            dgvDeviceList.CellDoubleClick += dgvDeviceList_CellDoubleClick;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AllowUserToAddRows = false;
            dgvRoomList.AllowUserToDeleteRows = false;
            dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new System.Drawing.Point(457, 134);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.ReadOnly = true;
            dgvRoomList.RowHeadersWidth = 51;
            dgvRoomList.RowTemplate.Height = 29;
            dgvRoomList.Size = new System.Drawing.Size(357, 188);
            dgvRoomList.TabIndex = 12;
            dgvRoomList.CellDoubleClick += dgvRoomList_CellDoubleClick;
            // 
            // dgvFloorList
            // 
            dgvFloorList.AllowUserToAddRows = false;
            dgvFloorList.AllowUserToDeleteRows = false;
            dgvFloorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFloorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFloorList.Location = new System.Drawing.Point(47, 134);
            dgvFloorList.Name = "dgvFloorList";
            dgvFloorList.ReadOnly = true;
            dgvFloorList.RowHeadersWidth = 51;
            dgvFloorList.RowTemplate.Height = 29;
            dgvFloorList.Size = new System.Drawing.Size(357, 188);
            dgvFloorList.TabIndex = 11;
            dgvFloorList.CellDoubleClick += dgvFloorList_CellDoubleClick;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(358, 23);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(517, 48);
            lbContent.TabIndex = 10;
            lbContent.Text = "Feedback Facilities FPT University";
            // 
            // lbFloorName
            // 
            lbFloorName.AutoSize = true;
            lbFloorName.Location = new System.Drawing.Point(47, 384);
            lbFloorName.Name = "lbFloorName";
            lbFloorName.Size = new System.Drawing.Size(91, 20);
            lbFloorName.TabIndex = 17;
            lbFloorName.Text = "Floor name: ";
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Location = new System.Drawing.Point(47, 433);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new System.Drawing.Size(76, 20);
            lbRoomName.TabIndex = 18;
            lbRoomName.Text = "Room No:";
            // 
            // lbDeviceName
            // 
            lbDeviceName.AutoSize = true;
            lbDeviceName.Location = new System.Drawing.Point(426, 384);
            lbDeviceName.Name = "lbDeviceName";
            lbDeviceName.Size = new System.Drawing.Size(101, 20);
            lbDeviceName.TabIndex = 19;
            lbDeviceName.Text = "Device Name:";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new System.Drawing.Point(426, 433);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new System.Drawing.Size(68, 20);
            lbQuantity.TabIndex = 20;
            lbQuantity.Text = "Quantity:";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(851, 384);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new System.Drawing.Size(88, 20);
            lbDescription.TabIndex = 21;
            lbDescription.Text = "Description:";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new System.Drawing.Point(191, 430);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new System.Drawing.Size(190, 27);
            txtRoomName.TabIndex = 23;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new System.Drawing.Point(570, 381);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(190, 27);
            txtDeviceName.TabIndex = 24;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(570, 430);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(190, 27);
            txtQuantity.TabIndex = 25;
            // 
            // rtbDescription
            // 
            rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            rtbDescription.Location = new System.Drawing.Point(973, 381);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new System.Drawing.Size(235, 76);
            rtbDescription.TabIndex = 26;
            rtbDescription.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new System.Drawing.Point(585, 538);
            btnSend.Name = "btnSend";
            btnSend.Size = new System.Drawing.Size(94, 29);
            btnSend.TabIndex = 27;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(368, 538);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 28;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(1020, 538);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 29;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new System.Drawing.Point(824, 538);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(94, 29);
            btnLogout.TabIndex = 30;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // cboFloorName
            // 
            cboFloorName.FormattingEnabled = true;
            cboFloorName.Location = new System.Drawing.Point(191, 381);
            cboFloorName.Name = "cboFloorName";
            cboFloorName.Size = new System.Drawing.Size(190, 28);
            cboFloorName.TabIndex = 31;
            // 
            // btnViewHis
            // 
            btnViewHis.Location = new System.Drawing.Point(105, 538);
            btnViewHis.Name = "btnViewHis";
            btnViewHis.Size = new System.Drawing.Size(182, 29);
            btnViewHis.TabIndex = 32;
            btnViewHis.Text = "View Feedback History";
            btnViewHis.UseVisualStyleBackColor = true;
            btnViewHis.Click += btnViewHis_Click;
            // 
            // frmFeedback
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 614);
            Controls.Add(btnViewHis);
            Controls.Add(cboFloorName);
            Controls.Add(btnLogout);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSend);
            Controls.Add(rtbDescription);
            Controls.Add(txtQuantity);
            Controls.Add(txtDeviceName);
            Controls.Add(txtRoomName);
            Controls.Add(lbDescription);
            Controls.Add(lbQuantity);
            Controls.Add(lbDeviceName);
            Controls.Add(lbRoomName);
            Controls.Add(lbFloorName);
            Controls.Add(lbDeviceType);
            Controls.Add(lbRoom);
            Controls.Add(lbFloor);
            Controls.Add(dgvDeviceList);
            Controls.Add(dgvRoomList);
            Controls.Add(dgvFloorList);
            Controls.Add(lbContent);
            Name = "frmFeedback";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmFeedback";
            Load += frmFeedback_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeviceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFloorList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbDeviceType;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.DataGridView dgvFloorList;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbFloorName;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cboFloorName;
        private System.Windows.Forms.Button btnViewHis;
    }
}