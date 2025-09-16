using Microsoft.Web.WebView2.Core;
using System.Windows.Forms;
using System;
using Microsoft.Web.WebView2.WinForms;
using SAPCrystalReports.FuncForms;
using CrystalDecisions.Windows.Forms;
using System.Drawing;

namespace SAPCrystalReports.Controls_Actions
{
    public class ControlsActions
    {
        public static async void InitializeWebView(WebView2 webView)
        {
            try
            {
                // Configurar o ambiente do WebView2
                var environment = await CoreWebView2Environment.CreateAsync(null, null, null);

                // Aguardar a inicialização
                await webView.EnsureCoreWebView2Async(environment);

                // Configurar o WebView2
                webView.CoreWebView2.Settings.AreDevToolsEnabled = true;
                webView.CoreWebView2.Settings.AreDefaultContextMenusEnabled = true;
                webView.CoreWebView2.Settings.IsZoomControlEnabled = true;


                webView.CoreWebView2.Settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36";

                // Navegar para o Copilot (Bing Chat)
                webView.CoreWebView2.Navigate("https://copilot.microsoft.com/");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar WebView2: {ex.Message}");
            }
        }

        public static void LoadReportByCode(CrystalReportViewer crystalReportViewer, DataSet.DataStaff dataStaff)
        {
            FirstRep myCrystalFile = new FirstRep();
            myCrystalFile.SetDataSource(dataStaff);
            crystalReportViewer.ReportSource = myCrystalFile;
        }

        public static void LoadFast(TabControl tabControl, CrystalReportViewer crystalReportViewerFullScr, CrystalReportViewer crystalReportViewer1, DataSet.DataStaff dataStaff)
        {
            try
            {
                var tab = VerifyFullScreenTab(tabControl);
                if (tab)
                {
                    ControlsActions.LoadReportByCode(crystalReportViewerFullScr, dataStaff);
                }
                else
                {
                    ControlsActions.LoadReportByCode(crystalReportViewer1, dataStaff);
                }
            }

            catch (Exception)
            {
            }
        }

        public static void LoadData(TabControl tabControl, CrystalReportViewer crystalReportViewerFullScr, CrystalReportViewer crystalReportViewer1, DataSet.DataStaff dataStaff, FirstRep FirstRep1)
        {
            try
            {
                var tab = VerifyFullScreenTab(tabControl);

                if (tab)
                {
                    FirstRep1.SetDataSource(dataStaff);
                    crystalReportViewerFullScr.RefreshReport();
                }
                else
                {
                    FirstRep1.SetDataSource(dataStaff);
                    crystalReportViewer1.RefreshReport();
                }

            }
            catch (Exception)
            {
            }
        }

        public static bool VerifyFullScreenTab(TabControl tabControl)
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
