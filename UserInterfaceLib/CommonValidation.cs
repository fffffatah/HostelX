using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLib
{
    class CommonValidation
    {
        public bool IsValidEmail(string email)
        {
            try
            {
                return (new MailAddress(email).Address == email);
            }
            catch
            {
                return false;
            }
        }

        public void CheckForInternetConnection(Form form)
        {
            bool flag;
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    flag = true;
            }
            catch
            {
                flag = false;
            }
            if (!flag)
            {
                if (MessageBox.Show("No Internet Connection Detected!\nThe Application Will Exit.", "Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    form.Dispose();
                    Application.Exit();
                    Environment.Exit(0);
                }
            }
        }
    }
}
