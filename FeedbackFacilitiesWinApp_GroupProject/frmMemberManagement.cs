using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memRepo = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        public void LoadMember()
        {
            try
            {
                var memList = memRepo.GetMembers();
                BindingSource source = new BindingSource();
                source.DataSource = memList;

                txtMemberId.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtMemberEmail.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", source, "Id");
                txtMemberName.DataBindings.Add("Text", source, "Username");
                txtMemberEmail.DataBindings.Add("Text", source, "Email");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                dgvMemberList.Columns["Password"].Visible = false;
                if (memList.Count() == 0)
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
            txtMemberId.Clear();
            txtMemberName.Clear();
            txtMemberEmail.Clear();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMember();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you really want to delete this record?",
                "Member Management", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                var mem = new MemberAccount()
                {
                    Id = int.Parse(txtMemberId.Text),
                };
                memRepo.RemoveMember(mem);
                LoadMember();
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
                    var device = memRepo.GetMemberByNameList(value);

                    source = new BindingSource();
                    source.DataSource = device;

                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                }
                if (rbnEmail.Checked)
                {
                    var device = memRepo.GetMemberByEmailList(value);

                    source = new BindingSource();
                    source.DataSource = device;

                    dgvMemberList.DataSource = null;
                    dgvMemberList.DataSource = source;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Search");
            }
        }
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            LoadMember();
        }
    }
}
