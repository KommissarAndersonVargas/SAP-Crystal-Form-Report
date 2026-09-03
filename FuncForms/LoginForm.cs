using SAPCrystalReports.BaseClasses.BO;
using SAPCrystalReports.BaseClasses.WinRegister;
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
            txtbLogin.Text = RegisterManagerBO.GetLoginRegister();
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

            if (loginResult)
            {
                RegisterManagerBO.SetLoginRegister(login);
                this.DialogResult = DialogResult.OK;
                this.Close();
                
            }    
        }
    }
}
