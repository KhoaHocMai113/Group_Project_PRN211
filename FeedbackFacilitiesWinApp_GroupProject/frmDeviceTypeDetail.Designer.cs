namespace FeedbackFacilitiesWinApp_GroupProject
{
    partial class frmDeviceTypeDetail
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
            txtDeviceType = new System.Windows.Forms.TextBox();
            txtDeviceName = new System.Windows.Forms.TextBox();
            lbDeviceType = new System.Windows.Forms.Label();
            lbDeviceName = new System.Windows.Forms.Label();
            lbContent = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtDeviceType
            // 
            txtDeviceType.Location = new System.Drawing.Point(217, 158);
            txtDeviceType.Name = "txtDeviceType";
            txtDeviceType.Size = new System.Drawing.Size(163, 27);
            txtDeviceType.TabIndex = 25;
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new System.Drawing.Point(217, 115);
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new System.Drawing.Size(163, 27);
            txtDeviceName.TabIndex = 24;
            // 
            // lbDeviceType
            // 
            lbDeviceType.AutoSize = true;
            lbDeviceType.Location = new System.Drawing.Point(92, 161);
            lbDeviceType.Name = "lbDeviceType";
            lbDeviceType.Size = new System.Drawing.Size(88, 20);
            lbDeviceType.TabIndex = 22;
            lbDeviceType.Text = "DeviceType:";
            // 
            // lbDeviceName
            // 
            lbDeviceName.AutoSize = true;
            lbDeviceName.Location = new System.Drawing.Point(92, 118);
            lbDeviceName.Name = "lbDeviceName";
            lbDeviceName.Size = new System.Drawing.Size(98, 20);
            lbDeviceName.TabIndex = 21;
            lbDeviceName.Text = "Device name:";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbContent.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbContent.Location = new System.Drawing.Point(71, 37);
            lbContent.Name = "lbContent";
            lbContent.Size = new System.Drawing.Size(342, 48);
            lbContent.TabIndex = 19;
            lbContent.Text = "Device - Type Adding";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(92, 232);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(94, 29);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(286, 232);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmDeviceTypeDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 302);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtDeviceType);
            Controls.Add(txtDeviceName);
            Controls.Add(lbDeviceType);
            Controls.Add(lbDeviceName);
            Controls.Add(lbContent);
            Name = "frmDeviceTypeDetail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmDeviceDetail";
            Load += frmDeviceTypeDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label lbDeviceType;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}