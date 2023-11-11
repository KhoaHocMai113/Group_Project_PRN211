namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmStaffManagement
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
            dgvStaffList = new System.Windows.Forms.DataGridView();
            txtSearchValue = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            txtStaffEmail = new System.Windows.Forms.TextBox();
            txtStaffName = new System.Windows.Forms.TextBox();
            txtStaffId = new System.Windows.Forms.TextBox();
            lbStaffEmail = new System.Windows.Forms.Label();
            lbStaffName = new System.Windows.Forms.Label();
            lbStaffId = new System.Windows.Forms.Label();
            rbnName = new System.Windows.Forms.RadioButton();
            rbnEmail = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(268, 21);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(299, 48);
            lbContent.TabIndex = 27;
            lbContent.Text = "Staff Management";
            // 
            // dgvStaffList
            // 
            dgvStaffList.AllowUserToAddRows = false;
            dgvStaffList.AllowUserToDeleteRows = false;
            dgvStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(373, 85);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.ReadOnly = true;
            dgvStaffList.RowHeadersWidth = 51;
            dgvStaffList.RowTemplate.Height = 29;
            dgvStaffList.Size = new System.Drawing.Size(464, 188);
            dgvStaffList.TabIndex = 26;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(486, 296);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(141, 27);
            txtSearchValue.TabIndex = 25;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(170, 295);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(45, 295);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 23;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(170, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(373, 295);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(45, 244);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtStaffEmail
            // 
            txtStaffEmail.Location = new System.Drawing.Point(170, 181);
            txtStaffEmail.Name = "txtStaffEmail";
            txtStaffEmail.ReadOnly = true;
            txtStaffEmail.Size = new System.Drawing.Size(163, 27);
            txtStaffEmail.TabIndex = 19;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new System.Drawing.Point(170, 138);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new System.Drawing.Size(163, 27);
            txtStaffName.TabIndex = 18;
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new System.Drawing.Point(170, 95);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new System.Drawing.Size(163, 27);
            txtStaffId.TabIndex = 17;
            // 
            // lbStaffEmail
            // 
            lbStaffEmail.AutoSize = true;
            lbStaffEmail.Location = new System.Drawing.Point(45, 184);
            lbStaffEmail.Name = "lbStaffEmail";
            lbStaffEmail.Size = new System.Drawing.Size(106, 20);
            lbStaffEmail.TabIndex = 16;
            lbStaffEmail.Text = "Email Address:";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new System.Drawing.Point(45, 141);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new System.Drawing.Size(76, 20);
            lbStaffName.TabIndex = 15;
            lbStaffName.Text = "Full name:";
            // 
            // lbStaffId
            // 
            lbStaffId.AutoSize = true;
            lbStaffId.Location = new System.Drawing.Point(45, 98);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new System.Drawing.Size(27, 20);
            lbStaffId.TabIndex = 14;
            lbStaffId.Text = "ID:";
            // 
            // rbnName
            // 
            rbnName.AutoSize = true;
            rbnName.Checked = true;
            rbnName.Location = new System.Drawing.Point(660, 297);
            rbnName.Name = "rbnName";
            rbnName.Size = new System.Drawing.Size(70, 24);
            rbnName.TabIndex = 28;
            rbnName.TabStop = true;
            rbnName.Text = "Name";
            rbnName.UseVisualStyleBackColor = true;
            // 
            // rbnEmail
            // 
            rbnEmail.AutoSize = true;
            rbnEmail.Location = new System.Drawing.Point(660, 327);
            rbnEmail.Name = "rbnEmail";
            rbnEmail.Size = new System.Drawing.Size(67, 24);
            rbnEmail.TabIndex = 29;
            rbnEmail.Text = "Email";
            rbnEmail.UseVisualStyleBackColor = true;
            // 
            // frmStaffManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(888, 373);
            Controls.Add(rbnEmail);
            Controls.Add(rbnName);
            Controls.Add(lbContent);
            Controls.Add(dgvStaffList);
            Controls.Add(txtSearchValue);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnLoad);
            Controls.Add(txtStaffEmail);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffId);
            Controls.Add(lbStaffEmail);
            Controls.Add(lbStaffName);
            Controls.Add(lbStaffId);
            Name = "frmStaffManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmStaffManagement";
            Load += frmStaffManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label lbStaffEmail;
        private System.Windows.Forms.Label lbStaffName;
        private System.Windows.Forms.Label lbStaffId;
        private System.Windows.Forms.RadioButton rbnName;
        private System.Windows.Forms.RadioButton rbnEmail;
    }
}