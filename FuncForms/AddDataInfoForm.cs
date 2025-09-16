using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Informe nome e sobrenome");
                return;
            }
            if (!decimal.TryParse(IncomeTxtBox.Text.Trim(), out income))
            {
                MessageBox.Show("Renda inválida");
                return;
            }

            // Sua string de conexão
            string connectionString =
                @"Data Source=DESKTOP-H0IIS6S\SQL2014;
                  Initial Catalog=My_Staff;
                  Persist Security Info=True;
                  User ID=sa;
                  Password=123456;
                  TrustServerCertificate=True";

            // Comando INSERT com parâmetros
            string insertQuery = @"
                INSERT INTO [My_Staff].[dbo].[Imp_Info]
                (First_Name, Last_Name, Date_of_birth, income, Cell_Number, Email)
                VALUES
                (@FirstName, @LastName, @DateOfBirth, @Income, @CellNumber, @Email);
            ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        // Definindo parâmetros
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
                            MessageBox.Show("Inserção realizada com sucesso!");
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma linha foi inserida.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir no banco: " + ex.Message);
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
