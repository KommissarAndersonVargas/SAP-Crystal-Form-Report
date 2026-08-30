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
                ControlsActions.LoadData(tabControl, crystalReportViewerFullScr, crystalReportViewer1, dataStaff, FirstRep1);
            }
            catch (Exception)
            {
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
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
            ControlsActions.LoadData(tabControl, crystalReportViewerFullScr, crystalReportViewer1, dataStaff, FirstRep1);
        }

        private void LoadFast_Click(object sender, EventArgs e)
        {
            ControlsActions.LoadFast(tabControl, crystalReportViewerFullScr, crystalReportViewer1, this.dataStaff);
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

        private void UpdateDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                this.imp_InfoTableAdapter.Fill(this.dataStaff.Imp_Info);
            }
            catch (Exception)
            {
            }
        }
    }
}
