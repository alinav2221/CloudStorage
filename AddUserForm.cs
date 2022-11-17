using Ionic.Zip;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            bool valid = false;
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(email);
            }
            return valid;
        }
        public bool IsValidPassword(string password)
        {
            string pattern = @"^\S{5,}$";
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            bool valid;
            if (string.IsNullOrEmpty(password))
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(password);
            }
            return valid;
        }
        private void AddButtonOnClick(object sender, EventArgs e)
        {

            if (logTextBox.Text != "" || pasTextBox.Text != "" || emailTextBox.Text != "")
            {
                if ((System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()))
                {
                    
                    MySqlConnection con = Core.Connection(Core.Connect());
                    con.Open();
                    MySqlCommand com2 = new MySqlCommand("Select * from users where login='" + logTextBox.Text + "'", con);
                    if (com2.ExecuteScalar() == null)
                    {
                        if (IsValidEmail(emailTextBox.Text))
                        {
                            if (IsValidPassword(pasTextBox.Text))
                            {
                                string number = numberTextBox.Text.Replace("-", "");
                                number = number.Replace("(", "");
                                number = number.Replace(")", "");
                                MySqlCommand com = new MySqlCommand("Insert into `users`(`login`, `password`, `crypt`, `email`, `name`, `phone`, `idRole`) values('" + logTextBox.Text + "','" + pasTextBox.Text + "','false','" + emailTextBox.Text + "','" + nameTextBox.Text + "','" + number + "'," + 2 + ")", con);
                                com.ExecuteNonQuery();
                                FtpWebRequest request;
                                request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/", Core.ftpdomain, logTextBox.Text))) as FtpWebRequest;
                                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                                request.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                                request.UsePassive = true;
                                request.UseBinary = true;
                                request.KeepAlive = false;
                                FtpWebResponse ftpResponse = (FtpWebResponse)request.GetResponse();
                                ftpResponse.Close();
                                MailAddress from = new MailAddress("groupprojectpks@mail.ru");
                                MailAddress to = new MailAddress(emailTextBox.Text);
                                MailMessage mail = new MailMessage(from, to);
                                mail.IsBodyHtml = false;
                                mail.Subject = "Регистрация";
                                if (nameTextBox.Text == "")
                                {
                                    mail.Body = "Здавстуйте, " + logTextBox.Text + " Вас зарегестрировали в приложении Cloud Storage.  Ваши данные: \nЛогин:" + logTextBox.Text + "\nПароль:" + pasTextBox.Text;
                                }
                                else
                                {
                                    mail.Body = "Здавстуйте, " + nameTextBox.Text + " Вас зарегестрировали в приложении Cloud Storage.  Ваши данные: \nЛогин:" + logTextBox.Text + "\nПароль:" + pasTextBox.Text;

                                }
                                using (SmtpClient smtp = new SmtpClient())
                                {
                                    smtp.Host = "smtp.mail.ru";
                                    smtp.Port = 2525;
                                    smtp.Credentials = new NetworkCredential("groupprojectpks@mail.ru", "VCB3YFQp31AxTA8ZExAe");
                                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                    smtp.EnableSsl = true;
                                    smtp.Send(mail);
                                }
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Пароль задан некорректно! Пароль должен состоять более чем из 5 символов, не содержать пробелов и переносов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email задан некорректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Соединение с интернетом отсутствует");
                }
            }
            else
            {
               
                MessageBox.Show("Не заполнены обязательные поля (помечены *)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CanselButtonOnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
