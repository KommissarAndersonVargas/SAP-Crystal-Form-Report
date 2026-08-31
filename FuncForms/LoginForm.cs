using SAPCrystalReports.BaseClasses.BO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SAPCrystalReports.FuncForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var users = UserBO.GetUsers();

            txtbLogin.Text = users.FirstOrDefault().Login.Trim();
            txtbLogin.SelectionLength = 0;
        }
        private void LoginForm_Shown(object sender, EventArgs e)
        {
            txtbLogin.SelectionStart = txtbLogin.Text.Length;
            txtbLogin.SelectionLength = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var login = txtbLogin.Text.Trim().ToString();
            var password = txtbpassword.Text.Trim().ToString();

            var loginResult = UserBO.ValidadeUser(login, password);

            if(loginResult)
                this.Close();
        }
    }
}
