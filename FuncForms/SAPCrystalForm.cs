using Microsoft.Web.WebView2.Core;
using SAPCrystalReports.Controls_Actions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAPCrystalReports.FuncForms
{
    public partial class SAPCrystalForm : Form
    {
        public SAPCrystalForm()
        {
            InitializeComponent();
        }

        private void SAPCrystalForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dataStaff.Imp_Info'. Você pode movê-la ou removê-la conforme necessário.
                this.imp_InfoTableAdapter.Fill(this.dataStaff.Imp_Info);
                Controls_Actions.ControlsActions.InitializeWebView(webView);
            }
            catch (Exception)
            {
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var newUser = new UserBuilder()
                            .Id("123")
                            .FirstName("Anderson")
                            .LastName("Vargas")
                            .DateOfBirth("10/15/2002")
                            .Income("test")
                            .CellPhoneNumber("123456789")
                            .Email("andersonvargas123@gmail.com");
            var user = new UserData();
            user.Id = "123";
            user.First_Name = "Anderson";
            user.Last_Name = "Vargas";
            user.Date_of_Birth = "Vargas";
            user.Income = "Vargas";
            user.Cell_Phone_Number = "Vargas";
            user.Email = "Vargas";
            List<UserData> a = new List<UserData>();
            a.Add(user);

            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(a);
            crystalReportViewer1.ReportSource = report;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = a;
            */
        }

       
       

        private void MaximizeFormButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.WindowState == FormWindowState.Maximized)
                {

                    this.WindowState = FormWindowState.Normal;
                    this.Size = new Size(800, 600);
                    this.CenterToScreen();
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;

                }
            }

            catch (Exception)
            {
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception)
            {
            }
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            try
            {
                var tab = VerifyFullScreenTab();

                if (tab)
                {
                    this.FirstRep1.SetDataSource(this.dataStaff);
                    this.crystalReportViewerFullScr.RefreshReport();
                }
                else
                {
                    this.FirstRep1.SetDataSource(this.dataStaff);
                    this.crystalReportViewer1.RefreshReport();
                }
              
            }
            catch (Exception)
            {
            }
        }

        private void LoadFast_Click(object sender, EventArgs e)
        {
            try
            {
                var tab = VerifyFullScreenTab();
                if (tab)
                {
                    ControlsActions.LoadReportByCode(crystalReportViewerFullScr, this.dataStaff);
                }
                else
                {
                    ControlsActions.LoadReportByCode(crystalReportViewer1, this.dataStaff);
                }
            }

            catch (Exception)
            {
            }
           
        }

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
            }
        }

        private void AddNewData_Click(object sender, EventArgs e)
        {
            try
            {
                AddDataInfoForm addData = new AddDataInfoForm();
                addData.Show();
            }
            catch (Exception)
            {
            }
        }

        public bool VerifyFullScreenTab()
        {
            if (tabControl.SelectedTab != null && tabControl.SelectedTab.Name == "FullScrenTab")
            {
                return true; // A aba está aberta/ativa
            }
            else 
            {
                return false;
            }
        }
    }
}
