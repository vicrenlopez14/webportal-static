using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Popups;

namespace ProFind.Lib.Global.Services
{
    public class ReportDownloader
    {
        private const string BASEURL = "https://localhost:7119/Report";
        private static WebClient client = new WebClient();

        #region endpoints
        // Download admins report
        public static async void RegisteredAdmins() => await DownloadReport("RegisteredAdmins");

        public static async void RegisteredProfessionals() => await DownloadReport("RegisteredProfessionals");

        public static async void RegisteredClients() => await DownloadReport("RegisteredClients");

        public static async void CreatedProjects() => await DownloadReport("CreatedProjects");

        #endregion

        #region generation
        private static async Task DownloadReport(string subpath)
        {
            try
            {
                string htmlCode = client.DownloadString($"{BASEURL}/{subpath}");

                GenerateAndSave(htmlCode);
            }
            catch (Exception ex)
            {
                // Message dialog
                await new MessageDialog("An error has ocurred on the report generation. Please try again later.").ShowAsync();

                Console.WriteLine(ex.Message);
            }
        }

        private static void GenerateAndSave(string html)
        {
            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(html);
            doc.Save("report.pdf");
            doc.Close();
        }
        #endregion
    }
}
