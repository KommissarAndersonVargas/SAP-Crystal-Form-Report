using Microsoft.IdentityModel.Tokens;
using SAPCrystalReports.BaseClasses.BO;
using SAPCrystalReports.BaseClasses.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPCrystalReports.FuncForms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            var name = txbName.Text.ToString();
            var login = txbLogin.Text.ToString();
            var password =  txtPassword.Text.ToString();
            var confirmPassword =  txtbConfirmPassword.Text.ToString();

            var allFieldsValid = ValidateFields();

            if (!allFieldsValid)
            {
                MessageBox.Show("Campos invalidos ou em branco");
                return;
            }

            var newUser = new User
            {
                Name = name,
                Login = login,
                Password = password,
            };

            var isValidUser = UserBO.IsValidUser(newUser);
            
            if (isValidUser)
            {
                MessageBox.Show("Usuário já existente");
                return;
            }

            var userAdded = UserBO.InsertNewUser(newUser, confirmPassword);

            if (userAdded)
            {
                MessageBox.Show("adicionado o usuário");
            }
        }

        public bool ValidateFields()
        {
            var name = txbName.Text.IsNullOrEmpty();
            var login = txbLogin.Text.IsNullOrEmpty();
            var password = txtPassword.Text.IsNullOrEmpty();
            var confirmPassword = txtbConfirmPassword.Text.IsNullOrEmpty();

            if(!name && !login && !password && !confirmPassword)
            {
                return true;
            }

            return false;
        }

    }
}
