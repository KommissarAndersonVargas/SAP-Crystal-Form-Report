using Microsoft.Web.WebView2.Core;
using System.Windows.Forms;
using System;
using Microsoft.Web.WebView2.WinForms;
using SAPCrystalReports.FuncForms;
using CrystalDecisions.Windows.Forms;

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
    }
}
