namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmMemberManagement
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
            lbMemberId = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbMemberEmail = new System.Windows.Forms.Label();
            txtMemberId = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtMemberEmail = new System.Windows.Forms.TextBox();
            btnLoad = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            txtSearchValue = new System.Windows.Forms.TextBox();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            lbContent = new System.Windows.Forms.Label();
            rbnName = new System.Windows.Forms.RadioButton();
            rbnEmail = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new System.Drawing.Point(46, 98);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new System.Drawing.Size(27, 20);
            lbMemberId.TabIndex = 0;
            lbMemberId.Text = "ID:";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(46, 141);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(76, 20);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Full name:";
            // 
            // lbMemberEmail
            // 
            lbMemberEmail.AutoSize = true;
            lbMemberEmail.Location = new System.Drawing.Point(46, 184);
            lbMemberEmail.Name = "lbMemberEmail";
            lbMemberEmail.Size = new System.Drawing.Size(106, 20);
            lbMemberEmail.TabIndex = 2;
            lbMemberEmail.Text = "Email Address:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new System.Drawing.Point(171, 95);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new System.Drawing.Size(163, 27);
            txtMemberId.TabIndex = 3;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(171, 138);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new System.Drawing.Size(163, 27);
            txtMemberName.TabIndex = 4;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new System.Drawing.Point(171, 181);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.ReadOnly = true;
            txtMemberEmail.Size = new System.Drawing.Size(163, 27);
            txtMemberEmail.TabIndex = 5;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(46, 244);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(374, 295);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(171, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(46, 295);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(171, 295);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new System.Drawing.Point(487, 296);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new System.Drawing.Size(141, 27);
            txtSearchValue.TabIndex = 11;
            // 
            // dgvMemberList
            // 
            dgvMemberList.AllowUserToAddRows = false;
            dgvMemberList.AllowUserToDeleteRows = false;
            dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(374, 85);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new System.Drawing.Size(464, 188);
            dgvMemberList.TabIndex = 12;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(269, 21);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(359, 48);
            lbContent.TabIndex = 13;
            lbContent.Text = "Member Management";
            // 
            // rbnName
            // 
            rbnName.AutoSize = true;
            rbnName.Checked = true;
            rbnName.Location = new System.Drawing.Point(662, 297);
            rbnName.Name = "rbnName";
            rbnName.Size = new System.Drawing.Size(70, 24);
            rbnName.TabIndex = 14;
            rbnName.TabStop = true;
            rbnName.Text = "Name";
            rbnName.UseVisualStyleBackColor = true;
            // 
            // rbnEmail
            // 
            rbnEmail.AutoSize = true;
            rbnEmail.Location = new System.Drawing.Point(662, 327);
            rbnEmail.Name = "rbnEmail";
            rbnEmail.Size = new System.Drawing.Size(67, 24);
            rbnEmail.TabIndex = 15;
            rbnEmail.Text = "Email";
            rbnEmail.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(887, 364);
            Controls.Add(rbnEmail);
            Controls.Add(rbnName);
            Controls.Add(lbContent);
            Controls.Add(dgvMemberList);
            Controls.Add(txtSearchValue);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnLoad);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberId);
            Controls.Add(lbMemberEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberId);
            Name = "frmMemberManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberId;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbMemberEmail;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.RadioButton rbnName;
        private System.Windows.Forms.RadioButton rbnEmail;
    }
}