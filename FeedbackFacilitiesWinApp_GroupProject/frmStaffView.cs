using BusinessObject;
using Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmStaffView : Form
    {
        IFeedbackRepository fbRepo = new FeedbackRepository();
        ITaskRepository taskRepo = new TaskRepository();
        IDeviceRoomRepository drRepo = new DeviceRoomRepository();
        IDeviceTypeRepository dtRepo = new DeviceTypeRepository();
        IFloorRoomRepository frRepo = new FloorRoomRepository();
        public string staffId;
        public frmStaffView()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return staffId; }
            set { staffId = value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int status = 0;
                if (cboStatus.Text == "YES")
                {
                    status = 1;
                }

                var fb = new Feedback()
                {
                    Id = int.Parse(txtId.Text),
                    Sender = int.Parse(txtSenderId.Text),
                    DeviceId = int.Parse(txtDeviceId.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Description = rtbDescription.Text,
                    Day = DateTime.Parse(txtDay.Text),
                    Status = status,
                };
                fbRepo.UpdateFeedback(fb);
                LoadDeviceType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Update Feedback");
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void frmStaffView_Load(object sender, EventArgs e)
        {
            LoadDeviceType();
        }
        private void dgvFeedbackList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cboStatus.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvFeedbackList.Rows[e.RowIndex];

            txtSenderId.Text = row.Cells["Sender"].Value.ToString();
            txtDeviceId.Text = row.Cells["DeviceId"].Value.ToString();
            txtId.Text = row.Cells["Id"].Value.ToString();
            txtDay.Text = row.Cells["Day"].Value.ToString();
            rtbDescription.Text = row.Cells["Description"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();

            var dr = drRepo.GetDeviceById(int.Parse(row.Cells["DeviceId"].Value.ToString()));
            txtDeviceName.Text = dtRepo.GetDeviceById(dr.DeviceTypeId).DeviceName;

            txtRoomName.Text = frRepo.GetRoomById(dr.RoomId).RoomNo.ToString();
            txtFloorName.Text = frRepo.GetFloorById(frRepo.GetRoomById(dr.RoomId).FloorId).FloorName.ToString();

        }
        public void LoadDeviceType()
        {
            var fbList = fbRepo.GetFeedbackByStatus(0);
            var taskList = taskRepo.GetTaskByStaffId(int.Parse(staffId));

            List<Object> newfbList = new List<Object>();
            List<int> fbId = new List<int>();

            foreach (var task in taskList)
            {
                fbId.Add(task.FeedbackId);
            }
            for (int i = 0; i < fbList.Count; i++)
            {
                foreach (var item in fbId)
                {
                    if (fbList[i].Id.Equals(item))
                    {
                        newfbList.Add(fbList[i]);
                    }
                }
            }
            if (newfbList.Count == 0 || newfbList == null)
            {
                BindingSource source = new BindingSource();
                source.DataSource = newfbList;

                dgvFeedbackList.DataSource = null;
                dgvFeedbackList.DataSource = newfbList;

                txtFloorName.Enabled = false;
                txtRoomName.Enabled = false;
                txtDeviceName.Enabled = false;
                txtQuantity.Enabled = false;
                rtbDescription.Enabled = false;
                txtDay.Enabled = false;
                txtSenderId.Enabled = false;
                txtSenderId.Visible = false;
                txtDeviceId.Enabled = false;
                txtDeviceId.Visible = false;
                txtId.Enabled = false;
                txtId.Visible = false;
                cboStatus.Enabled = false;

                lbAssigned.Text = "There are no assigned tasks";              
            }
            else
            {
                BindingSource source = new BindingSource();
                source.DataSource = newfbList;

                dgvFeedbackList.DataSource = null;
                dgvFeedbackList.DataSource = newfbList;

                dgvFeedbackList.Columns["Id"].Visible = false;
                dgvFeedbackList.Columns["Sender"].Visible = false;
                dgvFeedbackList.Columns["Status"].Visible = false;
                dgvFeedbackList.Columns["Device"].Visible = false;
                dgvFeedbackList.Columns["SenderNavigation"].Visible = false;

                txtFloorName.Enabled = false;
                txtRoomName.Enabled = false;
                txtDeviceName.Enabled = false;
                txtQuantity.Enabled = false;
                rtbDescription.Enabled = false;
                txtDay.Enabled = false;
                txtSenderId.Enabled = false;
                txtSenderId.Visible = false;
                txtDeviceId.Enabled = false;
                txtDeviceId.Visible = false;
                txtId.Enabled = false;
                txtId.Visible = false;

                lbAssigned.Text = "Have assigned tasks";
            }
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
        }
    }
}
