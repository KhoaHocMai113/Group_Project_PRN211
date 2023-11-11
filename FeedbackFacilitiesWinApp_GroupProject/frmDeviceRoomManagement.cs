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
    public partial class frmDeviceRoomManagement : Form
    {
        IFloorRoomRepository flRepo = new FloorRoomRepository();
        IDeviceTypeRepository dtRepo = new DeviceTypeRepository();
        IDeviceRoomRepository drRepo = new DeviceRoomRepository();
        BindingSource source;
        public frmDeviceRoomManagement()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRoomName.Text)|| string.IsNullOrEmpty(txtDeviceName.Text))
                {
                    MessageBox.Show("All fields are required!", "Adding Device to Room",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var idCount = drRepo.GetDevice().Count();
                    int roomNo = int.Parse(txtRoomName.Text);
                    string devicename = txtDeviceName.Text;

                    List<Device> ListDeviceRoom = drRepo.GetDeviceByRoomId(flRepo.GetRoomByName(roomNo).Id);

                    foreach (var dr in ListDeviceRoom)
                    {
                        if (dr.DeviceTypeId == dtRepo.GetDeviceByName(devicename).Id)
                        {
                            MessageBox.Show("This room already has this Device", "Adding Device to Room",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    var newDR = new Device
                    {
                        Id = idCount + 1,
                        DeviceTypeId = dtRepo.GetDeviceByName(devicename).Id,
                        RoomId = flRepo.GetRoomByName(roomNo).Id
                    };
                    drRepo.SaveDeviceRoom(newDR);
                    MessageBox.Show("Adding successfully", "Adding Device to Room",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var deviceRoomList = drRepo.GetDeviceByRoomId(flRepo.GetRoomByName(roomNo).Id);
                    BindingSource source = new BindingSource();
                    source.DataSource = deviceRoomList;

                    dgvDeviceRoomList.DataSource = null;
                    dgvDeviceRoomList.DataSource = source;
                    dgvDeviceRoomList.Columns["Id"].Visible = false;
                    dgvDeviceRoomList.Columns["DeviceType"].Visible = false;
                    dgvDeviceRoomList.Columns["Room"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Adding Device to Room");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?",
                "Device - Room Management", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                int roomNo = int.Parse(txtRoomName.Text);
                string devicename = txtDeviceName.Text;
                drRepo.RemoveDeviceRoom(flRepo.GetRoomByName(roomNo).Id, dtRepo.GetDeviceByName(devicename).Id);
                MessageBox.Show("Deleting successfully", "Delete Device in Room",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRoomName.Clear();
                txtDeviceName.Clear();

                var deviceRoomList = drRepo.GetDeviceByRoomId(flRepo.GetRoomByName(roomNo).Id);
                BindingSource source = new BindingSource();
                source.DataSource = deviceRoomList;

                dgvDeviceRoomList.DataSource = null;
                dgvDeviceRoomList.DataSource = source;
                dgvDeviceRoomList.Columns["Id"].Visible = false;
                dgvDeviceRoomList.Columns["DeviceType"].Visible = false;
                dgvDeviceRoomList.Columns["Room"].Visible = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void frmDeviceRoomManagement_Load(object sender, EventArgs e)
        {
            try
            {
                var floorList = flRepo.GetFloors();
                var deviceList = dtRepo.GetDevices();

                BindingSource sourceF = new BindingSource();
                BindingSource sourceD = new BindingSource();
                sourceF.DataSource = floorList;
                sourceD.DataSource = deviceList;

                dgvFloorList.DataSource = null;
                dgvFloorList.DataSource = sourceF;

                dgvDeviceList.DataSource = null;
                dgvDeviceList.DataSource = sourceD;

                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of floor information");
            }

        }
        private void dgvFloorList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvFloorList.Rows[e.RowIndex];

            int floorId = int.Parse(row.Cells[0].Value.ToString());
            var roomList = flRepo.GetAllRoomsByFloorId(floorId);

            BindingSource source = new BindingSource();
            source.DataSource = roomList;

            dgvRoomList.DataSource = null;
            dgvRoomList.DataSource = source;
        }
        private void dgvRoomList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvRoomList.Rows[e.RowIndex];

            int roomId = int.Parse(row.Cells[0].Value.ToString());

            txtRoomName.Text = flRepo.GetRoomById(roomId).RoomNo.ToString();

            var deviceRoomList = drRepo.GetDeviceByRoomId(roomId);
            BindingSource source = new BindingSource();
            source.DataSource = deviceRoomList;

            dgvDeviceRoomList.DataSource = null;
            dgvDeviceRoomList.DataSource = source;
            dgvDeviceRoomList.Columns["Id"].Visible = false;
            dgvDeviceRoomList.Columns["DeviceType"].Visible = false;
            dgvDeviceRoomList.Columns["Room"].Visible = false;

            btnDelete.Enabled = true;
        }
        private void dgvDeviceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDeviceList.Rows[e.RowIndex];

            int deviceId = int.Parse(row.Cells[0].Value.ToString());

            txtDeviceName.Text = dtRepo.GetDeviceById(deviceId).DeviceName.ToString();
        }
        private void dgvDeviceRoomList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDeviceRoomList.Rows[e.RowIndex];

            int roomId = int.Parse(row.Cells[2].Value.ToString());
            int deviceId = int.Parse(row.Cells[1].Value.ToString());

            txtRoomName.Clear();
            txtDeviceName.Clear();

            txtRoomName.Text = flRepo.GetRoomById(roomId).RoomNo.ToString();
            txtDeviceName.Text = dtRepo.GetDeviceById(deviceId).DeviceName;
        }
    }
}
