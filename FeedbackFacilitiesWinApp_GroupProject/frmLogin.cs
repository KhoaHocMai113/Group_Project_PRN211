using Microsoft.Extensions.Configuration;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmLogin : Form
    {
        IMemberRepository memRepo = new MemberRepository();
        IStaffRepository staffRepo = new StaffRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string txtTK = txtEmail.Text;
            string txtMK = txtPassword.Text;
            IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
            string emAD = config["AdminAccount:Email"];
            string psAD = config["AdminAccount:Password"];
            if (txtTK == "" || txtMK == "")
            {
                MessageBox.Show("Missing field!", "Feedback Facilities FPTU Management");
            }
            else
            {
                if (txtTK == emAD && txtMK == psAD)
                {
                    this.Hide();
                    frmMenu frm = new frmMenu();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    var memLog = memRepo.CheckLogin(txtTK, txtMK);
                    if (memLog != null)
                    {
                        this.Hide();
                        frmFeedback frmFeedback = new frmFeedback();
                        frmFeedback.memberId = memLog.Id.ToString();
                        frmFeedback.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        var staffLog = staffRepo.CheckLogin(txtTK, txtMK);
                        if (staffLog != null)
                        {
                            this.Hide();
                            frmStaffView frmStaffView = new frmStaffView();
                            frmStaffView.staffId = staffLog.Id.ToString();
                            frmStaffView.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("You have no pemission to do this function!",
                            "Feedback Facilities FPTU Management");
                        }
                    }
                }

            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
