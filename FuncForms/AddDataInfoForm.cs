using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SAPCrystalReports.FuncForms
{
    public partial class AddDataInfoForm : Form
    {
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
            decimal income;
            string cellNumber = CellNumberTxtBox.Text.Trim();
            string email = EmailTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show(Properties.Resources.InfoName, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(IncomeTxtBox.Text.Trim(), out income))
            {
                MessageBox.Show(Properties.Resources.InvalidIncome, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           

           
            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseConnection.GetConnection()))
                {
                    using (SqlCommand cmd = new SqlCommand(DatabaseConnection.insertQuery, conn))
                    {
                        cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100).Value = firstName;
                        cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100).Value = lastName;
                        cmd.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = dateOfBirth.Date;
                        cmd.Parameters.Add("@Income", SqlDbType.Decimal).Value = income;
                        cmd.Parameters.Add("@CellNumber", SqlDbType.VarChar, 50).Value = cellNumber;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 200).Value = email;

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(Properties.Resources.AddedDone, Properties.Resources.Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show(Properties.Resources.AnyLineFound, Properties.Resources.Warning, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
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
