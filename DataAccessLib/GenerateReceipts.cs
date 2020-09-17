using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class GenerateReceipts
    {
        string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HostelX\Receipts\";

        private void CreateDir()
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public byte[] Generate(string htmlContent, string fileName)
        {
            CreateDir();
            string filePath = dir + fileName + ".pdf";
            var Renderer = new IronPdf.HtmlToPdf();
            Renderer.RenderHtmlAsPdf(htmlContent).SaveAs(filePath);
            byte[] bytes = System.IO.File.ReadAllBytes(filePath);
            return bytes;
        }
    }
}
