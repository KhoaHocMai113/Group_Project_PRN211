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
    public partial class frmStaffManagement : Form
    {
        IStaffRepository staffRepo = new StaffRepository();
        ITaskRepository taskRepo = new TaskRepository();
        IFeedbackRepository fbRepo = new FeedbackRepository();
        BindingSource source;
        public frmStaffManagement()
        {
            InitializeComponent();
        }
        public void LoadStaff()
        {
            try
            {
                var staffList = staffRepo.GetStaff();
                BindingSource source = new BindingSource();
                source.DataSource = staffList;

                txtStaffId.DataBindings.Clear();
                txtStaffName.DataBindings.Clear();
                txtStaffEmail.DataBindings.Clear();

                txtStaffId.DataBindings.Add("Text", source, "Id");
                txtStaffName.DataBindings.Add("Text", source, "Username");
                txtStaffEmail.DataBindings.Add("Text", source, "Email");

                dgvStaffList.DataSource = null;
                dgvStaffList.DataSource = source;

                dgvStaffList.Columns["Password"].Visible = false;
                if (staffList.Count() == 0)
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
        private void ClearText()
        {
            txtStaffId.Clear();
            txtStaffName.Clear();
            txtStaffEmail.Clear();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?",
                "Staff Management", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                int id = int.Parse(txtStaffId.Text);
                var listTask = taskRepo.GetTaskByStaffId(id);
                int count = 0;
                foreach (var item in listTask)
                {
                    var fb = fbRepo.GetFeedbackById(item.FeedbackId);
                    if (fb.Status == 1)
                    {
                        count++;
                    }
                }
                if (count == listTask.Count)
                {
                    var staff = new Staff()
                    {
                        Id = id,
                    };
                    staffRepo.RemoveStaff(staff);
                    LoadStaff();
                }
                else
                {
                    MessageBox.Show("The Staff is at work", "Staff Management");
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
                    var device = staffRepo.GetStaffByNameList(value);

                    source = new BindingSource();
                    source.DataSource = device;

                    dgvStaffList.DataSource = null;
                    dgvStaffList.DataSource = source;
                }
                if (rbnEmail.Checked)
                {
                    var device = staffRepo.GetStaffByEmailList(value);

                    source = new BindingSource();
                    source.DataSource = device;

                    dgvStaffList.DataSource = null;
                    dgvStaffList.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search");
            }
        }
        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }
    }
}
