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

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmFeedback : Form
    {
        public string memberId;
        IDeviceRoomRepository drRepo = new DeviceRoomRepository();
        IFloorRoomRepository flRepo = new FloorRoomRepository();
        IDeviceTypeRepository dtRepo = new DeviceTypeRepository();
        IFeedbackRepository fbRepo = new FeedbackRepository();
        IMemberRepository memRepo = new MemberRepository();
        public frmFeedback()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return memberId; }
            set { memberId = value; }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cboFloorName.Text) || string.IsNullOrEmpty(txtRoomName.Text) ||
                    string.IsNullOrEmpty(txtDeviceName.Text) || string.IsNullOrEmpty(txtQuantity.Text) ||
                    string.IsNullOrEmpty(rtbDescription.Text))
                {
                    MessageBox.Show("All fields are required!", "Sending Feedback Facilities",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var idCount = fbRepo.GetFeedbacks().Count();
                    int roomNo = int.Parse(txtRoomName.Text);
                    string deviceName = txtDeviceName.Text;
                    int IdDeviceRoom = 0;

                    var deviceRoomList = drRepo.GetDeviceByRoomId(flRepo.GetRoomByName(roomNo).Id);
                    for (int i = 0; i < deviceRoomList.Count; i++)
                    {
                        if (deviceRoomList[i].DeviceTypeId.Equals(dtRepo.GetDeviceByName(deviceName).Id))
                        {
                            IdDeviceRoom = deviceRoomList[i].Id;
                        }
                    }

                    if (IdDeviceRoom != 0)
                    {
                        var fb = new Feedback
                        {
                            Id = idCount + 1,
                            Sender = int.Parse(memberId),
                            DeviceId = IdDeviceRoom,
                            Quantity = int.Parse(txtQuantity.Text),
                            Description = rtbDescription.Text,
                            Day = DateTime.Now,
                            Status = 0
                        };
                        fbRepo.SaveFeedback(fb);
                        MessageBox.Show("Sending Feedback successfully", "Sending Feedback Facilities",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDeviceName.Clear();
                        txtQuantity.Clear();
                        rtbDescription.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Room is not have this Device", "Sending Feedback Facilities",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in sending feedback");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeviceName.Clear();
            txtRoomName.Clear();
            txtQuantity.Clear();
            rtbDescription.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
        private void dgvFloorList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvFloorList.Rows[e.RowIndex];

                int floorId = int.Parse(row.Cells[0].Value.ToString());
                cboFloorName.Text = flRepo.GetFloorById(floorId).FloorName;

                var roomList = flRepo.GetAllRoomsByFloorId(floorId);

                BindingSource source = new BindingSource();
                source.DataSource = roomList;

                dgvRoomList.DataSource = null;
                dgvRoomList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in loading Floor");
            }

        }
        private void dgvRoomList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvRoomList.Rows[e.RowIndex];

                int roomId = int.Parse(row.Cells[0].Value.ToString());
                txtRoomName.Text = flRepo.GetRoomById(roomId).RoomNo.ToString();

                var deviceRoomList = drRepo.GetDeviceByRoomId(roomId);

                BindingSource source = new BindingSource();
                source.DataSource = deviceRoomList;

                dgvDeviceList.DataSource = null;
                dgvDeviceList.DataSource = source;
                txtDeviceName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in loading Room");
            }

        }
        private void dgvDeviceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDeviceList.Rows[e.RowIndex];

                int deviceRoomId = int.Parse(row.Cells[0].Value.ToString());
                txtDeviceName.Text = dtRepo.GetDeviceById(drRepo.GetDeviceById(deviceRoomId).DeviceTypeId).DeviceName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in loading Device");
            }

        }
        private void frmFeedback_Load(object sender, EventArgs e)
        {
            try
            {
                var floorList = flRepo.GetFloors();

                BindingSource sourceF = new BindingSource();
                sourceF.DataSource = floorList;

                dgvFloorList.DataSource = null;
                dgvFloorList.DataSource = sourceF;

                foreach (var floor in floorList)
                {
                    cboFloorName.Items.Add(floor.FloorName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of floor information");
            }
        }
        private void btnViewHis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeedbackHistory frmFeedbackHistory = new frmFeedbackHistory();
            frmFeedbackHistory.memberId = memberId;
            frmFeedbackHistory.ShowDialog();
            this.Close();
        }
    }
}
