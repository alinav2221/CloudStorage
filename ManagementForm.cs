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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class ManagementForm : Form
    {
        string loginUser;
        static string zipPath = Properties.Settings.Default.path + "\\Архив.zip";
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagementFormOnLoad(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                usersDataGridView.DataSource = DataSetLoader();
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        private void AddUserButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                AddUserForm addUser = new AddUserForm();
                addUser.ShowDialog();
                usersDataGridView.DataSource = DataSetLoader();
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }
        public DataTable DataSetLoader()
        {
            MySqlConnection con = Core.Connection(Core.Connect());
            con.Open();
            MySqlCommand com2 = new MySqlCommand("Select `login`, `password`, `email`, `name`, `phone`, `idRole` from `users`", con);
            MySqlDataAdapter adapt = new MySqlDataAdapter(com2);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            return ds.Tables[0];
            con.Close();
        }


        private void UsersDataGridViewOnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowNum = e.RowIndex;
            int colNum = e.ColumnIndex;
            MySqlConnection con = Core.Connection(Core.Connect());
            con.Open();

            MySqlCommand com = new MySqlCommand("UPDATE `users` SET `" + usersDataGridView.Columns[colNum].HeaderText + "`= \"" + usersDataGridView.Rows[rowNum].Cells[colNum].Value.ToString() + "\" WHERE `login` = \"" + loginUser + "\"", con);
            com.ExecuteNonQuery();
            if (e.ColumnIndex == 0)
            {
                FtpWebRequest request;
                request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}", Core.ftpdomain, loginUser))) as FtpWebRequest;
                request.Method = WebRequestMethods.Ftp.Rename;
                request.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                request.RenameTo = usersDataGridView.Rows[rowNum].Cells[0].Value.ToString();
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;
                FtpWebResponse ftpResponse = (FtpWebResponse)request.GetResponse();
                ftpResponse.Close();
            }
            MailAddress from = new MailAddress("groupprojectpks@mail.ru");
            MailAddress to = new MailAddress(usersDataGridView.Rows[rowNum].Cells[2].Value.ToString());
            MailMessage mail = new MailMessage(from, to);
            mail.IsBodyHtml = false;
            mail.Subject = "Изменение данных в приложении Cloud Storage";
            if (usersDataGridView.Rows[rowNum].Cells[3].Value.ToString() == "")
            {
                mail.Body = "Здравствуйте, " + usersDataGridView.Rows[rowNum].Cells[0].Value.ToString() + "! Вашы данные изменены администратором приложения.  Ваши учетные данные: \nЛогин: " + usersDataGridView.Rows[rowNum].Cells[0].Value.ToString() + "\nПароль: " + usersDataGridView.Rows[rowNum].Cells[1].Value.ToString() + "\nПочта: " + usersDataGridView.Rows[rowNum].Cells[2].Value.ToString() + "\nИмя: " + usersDataGridView.Rows[rowNum].Cells[3].Value.ToString() + "\nТелефон: " + usersDataGridView.Rows[rowNum].Cells[4].Value.ToString();
            }
            else
            {
                mail.Body = "Здравствуйте, " + usersDataGridView.Rows[rowNum].Cells[3].Value.ToString() + "! Вашы данные изменены администратором приложения.  Ваши учетные данные: \nЛогин: " + usersDataGridView.Rows[rowNum].Cells[0].Value.ToString() + "\nПароль: " + usersDataGridView.Rows[rowNum].Cells[1].Value.ToString() + "\nПочта: " + usersDataGridView.Rows[rowNum].Cells[2].Value.ToString() + "\nИмя: " + usersDataGridView.Rows[rowNum].Cells[3].Value.ToString() + "\nТелефон: " + usersDataGridView.Rows[rowNum].Cells[4].Value.ToString();

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
        }

        private void UpdatePictureBoxOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                usersDataGridView.DataSource = DataSetLoader();
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        private void UsersDataGridViewOnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNum = e.RowIndex;
            loginUser = usersDataGridView.Rows[rowNum].Cells[0].Value.ToString();
        }

        public List<string> FtpFilesList(string nameDir)
        {
            FtpWebRequest request;
            request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/", Core.ftpdomain, nameDir))) as FtpWebRequest;
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.KeepAlive = false;
            request.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
            FtpWebResponse ftpResponse = (FtpWebResponse)request.GetResponse();
            var ans = new StreamReader(ftpResponse.GetResponseStream());
            List<string> files = ans.ReadToEnd().Split('\n').ToList();
            ftpResponse.Close();
            files.RemoveAt(0);
            files.RemoveAt(0);
            return files;
        }
        public void FtpFileDelete(string fileName)
        {
            try
            {
                string uri = "ftp://" + Core.ftpdomain + "/" + fileName;
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(@"ftp://" + Core.ftpdomain + "//" + fileName));

                reqFTP.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;

                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DelUserButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                try
                {
                    int r = usersDataGridView.SelectedCells[0].RowIndex;
                    MySqlConnection con = Core.Connection(Core.Connect());
                    con.Open();
                    if (FtpFilesList(loginUser)[0] != "")
                    {

                        foreach (var file in FtpFilesList(loginUser))
                        {
                            FtpFileDelete(loginUser + "//" + file);
                        }
                    }
                    FtpWebRequest request;
                    request = WebRequest.Create(new Uri(string.Format(@"ftp://{0}/{1}/", Core.ftpdomain, loginUser))) as FtpWebRequest;
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                    request.KeepAlive = false;
                    request.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                    FtpWebResponse ftpResponse = (FtpWebResponse)request.GetResponse();
                    ftpResponse.Close();
                    MySqlCommand com = new MySqlCommand("DELETE FROM `users` WHERE `login` = \"" + usersDataGridView.Rows[r].Cells[0].Value + "\"", con);
                    com.ExecuteNonQuery();
                    usersDataGridView.DataSource = DataSetLoader();

                }
                catch (Exception)
                {

                    MessageBox.Show("Сервер недоступен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }
    }
}
