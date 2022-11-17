using Ionic.Zip;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class StartForm : Form
    {
   
        string nameUser = "";
        public StartForm()
        {
            Program.start = this;
            InitializeComponent();
        }

        /// <summary>
        /// Событие запуска программы
        /// </summary>
        private void StartFormOnLoad(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Manual\Intro.mkv";
            Properties.Settings.Default.offline = false;
            if (Properties.Settings.Default.login != null)
            {
                loginTextBox.Text = Properties.Settings.Default.login.Trim();
            }
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }

        }
        
        /// <summary>
        /// Проверка почты на корректность
        /// </summary>
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

        /// <summary>
        /// Проверка корректности пароля
        /// </summary>
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

        /// <summary>
        /// Переход на форму руководства пользователя
        /// </summary>
        private void ReferencePictureBoxOnClick(object sender, EventArgs e)
        {
            ManualForm manual = new ManualForm();
            manual.ShowDialog();
        }

        /// <summary>
        /// Переход на форму настроек
        /// </summary>
        private void SettingsPictureBoxOnClick(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        private void RegistrationButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                if (Properties.Settings.Default.path == "")
                {
                    MessageBox.Show("Перед началом работы необходимо выбрать путь сохранения локального архива в настройках.", "Начало работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (regLogTextBox.Text != "" || regPasTextBox.Text != "" || passwordConfirmTextBox.Text != "" || emailTextBox.Text != "")
                    {
                        if (IsValidEmail(emailTextBox.Text))
                        {
                            if (IsValidPassword(regPasTextBox.Text))
                            {
                                if (regPasTextBox.Text == passwordConfirmTextBox.Text)
                                {

                                    string number = numberTextBox.Text.Replace("-", "");
                                    number = number.Replace("(", "");
                                    number = number.Replace(")", "");
                                    nameUser = nameTextBox.Text;
                                    MySqlConnection con = Core.Connection(Core.Connect());
                                    con.Open();
                                    MySqlCommand com2 = new MySqlCommand("Select * from users where login='" + regLogTextBox.Text + "'", con);
                                    if (com2.ExecuteScalar() == null)
                                    {
                                        MySqlCommand com = new MySqlCommand("Insert into `users`(`login`, `password`, `crypt`, `email`, `name`, `phone`, `idRole`) values('" + regLogTextBox.Text + "','" + regPasTextBox.Text + "','false','" + emailTextBox.Text + "','" + nameTextBox.Text + "','" + number + "'," + 2 + ")", con);
                                        FtpWebRequest request;
                                        request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/", Core.ftpdomain, regLogTextBox.Text))) as FtpWebRequest;
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
                                        mail.Subject = "Регистрация в приложении Cloud Storage";
                                        mail.Body = "Ваш логин: " + regLogTextBox.Text + "   Ваш пароль: " + regPasTextBox.Text;
                                        using (SmtpClient smtp = new SmtpClient())
                                        {
                                            smtp.Host = "smtp.mail.ru";
                                            smtp.Port = 2525;
                                            smtp.Credentials = new NetworkCredential("groupprojectpks@mail.ru", "VCB3YFQp31AxTA8ZExAe");
                                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                            smtp.EnableSsl = true;
                                            smtp.Send(mail);
                                        }
                                        com.ExecuteNonQuery();
                                        MessageBox.Show("Вы успешно зарегестрировались! Письмо с паролем и логином отправлено на указанную почту");
                                        string zipPath = Properties.Settings.Default.path + "\\Архив.zip";
                                        string zipPath2 = regLogTextBox.Text + ".zip";
                                        ZipEntry entry;
                                        ZipFile zip = new ZipFile();
                                        ZipFile zip2 = new ZipFile(zipPath2);

                                        if (!File.Exists(zipPath))
                                            zip.Save(zipPath);
                                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                                        zip = ZipFile.Read(zipPath, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
                                        zip.Save();

                                        if (!File.Exists(zipPath2))
                                            zip2.Save(zipPath2);
                                        zip2.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                                        zip2.Save(zipPath2);
                                        using (ZipFile zip1 = ZipFile.Read(zipPath))
                                        {
                                            if (!zip1.ContainsEntry(zipPath2))
                                            {
                                                entry = zip1.AddFile(zipPath2);
                                                entry.Password = regPasTextBox.Text;
                                                zip1.Save();
                                                File.Delete(zipPath2);
                                            }
                                        }
                                        CaptchaForm captchaForm = new CaptchaForm();
                                        captchaForm.ShowDialog();
                                        if (Properties.Settings.Default.CaptchaWin == true)
                                        {
                                            MainForm mainForm = new MainForm(regLogTextBox.Text, this, regPasTextBox.Text, nameUser, "2");
                                            this.Hide();
                                            mainForm.Show();
                                        }
                                       
                                    }
                                    else
                                    {
                                        MessageBox.Show("Пользователь с таким логином уже существует");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Пароли не совпадают");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Введен некорректный пароль. Пароль должен состоять минимум из 5 символов и не содержать пробелы и переносы.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введен некорректный email");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Заполнены не все поля");
                    }
                }
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        /// <summary>
        /// Переход на форму восстановления парроля
        /// </summary>
        private void ForgotLinkLabelOnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("Восстановление пароля невозможно без соединения с интернетом. Проверьте подключение и повторите попытку.", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                infoTabControl.SelectedIndex = 0;
            }
            else
            {
                PasswordRecoveryForm passwordRecovery = new PasswordRecoveryForm();
                passwordRecovery.Show();
            }
        }

        /// <summary>
        /// Авторизация пользователя
        /// </summary>
        private void EnterButtonOnClick(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.path == "")
            {
                MessageBox.Show("Перед началом работы необходимо выбрать путь сохранения локального архива в настройках.", "Начало работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (rememberCheckBox.Checked)
                {
                    Properties.Settings.Default.login = loginTextBox.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.login = "";
                    Properties.Settings.Default.Save();
                }
                if (loginTextBox.Text != "" || passwordTextBox.Text != "")
                {
                    if (Properties.Settings.Default.offline == true)
                    {
                        string zipPath = Properties.Settings.Default.path + "\\Архив.zip";
                        string zipPath2 = loginTextBox.Text + ".zip";
                        ZipFile zip = new ZipFile();
                        ZipFile zip2 = new ZipFile();

                        if (!File.Exists(zipPath))
                            zip.Save(zipPath);
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                        zip = ZipFile.Read(zipPath, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
                        zip.Save();

                        if (!File.Exists(zipPath2))
                            zip2.Save(zipPath2);
                        zip2.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                        zip2 = ZipFile.Read(zipPath2, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
                        zip2.Save(zipPath2);

                        ZipEntry entry;
                        if (!zip.ContainsEntry(zipPath2))
                        {
                            var result = MessageBox.Show("Папка пользователя не найдена. Создать?", "", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                entry = zip.AddFile(zipPath2);
                                entry.Password = passwordTextBox.Text;
                                zip.Save();
                                File.Delete(zip2.Name);
                                MainForm mainForm = new MainForm(loginTextBox.Text, this, passwordTextBox.Text, nameUser, "2");
                                this.Hide();
                                mainForm.Show();
                            }
                        }
                        else
                        {
                            try
                            {
                                foreach (ZipEntry item in zip.Entries)
                                {
                                    if (item.FileName == loginTextBox.Text + ".zip")
                                    {
                                        item.ExtractWithPassword(Application.StartupPath, ExtractExistingFileAction.OverwriteSilently, passwordTextBox.Text);

                                    }
                                }
                                File.Delete(loginTextBox.Text + ".zip");
                                File.Delete(zip2.Name);

                                MainForm mainForm = new MainForm(loginTextBox.Text, this, passwordTextBox.Text, nameUser, "2");
                                this.Hide();
                                mainForm.Show();

                            }
                            catch (Exception ext)
                            {

                                MessageBox.Show(ext.Message);
                            }
                        }

                    }
                    else
                    {
                        if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                        {

                            if (ConfirmLoginOnline(loginTextBox.Text) != null)
                            {

                                //проверка существования папки
                                string zipPath = Properties.Settings.Default.path + "\\Архив.zip";
                                string zipPath2 = ConfirmLoginOnline(loginTextBox.Text)[0] + ".zip";
                                ZipFile zip = new ZipFile();
                                ZipFile zip2 = new ZipFile();

                                if (!File.Exists(zipPath))
                                    zip.Save(zipPath);
                                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                                zip = ZipFile.Read(zipPath, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
                                //zip.Save(zipPath);

                                if (!File.Exists(zipPath2))
                                    zip2.Save(zipPath2);
                                zip2.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                                zip2 = ZipFile.Read(zipPath2, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
                                zip2.Save(zipPath2);

                                ZipEntry entry;
                                if (!zip.ContainsEntry(zipPath2))
                                {
                                    var result = MessageBox.Show("Папка пользователя не найдена. Создать?", "", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        entry = zip.AddFile(zipPath2);
                                        entry.Password = passwordTextBox.Text;
                                        zip.Save();
                                        CaptchaForm captchaForm = new CaptchaForm();
                                        captchaForm.ShowDialog();
                                        if (Properties.Settings.Default.CaptchaWin == true)
                                        {
                                            MainForm mainForm = new MainForm(ConfirmLoginOnline(loginTextBox.Text)[0], this, passwordTextBox.Text, ConfirmLoginOnline(loginTextBox.Text)[1], ConfirmLoginOnline(loginTextBox.Text)[2]);
                                            this.Hide();
                                            mainForm.Show();

                                        }
                                    }
                                }
                                else
                                {
                                    CaptchaForm captchaForm = new CaptchaForm();
                                    captchaForm.ShowDialog();
                                    if (Properties.Settings.Default.CaptchaWin == true)
                                    {
                                        MainForm mainForm = new MainForm(ConfirmLoginOnline(loginTextBox.Text)[0], this, passwordTextBox.Text, ConfirmLoginOnline(loginTextBox.Text)[1], ConfirmLoginOnline(loginTextBox.Text)[2]);
                                        this.Hide();
                                        mainForm.Show();

                                    }
                                    
                                }
                                File.Delete(zip2.Name);
                            }
                            else
                            {
                                while (Properties.Settings.Default.CaptchaWin == false)
                                {
                                    MessageBox.Show("Неверный логин или пароль");
                                    CaptchaForm captchaForm = new CaptchaForm();
                                    captchaForm.Show();
                                }                              
                            }
                        }
                        else
                        {
                            MessageBox.Show("Соединение с интернетом отсутствует");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены");
                }
            }

        }

        /// <summary>
        /// Выбор работы автономно
        /// </summary>
        private void AutoCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (autoCheckBox.Checked)
            {
                Properties.Settings.Default.offline = true;
            }
            else
            {
                Properties.Settings.Default.offline = false;
            }
        }
        
        /// <summary>
        /// Запомнить логин
        /// </summary>
        private void RememberCheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            if (rememberCheckBox.Checked)
            {
                Properties.Settings.Default.login = loginTextBox.Text;
            }
            
        }

        /// <summary>
        /// Переход на вкладку регистрации
        /// </summary>
        private void InfoTabControlOnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (infoTabControl.SelectedIndex == 1)
            {
                if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    MessageBox.Show("Регистрация невозможна без соединения с интернетом. Проверьте подключение и повторите попытку.", "Ошибка подключения", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    infoTabControl.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Метод проверки пользователя при авторизации
        /// </summary>
        public List<string> ConfirmLoginOnline(string login)
        {
            List<string> dataUser = new List<string>();
            MySqlConnection con = Core.Connection(Core.Connect());
            con.Open();
            MySqlCommand com2 = new MySqlCommand("Select * from users where login='" + login + "' or email='" + login + "'", con);
            MySqlDataAdapter adapt = new MySqlDataAdapter(com2);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            if (com2.ExecuteScalar() != null)
            {

                if (ds.Tables[0].Rows[0].ItemArray[1].ToString() == passwordTextBox.Text)
                {

                    dataUser.Add(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                    dataUser.Add(ds.Tables[0].Rows[0].ItemArray[4].ToString());
                    dataUser.Add(ds.Tables[0].Rows[0].ItemArray[6].ToString());
                    return dataUser;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private void WindowsMediaPlayerOnPlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                this.Controls.Remove(axWindowsMediaPlayer1);
            }
        }
    }
}

