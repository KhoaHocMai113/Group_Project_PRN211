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
    public partial class frmDeviceTypeDetail : Form
    {
        public IDeviceTypeRepository repository = new DeviceTypeRepository();
        public bool InsertOrUpdate { get; set; }
        public DeviceType deviceInfo { get; set; }
        public frmDeviceTypeDetail()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    string.IsNullOrEmpty(txtDeviceName.Text) || string.IsNullOrEmpty(txtDeviceType.Text)
                    )
                {
                    MessageBox.Show("All fields are required!", "Adding Device",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var idCount = repository.GetDevices().Count();
                    var dt = new DeviceType()
                    {
                        Id = (idCount + 1),
                        DeviceName = txtDeviceName.Text,
                        Type = txtDeviceType.Text,
                    };
                    if(InsertOrUpdate == false)
                    {
                        repository.SaveDevice(dt);
                    }
                    else
                    {
                        dt.Id = deviceInfo.Id;
                        repository.UpdateDevice(dt);
                    }
                    MessageBox.Show(InsertOrUpdate == false ? "Add new device successfully" : "Update device successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Adding Device");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmDeviceTypeDetail_Load(object sender, EventArgs e)
        {
            if(InsertOrUpdate == true)
            {
                btnAdd.Text = "Update";
                txtDeviceName.Text = deviceInfo.DeviceName;
                txtDeviceType.Text = deviceInfo.Type;
            }
        }
    }
}
