namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmFeedbackManagement
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
            lbFeedbackList = new System.Windows.Forms.Label();
            dgvFeedbackList = new System.Windows.Forms.DataGridView();
            dgvStaffList = new System.Windows.Forms.DataGridView();
            lbStaffList = new System.Windows.Forms.Label();
            lbFeedbackId = new System.Windows.Forms.Label();
            lbStaffId = new System.Windows.Forms.Label();
            txtFeedbackId = new System.Windows.Forms.TextBox();
            txtStaffId = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            Search = new System.Windows.Forms.Button();
            dtpDay = new System.Windows.Forms.DateTimePicker();
            lbSenderName = new System.Windows.Forms.Label();
            lbSenderEmail = new System.Windows.Forms.Label();
            txtSenderName = new System.Windows.Forms.TextBox();
            txtSenderEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).BeginInit();
            SuspendLayout();
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(342, 46);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(379, 48);
            lbContent.TabIndex = 0;
            lbContent.Text = "Task Management FPTU";
            // 
            // lbFeedbackList
            // 
            lbFeedbackList.AutoSize = true;
            lbFeedbackList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFeedbackList.Location = new System.Drawing.Point(62, 128);
            lbFeedbackList.Name = "lbFeedbackList";
            lbFeedbackList.Size = new System.Drawing.Size(163, 35);
            lbFeedbackList.TabIndex = 1;
            lbFeedbackList.Text = "Feedback list:";
            // 
            // dgvFeedbackList
            // 
            dgvFeedbackList.AllowUserToAddRows = false;
            dgvFeedbackList.AllowUserToDeleteRows = false;
            dgvFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedbackList.Location = new System.Drawing.Point(62, 185);
            dgvFeedbackList.Name = "dgvFeedbackList";
            dgvFeedbackList.ReadOnly = true;
            dgvFeedbackList.RowHeadersWidth = 51;
            dgvFeedbackList.RowTemplate.Height = 29;
            dgvFeedbackList.Size = new System.Drawing.Size(989, 188);
            dgvFeedbackList.TabIndex = 2;
            dgvFeedbackList.CellDoubleClick += dgvFeedbackList_CellDoubleClick;
            // 
            // dgvStaffList
            // 
            dgvStaffList.AllowUserToAddRows = false;
            dgvStaffList.AllowUserToDeleteRows = false;
            dgvStaffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaffList.Location = new System.Drawing.Point(552, 488);
            dgvStaffList.Name = "dgvStaffList";
            dgvStaffList.ReadOnly = true;
            dgvStaffList.RowHeadersWidth = 51;
            dgvStaffList.RowTemplate.Height = 29;
            dgvStaffList.Size = new System.Drawing.Size(499, 188);
            dgvStaffList.TabIndex = 3;
            dgvStaffList.CellDoubleClick += dgvStaffList_CellDoubleClick;
            // 
            // lbStaffList
            // 
            lbStaffList.AutoSize = true;
            lbStaffList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbStaffList.Location = new System.Drawing.Point(552, 428);
            lbStaffList.Name = "lbStaffList";
            lbStaffList.Size = new System.Drawing.Size(107, 35);
            lbStaffList.TabIndex = 4;
            lbStaffList.Text = "Staff list:";
            // 
            // lbFeedbackId
            // 
            lbFeedbackId.AutoSize = true;
            lbFeedbackId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbFeedbackId.Location = new System.Drawing.Point(62, 518);
            lbFeedbackId.Name = "lbFeedbackId";
            lbFeedbackId.Size = new System.Drawing.Size(105, 23);
            lbFeedbackId.TabIndex = 5;
            lbFeedbackId.Text = "Feedback Id:";
            // 
            // lbStaffId
            // 
            lbStaffId.AutoSize = true;
            lbStaffId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbStaffId.Location = new System.Drawing.Point(62, 575);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new System.Drawing.Size(67, 23);
            lbStaffId.TabIndex = 6;
            lbStaffId.Text = "Staff Id:";
            // 
            // txtFeedbackId
            // 
            txtFeedbackId.Location = new System.Drawing.Point(210, 517);
            txtFeedbackId.Name = "txtFeedbackId";
            txtFeedbackId.Size = new System.Drawing.Size(177, 27);
            txtFeedbackId.TabIndex = 7;
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new System.Drawing.Point(210, 574);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new System.Drawing.Size(177, 27);
            txtStaffId.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(62, 617);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(210, 617);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(62, 679);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(210, 679);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(94, 29);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Search
            // 
            Search.Location = new System.Drawing.Point(551, 390);
            Search.Name = "Search";
            Search.Size = new System.Drawing.Size(94, 29);
            Search.TabIndex = 13;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // dtpDay
            // 
            dtpDay.Location = new System.Drawing.Point(699, 392);
            dtpDay.Name = "dtpDay";
            dtpDay.Size = new System.Drawing.Size(250, 27);
            dtpDay.TabIndex = 14;
            // 
            // lbSenderName
            // 
            lbSenderName.AutoSize = true;
            lbSenderName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSenderName.Location = new System.Drawing.Point(62, 397);
            lbSenderName.Name = "lbSenderName";
            lbSenderName.Size = new System.Drawing.Size(114, 23);
            lbSenderName.TabIndex = 15;
            lbSenderName.Text = "Sender Name";
            // 
            // lbSenderEmail
            // 
            lbSenderEmail.AutoSize = true;
            lbSenderEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbSenderEmail.Location = new System.Drawing.Point(60, 445);
            lbSenderEmail.Name = "lbSenderEmail";
            lbSenderEmail.Size = new System.Drawing.Size(109, 23);
            lbSenderEmail.TabIndex = 16;
            lbSenderEmail.Text = "Sender Email";
            // 
            // txtSenderName
            // 
            txtSenderName.Location = new System.Drawing.Point(210, 396);
            txtSenderName.Name = "txtSenderName";
            txtSenderName.ReadOnly = true;
            txtSenderName.Size = new System.Drawing.Size(177, 27);
            txtSenderName.TabIndex = 17;
            // 
            // txtSenderEmail
            // 
            txtSenderEmail.Location = new System.Drawing.Point(210, 444);
            txtSenderEmail.Name = "txtSenderEmail";
            txtSenderEmail.ReadOnly = true;
            txtSenderEmail.Size = new System.Drawing.Size(177, 27);
            txtSenderEmail.TabIndex = 18;
            // 
            // frmFeedbackManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1115, 718);
            Controls.Add(txtSenderEmail);
            Controls.Add(txtSenderName);
            Controls.Add(lbSenderEmail);
            Controls.Add(lbSenderName);
            Controls.Add(dtpDay);
            Controls.Add(Search);
            Controls.Add(btnExit);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtStaffId);
            Controls.Add(txtFeedbackId);
            Controls.Add(lbStaffId);
            Controls.Add(lbFeedbackId);
            Controls.Add(lbStaffList);
            Controls.Add(dgvStaffList);
            Controls.Add(dgvFeedbackList);
            Controls.Add(lbFeedbackList);
            Controls.Add(lbContent);
            Name = "frmFeedbackManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmTaskManagement";
            Load += frmFeedbackManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFeedbackList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStaffList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbFeedbackList;
        private System.Windows.Forms.DataGridView dgvFeedbackList;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.Label lbStaffList;
        private System.Windows.Forms.Label lbFeedbackId;
        private System.Windows.Forms.Label lbStaffId;
        private System.Windows.Forms.TextBox txtFeedbackId;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Label lbSenderName;
        private System.Windows.Forms.Label lbSenderEmail;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.TextBox txtSenderEmail;
    }
}