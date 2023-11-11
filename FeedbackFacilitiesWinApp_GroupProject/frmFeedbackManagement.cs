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
    public partial class frmFeedbackManagement : Form
    {
        IFeedbackRepository fbRepo = new FeedbackRepository();
        IStaffRepository staffRepo = new StaffRepository();
        ITaskRepository taskRepo = new TaskRepository();
        IMemberRepository memRepo = new MemberRepository();
        public frmFeedbackManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFeedbackId.Text) || string.IsNullOrEmpty(txtStaffId.Text))
                {
                    MessageBox.Show("All fields are required!", "Assigning Task",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int idCount = taskRepo.GetTasks().Count();
                    int fbId = int.Parse(txtFeedbackId.Text);
                    int staffId = int.Parse(txtStaffId.Text);
                    Boolean flag = false;

                    var taskList = taskRepo.GetTasks();
                    if (taskList.Count == 0)
                    {
                        flag = true;
                    }
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        if (taskList[i].FeedbackId.Equals(fbId))
                        {
                            MessageBox.Show("This task has been assigned to a Staff", "Assigning Task",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (flag)
                    {
                        var task = new TaskFb
                        {
                            Id = idCount + 1,
                            FeedbackId = fbId,
                            StaffId = staffId,
                        };
                        taskRepo.SaveTask(task);
                        MessageBox.Show("Assigning Task is successfully", "Assigning Task",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Feedback Management");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFeedbackId.Clear();
            txtStaffId.Clear();
            txtSenderName.Clear();
            txtSenderEmail.Clear();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog(this);
            this.Close();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
        private void dgvFeedbackList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvFeedbackList.Rows[e.RowIndex];
                int senderId = int.Parse(row.Cells[1].Value.ToString());
                var member = memRepo.GetMemberById(senderId);
                txtSenderName.Text = member.Username;
                txtSenderEmail.Text = member.Email;
                int fbId = int.Parse(row.Cells[0].Value.ToString());
                var fb = fbRepo.GetFeedbackById(fbId);
                if (fb != null && fb.Status == 0)
                {
                    txtFeedbackId.Text = fb.Id.ToString();
                }
                else
                {
                    MessageBox.Show("That feedback has been resolved", "Feedback Facilities Management");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Feedback Management");
            }
        }
        private void dgvStaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvStaffList.Rows[e.RowIndex];
                txtStaffId.Text = staffRepo.GetStaffByName(row.Cells[1].Value.ToString()).Id.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Feedback Management");
            }
        }
        private void frmFeedbackManagement_Load(object sender, EventArgs e)
        {
            var fList = fbRepo.GetFeedbacks();
            var sList = staffRepo.GetStaff();

            BindingSource sourceF = new BindingSource();
            BindingSource sourceS = new BindingSource();
            sourceF.DataSource = fList;
            sourceS.DataSource = sList;

            dgvFeedbackList.DataSource = null;
            dgvFeedbackList.DataSource = sourceF;
            dgvFeedbackList.Columns["Device"].Visible = false;
            dgvFeedbackList.Columns["SenderNavigation"].Visible = false;

            dgvStaffList.DataSource = null;
            dgvStaffList.DataSource = sourceS;
            dgvStaffList.Columns["Password"].Visible = false;

            txtFeedbackId.Enabled = false;
            txtStaffId.Enabled = false;

            dtpDay.Value = DateTime.Now;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                var value = DateTime.Parse(dtpDay.Text);

                var fb = fbRepo.GetFeedbackByDay(value);

                BindingSource source = new BindingSource();
                source.DataSource = fb;

                dgvFeedbackList.DataSource = null;
                dgvFeedbackList.DataSource = source;
                dgvFeedbackList.Columns["Device"].Visible = false;
                dgvFeedbackList.Columns["SenderNavigation"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
