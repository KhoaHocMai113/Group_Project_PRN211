namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmDeviceTypeManagement
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
            dgvDeviceList = new System.Windows.Forms.DataGridView();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            txtDeviceType = new System.Windows.Forms.TextBox();
            txtDeviceName = new System.Windows.Forms.TextBox();
            txtDeviceTypeId = new System.Windows.Forms.TextBox();
            lbDeviceType = new System.Windows.Forms.Label();
            lbDeviceName = new System.Windows.Forms.Label();
            lbDeviceTypeId = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            rbnName = new System.Windows.Forms.RadioButton();
            rbnType = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvDeviceList).BeginInit();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(223, 30);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(433, 48);
            lbContent.TabIndex = 0;
            lbContent.Text = "Device - Type Management";
            // 
            // dgvDeviceList
            // 
            dgvDeviceList.AllowUserToAddRows = false;
            dgvDeviceList.AllowUserToDeleteRows = false;
            dgvDeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeviceList.Location = new System.Drawing.Point(368, 102);
            dgvDeviceList.Name = "dgvDeviceList";
            dgvDeviceList.ReadOnly = true;
            dgvDeviceList.RowHeadersWidth = 51;
            dgvDeviceList.RowTemplate.Height = 29;
            dgvDeviceList.Size = new System.Drawing.Size(464, 188);
            dgvDeviceList.TabIndex = 25;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(481, 313);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(141, 27);
            txtSearchValue.TabIndex = 24;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(259, 312);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(150, 311);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(40, 311);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(368, 312);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(40, 261);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 19;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtDeviceType
            // 
            txtDeviceType.Location = new System.Drawing.Point(165, 198);
            txtDeviceType.Name = "txtDeviceType";
            txtDeviceType.Size = new System.Drawing.Size(163, 27);
            txtDeviceType.TabIndex = 18;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new System.Drawing.Point(165, 155);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(163, 27);
            txtDeviceName.TabIndex = 17;
            // 
            // txtDeviceTypeId
            // 
            txtDeviceTypeId.Location = new System.Drawing.Point(165, 112);
            txtDeviceTypeId.Name = "txtDeviceTypeId";
            txtDeviceTypeId.ReadOnly = true;
            txtDeviceTypeId.Size = new System.Drawing.Size(163, 27);
            txtDeviceTypeId.TabIndex = 16;
            // 
            // lbDeviceType
            // 
            lbDeviceType.AutoSize = true;
            lbDeviceType.Location = new System.Drawing.Point(40, 201);
            lbDeviceType.Name = "lbDeviceType";
            lbDeviceType.Size = new System.Drawing.Size(88, 20);
            lbDeviceType.TabIndex = 15;
            lbDeviceType.Text = "DeviceType:";
            // 
            // lbDeviceName
            // 
            lbDeviceName.AutoSize = true;
            lbDeviceName.Location = new System.Drawing.Point(40, 158);
            lbDeviceName.Name = "lbDeviceName";
            lbDeviceName.Size = new System.Drawing.Size(98, 20);
            lbDeviceName.TabIndex = 14;
            lbDeviceName.Text = "Device name:";
            // 
            // lbDeviceTypeId
            // 
            lbDeviceTypeId.AutoSize = true;
            lbDeviceTypeId.Location = new System.Drawing.Point(40, 115);
            lbDeviceTypeId.Name = "lbDeviceTypeId";
            lbDeviceTypeId.Size = new System.Drawing.Size(27, 20);
            lbDeviceTypeId.TabIndex = 13;
            lbDeviceTypeId.Text = "ID:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(150, 261);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(259, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // rbnName
            // 
            rbnName.AutoSize = true;
            rbnName.Checked = true;
            rbnName.Location = new System.Drawing.Point(647, 314);
            rbnName.Name = "rbnName";
            rbnName.Size = new System.Drawing.Size(70, 24);
            rbnName.TabIndex = 28;
            rbnName.TabStop = true;
            rbnName.Text = "Name";
            rbnName.UseVisualStyleBackColor = true;
            // 
            // rbnType
            // 
            rbnType.AutoSize = true;
            rbnType.Location = new System.Drawing.Point(647, 344);
            rbnType.Name = "rbnType";
            rbnType.Size = new System.Drawing.Size(61, 24);
            rbnType.TabIndex = 29;
            rbnType.Text = "Type";
            rbnType.UseVisualStyleBackColor = true;
            // 
            // frmDeviceTypeManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(888, 374);
            Controls.Add(rbnType);
            Controls.Add(rbnName);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvDeviceList);
            Controls.Add(txtSearchValue);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnLoad);
            Controls.Add(txtDeviceType);
            Controls.Add(txtDeviceName);
            Controls.Add(txtDeviceTypeId);
            Controls.Add(lbDeviceType);
            Controls.Add(lbDeviceName);
            Controls.Add(lbDeviceTypeId);
            Controls.Add(lbContent);
            Name = "frmDeviceTypeManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmDeviceTypeManagement";
            Load += frmDeviceTypeManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDeviceList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.DataGridView dgvDeviceList;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtDeviceTypeId;
        private System.Windows.Forms.Label lbDeviceType;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Label lbDeviceTypeId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rbnName;
        private System.Windows.Forms.RadioButton rbnType;
    }
}