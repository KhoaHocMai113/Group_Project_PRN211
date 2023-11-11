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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnMemberMenegement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberManagement frmMember = new frmMemberManagement();
            frmMember.ShowDialog();
            this.Close();
        }
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffManagement frmStaff = new frmStaffManagement();
            frmStaff.ShowDialog();
            this.Close();
        }
        private void btnDevice_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeviceTypeManagement frmDevice = new frmDeviceTypeManagement();
            frmDevice.ShowDialog();
            this.Close();
        }
        private void btnDeviceRoomManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeviceRoomManagement frmDeviceRoom = new frmDeviceRoomManagement();
            frmDeviceRoom.ShowDialog();
            this.Close();
        }
        private void btnFeedbackManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeedbackManagement frmFeedback = new frmFeedbackManagement();
            frmFeedback.ShowDialog();
            this.Close();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
