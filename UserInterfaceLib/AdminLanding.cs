using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLib;

namespace UserInterfaceLib
{
    public partial class AdminLanding : Form
    {
        Admin admin;
        public AdminLanding(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void AdminLanding_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
