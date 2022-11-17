using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
            infoWebBrowser.Navigate("file://" + Application.StartupPath + @"\Manual\StartWork.html");
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegToolStripButtonOnClick(object sender, EventArgs e)
        {
            infoWebBrowser.Navigate("file://" + Application.StartupPath + @"\Manual\Registration.html");
        }

        private void LocalToolStripButtonOnClick(object sender, EventArgs e)
        {
            infoWebBrowser.Navigate("file://" + Application.StartupPath + @"\Manual\AuthoAndRecovery.html");
        }

        private void DriveToolStripButtonOnClick(object sender, EventArgs e)
        {
            infoWebBrowser.Navigate("file://" + Application.StartupPath + @"\Manual\WorkWithFile.html");
        }
    }
}
