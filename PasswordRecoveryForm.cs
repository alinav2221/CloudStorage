using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GroupProject
{
    public partial class PasswordRecoveryForm : Form
    {
        string code = new Random(DateTime.Now.Millisecond).Next(1111, 9999).ToString();
        int timerLeft = 60;

        public PasswordRecoveryForm()
        {
            InitializeComponent();
        }

        private void RecoveryButtonOnClick(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "")
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    MySqlConnection con = Core.Connection(Core.Connect());
                    con.Open();
                    MySqlCommand com2 = new MySqlCommand("Select * from users where login='" + loginTextBox.Text + "' or email='" + loginTextBox.Text + "'", con);
                    MySqlDataAdapter adapt = new MySqlDataAdapter(com2);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    if (com2.ExecuteScalar() != null)
                    {
                        SendMail("Код для восстановления аккаунта: " + code, ds.Tables[0].Rows[0].ItemArray[3].ToString());
                        MessageBox.Show("Письмо с кодом отправлено на почту");
                        recoveryButton.Enabled = false;
                        timerLeft = 60;
                        timer.Start();
                        codePanel.Visible = true;
                    }
                    else
                        MessageBox.Show("Пользователь с такими данными не найден");
                }
                else
                {
                    MessageBox.Show("Соединение с интернетом отсутствует");
                }
            }
            else
            {
                MessageBox.Show("Необходимо указать логин или email");
            }
        }

        private void ConfirmButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (code == codeTextBox.Text)
                {
                    MySqlConnection con = Core.Connection(Core.Connect());
                    con.Open();
                    MessageBox.Show("Аккаунт подтвержден. Письмо с вашим логином и паролем отправлено на почту");
                    MySqlCommand com2 = new MySqlCommand("Select * from users where login='" + loginTextBox.Text + "' or email='" + loginTextBox.Text + "'", con);
                    MySqlDataAdapter adapt = new MySqlDataAdapter(com2);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    CaptchaForm captchaForm = new CaptchaForm();
                    captchaForm.ShowDialog();
                    SendMail("Логин: " + loginTextBox.Text + " Пароль: " + ds.Tables[0].Rows[0].ItemArray[1].ToString(), ds.Tables[0].Rows[0].ItemArray[3].ToString());
                    StartForm mainForm = new StartForm();
                    mainForm.Show();
                    timer.Stop();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Код неверный. Проверьте правильность кода или повторите попытку позже.");
                }
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            if (timerLeft > 0)
            {
                timerLeft -= 1;
                infoLabel.Text = "Отправить код повторно \nможно спустя " + timerLeft + " секунд";
            }
            else
            {
                timer.Stop();
                recoveryButton.Enabled = true;
            }
        }
        public void SendMail(string mailBody, string sendTo)
        {
            MailAddress from = new MailAddress("groupprojectpks@mail.ru");
            MailAddress to = new MailAddress(sendTo);
            MailMessage mail = new MailMessage(from, to);
            mail.IsBodyHtml = false;
            mail.Subject = "Восстановление пароля в приложении Cloud Storage";
            mail.Body = mailBody;
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp.mail.ru";
                smtp.Port = 2525;
                smtp.Credentials = new NetworkCredential("groupprojectpks@mail.ru", "VCB3YFQp31AxTA8ZExAe");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
        }

        private void CloseButtonOnClicK(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
