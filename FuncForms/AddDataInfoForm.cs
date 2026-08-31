using SAPCrystalReports.BaseClasses.BO;
using SAPCrystalReports.Classes;
using System;
using System.Windows.Forms;

namespace SAPCrystalReports.FuncForms
{
    public partial class AddDataInfoForm : Form
    {
        public event EventHandler DadosInseridos;
        public AddDataInfoForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxtBox.Text.Trim();
            string lastName = LastNameTxtBox.Text.Trim();
            DateTime dateOfBirth = dateTimePicker.Value;
            string cellNumber = CellNumberTxtBox.Text.Trim();
            string email = EmailTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show(Properties.Resources.InfoName, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(IncomeTxtBox.Text.Trim(), out decimal income))
            {
                MessageBox.Show(Properties.Resources.InvalidIncome, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = new EmployeeData
            {
                First_Name = firstName,
                Last_Name = lastName,
                Date_of_Birth = dateOfBirth,
                Income = income,
                Cell_Phone_Number = cellNumber,
                Email = email
            };

            try
            {
                var addResult  = EmployeeBO.AddNewEmployee(user);

                if (addResult)
                {
                    DadosInseridos?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Properties.Resources.AddedDone, Properties.Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.AnyLineFound, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Properties.Resources.DataBaseError, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            FirstNameTxtBox.Text = "";
            LastNameTxtBox.Text = "";
            IncomeTxtBox.Text = "";
            CellNumberTxtBox.Text = "";
            EmailTxtBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }
    }
}
