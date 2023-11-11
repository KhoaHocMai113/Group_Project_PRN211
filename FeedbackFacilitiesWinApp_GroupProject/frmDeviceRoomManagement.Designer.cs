namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmDeviceRoomManagement
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
            dgvFloorList = new System.Windows.Forms.DataGridView();
            dgvRoomList = new System.Windows.Forms.DataGridView();
            dgvDeviceList = new System.Windows.Forms.DataGridView();
            lbFloor = new System.Windows.Forms.Label();
            lbRoom = new System.Windows.Forms.Label();
            lbDeviceType = new System.Windows.Forms.Label();
            dgvDeviceRoomList = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            lbRoomName = new System.Windows.Forms.Label();
            lbDeviceName = new System.Windows.Forms.Label();
            txtRoomName = new System.Windows.Forms.TextBox();
            txtDeviceName = new System.Windows.Forms.TextBox();
            lbDeviceRoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvFloorList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceRoomList).BeginInit();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(355, 32);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(451, 48);
            lbContent.TabIndex = 1;
            lbContent.Text = "Device - Room Management";
            // 
            // dgvFloorList
            // 
            dgvFloorList.AllowUserToAddRows = false;
            dgvFloorList.AllowUserToDeleteRows = false;
            dgvFloorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFloorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFloorList.Location = new System.Drawing.Point(44, 143);
            dgvFloorList.Name = "dgvFloorList";
            dgvFloorList.ReadOnly = true;
            dgvFloorList.RowHeadersWidth = 51;
            dgvFloorList.RowTemplate.Height = 29;
            dgvFloorList.Size = new System.Drawing.Size(357, 188);
            dgvFloorList.TabIndex = 2;
            dgvFloorList.CellDoubleClick += dgvFloorList_CellDoubleClick;
            // 
            // dgvRoomList
            // 
            dgvRoomList.AllowUserToAddRows = false;
            dgvRoomList.AllowUserToDeleteRows = false;
            dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomList.Location = new System.Drawing.Point(454, 143);
            dgvRoomList.Name = "dgvRoomList";
            dgvRoomList.ReadOnly = true;
            dgvRoomList.RowHeadersWidth = 51;
            dgvRoomList.RowTemplate.Height = 29;
            dgvRoomList.Size = new System.Drawing.Size(357, 188);
            dgvRoomList.TabIndex = 3;
            dgvRoomList.CellDoubleClick += dgvRoomList_CellDoubleClick;
            // 
            // dgvDeviceList
            // 
            dgvDeviceList.AllowUserToAddRows = false;
            dgvDeviceList.AllowUserToDeleteRows = false;
            dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeviceList.Location = new System.Drawing.Point(848, 143);
            dgvDeviceList.Name = "dgvDeviceList";
            dgvDeviceList.ReadOnly = true;
            dgvDeviceList.RowHeadersWidth = 51;
            dgvDeviceList.RowTemplate.Height = 29;
            dgvDeviceList.Size = new System.Drawing.Size(357, 188);
            dgvDeviceList.TabIndex = 4;
            dgvDeviceList.CellDoubleClick += dgvDeviceList_CellDoubleClick;
            // 
            // lbFloor
            // 
            lbFloor.AutoSize = true;
            lbFloor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFloor.Location = new System.Drawing.Point(44, 99);
            lbFloor.Name = "lbFloor";
            lbFloor.Size = new System.Drawing.Size(77, 35);
            lbFloor.TabIndex = 5;
            lbFloor.Text = "Floor:";
            // 
            // lbRoom
            // 
            lbRoom.AutoSize = true;
            lbRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbRoom.Location = new System.Drawing.Point(454, 99);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new System.Drawing.Size(86, 35);
            lbRoom.TabIndex = 8;
            lbRoom.Text = "Room:";
            // 
            // lbDeviceType
            // 
            lbDeviceType.AutoSize = true;
            lbDeviceType.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDeviceType.Location = new System.Drawing.Point(848, 99);
            lbDeviceType.Name = "lbDeviceType";
            lbDeviceType.Size = new System.Drawing.Size(170, 35);
            lbDeviceType.TabIndex = 9;
            lbDeviceType.Text = "Device - Type:";
            // 
            // dgvDeviceRoomList
            // 
            dgvDeviceRoomList.AllowUserToAddRows = false;
            dgvDeviceRoomList.AllowUserToDeleteRows = false;
            dgvDeviceRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeviceRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeviceRoomList.Location = new System.Drawing.Point(454, 395);
            dgvDeviceRoomList.Name = "dgvDeviceRoomList";
            dgvDeviceRoomList.ReadOnly = true;
            dgvDeviceRoomList.RowHeadersWidth = 51;
            dgvDeviceRoomList.RowTemplate.Height = 29;
            dgvDeviceRoomList.Size = new System.Drawing.Size(488, 188);
            dgvDeviceRoomList.TabIndex = 10;
            dgvDeviceRoomList.CellDoubleClick += dgvDeviceRoomList_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(44, 498);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 32;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(162, 554);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 31;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(44, 554);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(162, 498);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Location = new System.Drawing.Point(44, 395);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new System.Drawing.Size(93, 20);
            lbRoomName.TabIndex = 34;
            lbRoomName.Text = "Room name:";
            // 
            // lbDeviceName
            // 
            lbDeviceName.AutoSize = true;
            lbDeviceName.Location = new System.Drawing.Point(44, 438);
            lbDeviceName.Name = "lbDeviceName";
            lbDeviceName.Size = new System.Drawing.Size(98, 20);
            lbDeviceName.TabIndex = 35;
            lbDeviceName.Text = "Device name:";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new System.Drawing.Point(162, 392);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new System.Drawing.Size(147, 27);
            txtRoomName.TabIndex = 36;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new System.Drawing.Point(162, 435);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(147, 27);
            txtDeviceName.TabIndex = 37;
            // 
            // lbDeviceRoom
            // 
            lbDeviceRoom.AutoSize = true;
            lbDeviceRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbDeviceRoom.Location = new System.Drawing.Point(454, 347);
            lbDeviceRoom.Name = "lbDeviceRoom";
            lbDeviceRoom.Size = new System.Drawing.Size(184, 35);
            lbDeviceRoom.TabIndex = 38;
            lbDeviceRoom.Text = "Device - Room:";
            // 
            // frmDeviceRoomManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1256, 625);
            Controls.Add(lbDeviceRoom);
            Controls.Add(txtDeviceName);
            Controls.Add(txtRoomName);
            Controls.Add(lbDeviceName);
            Controls.Add(lbRoomName);
            Controls.Add(btnAdd);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(dgvDeviceRoomList);
            Controls.Add(lbDeviceType);
            Controls.Add(lbRoom);
            Controls.Add(lbFloor);
            Controls.Add(dgvDeviceList);
            Controls.Add(dgvRoomList);
            Controls.Add(dgvFloorList);
            Controls.Add(lbContent);
            Name = "frmDeviceRoomManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmDeviceRoom";
            Load += frmDeviceRoomManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFloorList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceRoomList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.DataGridView dgvFloorList;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbDeviceType;
        private System.Windows.Forms.DataGridView dgvDeviceRoomList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbRoomName;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lbDeviceRoom;
    }
}