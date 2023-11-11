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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmDeviceTypeManagement : Form
    {
        IDeviceTypeRepository dtRepo = new DeviceTypeRepository();
        IDeviceRoomRepository drRepo = new DeviceRoomRepository();
        BindingSource source;
        public frmDeviceTypeManagement()
        {
            InitializeComponent();
        }

        public void LoadDeviceType()
        {
            try
            {
                var dtList = dtRepo.GetDevices();
                BindingSource source = new BindingSource();
                source.DataSource = dtList;

                txtDeviceTypeId.DataBindings.Clear();
                txtDeviceName.DataBindings.Clear();
                txtDeviceType.DataBindings.Clear();

                txtDeviceTypeId.DataBindings.Add("Text", source, "Id");
                txtDeviceName.DataBindings.Add("Text", source, "DeviceName");
                txtDeviceType.DataBindings.Add("Text", source, "Type");

                dgvDeviceList.DataSource = null;
                dgvDeviceList.DataSource = source;
                if (dtList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of device information");
            }

        }
        private void EnableText(bool status)
        {
            txtDeviceTypeId.Enabled = status;
            txtDeviceName.Enabled = status;
            txtDeviceType.Enabled = status;
        }
        private void ClearText()
        {
            txtDeviceTypeId.Clear();
            txtDeviceName.Clear();
            txtDeviceType.Clear();
        }
        private DeviceType GetDevice()
        {
            DeviceType dt = null;
            try
            {
                dt = new DeviceType
                {
                    Id = int.Parse(txtDeviceTypeId.Text),
                    DeviceName = txtDeviceName.Text,
                    Type = txtDeviceType.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get device");
            }
            return dt;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDeviceType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDeviceTypeDetail deviceDetail = new frmDeviceTypeDetail
            {
                Text = "Add new Device",
                InsertOrUpdate = false,
                repository = dtRepo
            };
            deviceDetail.ShowDialog();
            LoadDeviceType();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmDeviceTypeDetail frmDetail = new frmDeviceTypeDetail
            {
                Text = "Update new Car",
                InsertOrUpdate = true,
                deviceInfo = GetDevice(),
                repository = dtRepo
            };
            frmDetail.ShowDialog();
            LoadDeviceType();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?",
                "Air Conditioner Management", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                int id = int.Parse(txtDeviceTypeId.Text);
                var dr = drRepo.GetDeviceByDeviceTypeId(id);
                if (dr.Count == 0)
                {
                    var dt = new DeviceType()
                    {
                        Id = id,
                    };
                    dtRepo.RemoveDevice(dt);
                    LoadDeviceType();
                }
                else
                {
                    MessageBox.Show("The device being used in the room", "Air Conditioner Management");
                }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var value = txtSearchValue.Text;
                if (rbnName.Checked)
                {
                    var device = dtRepo.GetDeviceByNameList(value);

                    source = new BindingSource();
                    source.DataSource = device;

                    dgvDeviceList.DataSource = null;
                    dgvDeviceList.DataSource = source;
                }
                if (rbnType.Checked)
                {
                    var device = dtRepo.GetDeviceByTypeList(value);

                    source = new BindingSource();
                    source.DataSource = device;

                    dgvDeviceList.DataSource = null;
                    dgvDeviceList.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search");
            }
        }

        private void frmDeviceTypeManagement_Load(object sender, EventArgs e)
        {
            LoadDeviceType();
            EnableText(false);
        }
    }
}
