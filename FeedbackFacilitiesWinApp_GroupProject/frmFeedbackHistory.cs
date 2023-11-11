using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmFeedbackHistory : Form
    {
        IFeedbackRepository fbRepo = new FeedbackRepository();
        IDeviceRoomRepository drRepo = new DeviceRoomRepository();
        IDeviceTypeRepository dtRepo = new DeviceTypeRepository();
        IFloorRoomRepository frRepo = new FloorRoomRepository();
        public string memberId;
        public frmFeedbackHistory()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableText(true);
            txtCompleted.Clear();
            txtDay.Clear();

            btnSave.Enabled = true;
            btnSave.Visible = true;
            btnCancel.Enabled = true;
            btnCancel.Visible = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeedback frmFeedback = new frmFeedback();
            frmFeedback.memberId = memberId;
            frmFeedback.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void dgvFeedbackList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvFeedbackList.Rows[e.RowIndex];

            txtDeviceId.Text = row.Cells["DeviceId"].Value.ToString();
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtDay.Text = row.Cells["Day"].Value.ToString();
            rtbDescription.Text = row.Cells["Description"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtStatus.Text = row.Cells["Status"].Value.ToString();
            if (row.Cells["Status"].Value.ToString().Equals("1"))
            {
                txtCompleted.Text = "Completed";
            }
            else
            {
                txtCompleted.Text = "Not Completed";
            }

            var dr = drRepo.GetDeviceById(int.Parse(row.Cells["DeviceId"].Value.ToString()));
            txtDeviceName.Text = dtRepo.GetDeviceById(dr.DeviceTypeId).DeviceName;

            txtRoomName.Text = frRepo.GetRoomById(dr.RoomId).RoomNo.ToString();
            txtFloorName.Text = frRepo.GetFloorById(frRepo.GetRoomById(dr.RoomId).FloorId).FloorName.ToString();

            EnableText(false);
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
        private void frmFeedbackHistory_Load(object sender, EventArgs e)
        {
            LoadDeviceType();
        }
        public void LoadDeviceType()
        {
            var fbList = fbRepo.GetFeedbackBySender(int.Parse(memberId));

            BindingSource source = new BindingSource();
            source.DataSource = fbList;

            dgvFeedbackList.DataSource = null;
            dgvFeedbackList.DataSource = fbList;

            dgvFeedbackList.Columns["Id"].Visible = false;
            dgvFeedbackList.Columns["Sender"].Visible = false;
            dgvFeedbackList.Columns["Device"].Visible = false;
            dgvFeedbackList.Columns["SenderNavigation"].Visible = false;

            txtFloorName.Enabled = false;
            txtRoomName.Enabled = false;
            txtDeviceName.Enabled = false;
            txtQuantity.Enabled = false;
            rtbDescription.Enabled = false;
            txtDay.Enabled = false;
            txtDeviceId.Enabled = false;
            txtDeviceId.Visible = false;
            txtId.Enabled = false;
            txtId.Visible = false;
            txtStatus.Enabled = false;
            txtStatus.Visible = false;
            txtCompleted.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
        public void ClearText()
        {
            txtId.Clear();
            txtDeviceId.Clear();
            txtFloorName.Clear();
            txtRoomName.Clear();
            txtDeviceName.Clear();
            txtQuantity.Clear();
            txtDay.Clear();
            rtbDescription.Clear();
            txtCompleted.Clear();
        }
        private void EnableText(bool status)
        {
            txtQuantity.Enabled = status;
            rtbDescription.Enabled = status;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStatus.Text == "1")
                {
                    MessageBox.Show("This Feedback has been completed. You cannot update it !", "Feedback History",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var fb = new Feedback()
                    {
                        Id = int.Parse(txtId.Text),
                        Sender = int.Parse(memberId),
                        DeviceId = int.Parse(txtDeviceId.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        Description = rtbDescription.Text,
                        Day = DateTime.Now,
                        Status = 0,
                    };
                    fbRepo.UpdateFeedback(fb);
                    MessageBox.Show("Update Feedback successfully", "Feedback History",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDeviceType();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Update Feedback");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;

            LoadDeviceType();
            EnableText(false);
        }
    }
}
