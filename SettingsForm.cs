using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class SettingsForm : Form
    {

        public static string zipPath { get; set; }
        public static bool usezip { get; set; }
        public static bool usecloud { get; set; }
        public SettingsForm()
        {
            InitializeComponent();
            ns1.BunifuDragControl g = new ns1.BunifuDragControl();
            g.Fixed = true;
            if (Properties.Settings.Default.CryptState == true)
                cryptCheckBox.Checked = true;
            else
                cryptCheckBox.Checked = false;
            if (Properties.Settings.Default.DelOnCheckout == true)
                delExCheckBox.Checked = true;
            else
                delExCheckBox.Checked = false;
            if (Properties.Settings.Default.DelOnAdd == true)
                delAddCheckBox.Checked = true;
            else
                delAddCheckBox.Checked = false;
        }

        private void WayCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (pathCheckBox.Checked)
            {
                showPanel.Visible = true;
            }
            else
            {
                showPanel.Visible = false;
            }
        }

        private void WayButtonOnClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.path = folderBrowser.SelectedPath;
                zipPathTextBox.Text = folderBrowser.SelectedPath;
                var answer = MessageBox.Show("Путь сохранен", "", MessageBoxButtons.OKCancel);
                if (answer == DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    zipPathTextBox.Text = "";
                }
            }

        }

        private void SettingsFormOnLoad(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.offline == true)
            {
                ftpRadioButton.Enabled = false;
                allRadioButton.Enabled = false;
                zipRadioButton.Checked = true;
            }
            else
            {
                if (Properties.Settings.Default.AllAdd == true)
                {
                    allRadioButton.Checked = true;
                }
                if (Properties.Settings.Default.OnlyLocalAdd == true)
                {
                    zipRadioButton.Checked = true;
                }
                if (Properties.Settings.Default.OnlyServerAdd == true)
                {
                    ftpRadioButton.Checked = true;
                }
            }
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CryptCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (cryptCheckBox.Checked)
            {

                Properties.Settings.Default.CryptState = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.CryptState = false;
                Properties.Settings.Default.Save();
            }
        }

        private void DelAddCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (delAddCheckBox.Checked)
            {

                Properties.Settings.Default.DelOnAdd = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.DelOnAdd = false;
                Properties.Settings.Default.Save();
            }
        }

        private void DelExCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (delExCheckBox.Checked)
            {
                Properties.Settings.Default.DelOnCheckout = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.DelOnCheckout = false;
                Properties.Settings.Default.Save();
            }
        }

        private void ZipRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (zipRadioButton.Checked)
            {
                Properties.Settings.Default.OnlyLocalAdd = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.OnlyLocalAdd = false;
                Properties.Settings.Default.Save();
            }
        }

        private void FtpRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (ftpRadioButton.Checked)
            {
                Properties.Settings.Default.OnlyServerAdd = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.OnlyServerAdd = false;
                Properties.Settings.Default.Save();
            }
        }

        private void AllRadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            if (allRadioButton.Checked)
            {
                Properties.Settings.Default.AllAdd = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.AllAdd = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
