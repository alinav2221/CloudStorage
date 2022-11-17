using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class CaptchaForm : Form
    {
        public string captcha_value = "";
        public CaptchaForm()
        {
            InitializeComponent();
            captcha_value = "";
            CapthaGenerate();          
        }

        private void OkButtonOnClick(object sender, EventArgs e)
        {
            if (captchaTextBox.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
                CapthaGenerate();
            }
            else
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    if (captchaTextBox.Text == captcha_value)
                    {
                        Properties.Settings.Default.CaptchaWin = true;
                        this.Close();
                    }
                    else
                    {
                        captchaTextBox.Text = "";
                        CapthaGenerate();
                    }
                }
                else
                {
                    MessageBox.Show("Соединение с интернетом отсутствует");
                    
                }
            }

        }
        public void CapthaGenerate()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://f0580448.xsph.ru/index.php");
            request.CookieContainer = new CookieContainer();
            request.Method = WebRequestMethods.Http.Get;
            var response = (HttpWebResponse)request.GetResponse();  
            Bitmap loadedBitmap = null;
            using (var responseStream = response.GetResponseStream())
            {
                loadedBitmap = new Bitmap(responseStream);
            }
            pictureBox1.Image = loadedBitmap;
            captcha_value = response.Cookies["captchaText"].Value;
            response.Close();
        }

        private void UpdateButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                CapthaGenerate();
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            Properties.Settings.Default.CaptchaWin = false;
            this.Close();
        }
    }
}
