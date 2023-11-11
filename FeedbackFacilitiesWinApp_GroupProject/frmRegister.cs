using BusinessObject;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FeedbackFacilitiesWinApp_GroupProject
{
    public partial class frmRegister : Form
    {
        IMemberRepository memRepo = new MemberRepository();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text)
                    )
                {
                    MessageBox.Show("All fields are required!", "Register",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string regex = @"^([a-zA-Z0-9]{3,12})\d{6}@fpt.edu.vn$";
                    string email = txtEmail.Text;
                    bool isEmailValid = Regex.IsMatch(email, regex);
                    var memAccountList = memRepo.GetMembers();
                    if (isEmailValid)
                    {
                        bool flag = false;
                        for (int i = 0; i < memAccountList.Count; i++)
                        {
                            if (email.Equals(memAccountList[i].Email))
                            {
                                MessageBox.Show("The email is duplicated!", "Register",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flag = true;
                                break;
                            }
                        }
                        if (!flag)
                        {
                            int idCount = memRepo.GetMembers().Count();
                            var member = new MemberAccount()
                            {
                                Id = idCount + 1,
                                Username = txtUsername.Text,
                                Email = email,
                                Password = txtPassword.Text,
                            };
                            memRepo.Register(member);
                            MessageBox.Show("Register successfully", "Register");
                            this.Hide();
                            frmFeedback frm = new frmFeedback();
                            frm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must be FPTU Email format!", "Register",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Register");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}
