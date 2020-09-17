using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLib
{
    public class ImageBrowser
    {
        private string GetRandomImageName()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        public string GetImagePath()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select an Image";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "Images (*.png)|*.png";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = fdlg.FileName;
                string destinationFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HostelX\Images\" + GetRandomImageName() + ".png";
                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.StackTrace);
                }
                return destinationFile;
            }
            return "";
        }
    }
}
