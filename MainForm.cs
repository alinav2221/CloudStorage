using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class MainForm : Form
    {
        string login;
        string password;
        string name;
        string idRole;
        static string zipPath = Properties.Settings.Default.path + "\\Архив.zip";
        StartForm start = new StartForm();
        public MainForm(string loginTextBox, StartForm start1, string passTextBox, string nameUser, string IdRole)
        {
            InitializeComponent();
            if (Properties.Settings.Default.offline == true)
            {
                Properties.Settings.Default.OnlyLocalAdd = true;
                Properties.Settings.Default.AllAdd = false;
                Properties.Settings.Default.OnlyServerAdd = false;
                Properties.Settings.Default.DelOnCheckout = false;
                Properties.Settings.Default.DelOnAdd = false;
            }
            else
            {
                Properties.Settings.Default.AllAdd = true;
                Properties.Settings.Default.OnlyServerAdd = false;
                Properties.Settings.Default.OnlyLocalAdd = false;
                Properties.Settings.Default.DelOnCheckout = false;
                Properties.Settings.Default.DelOnAdd = false;
            }
            Properties.Settings.Default.Save();
            start = start1;
            login = loginTextBox;
            password = passTextBox;
            idRole = IdRole;
            ///разграничение прав доступа
            if (idRole == "1")
            {
                managementButton.Visible = true;
            }
            else
            {
                managementButton.Visible = false;
            }
            if (nameUser == "")
            {
                infoLabel.Text = "Пользователь " + login;
            }
            else
            {
                infoLabel.Text = "Пользователь " + nameUser;
            }
            filesListView.ShowItemToolTips = true;
            if (Properties.Settings.Default.offline)
            {
                syncButton.Visible = false;
            }
            name = login + ".zip";
        }

        private void MainFormOnLoad(object sender, EventArgs e)
        {
            LoadZip();
        }

        /// <summary>
        /// Метод отображения файлов, находящихся в папке пользователя
        /// </summary>
        public async void LoadZip()
        {
            string zipP = Application.StartupPath + "\\" + name;
            if (File.Exists(Application.StartupPath + "\\" + name))
            {
                File.Delete(Application.StartupPath + "\\" + name);
            }
            filesListView.Clear();
            await Task.Run(() => ExtractDirectory());
            GC.Collect();
            ZipFile zipExt = new ZipFile();
            if (!File.Exists(zipP))
                zipExt.Save(zipP);
            zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zipExt = ZipFile.Read(zipP, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
            zipExt.Save(zipP);
            ICollection<ZipEntry> files = zipExt.Entries;
            ImageList imageList = new ImageList { ImageSize = new Size(70, 70) };
            imageList.Images.Add(Properties.Resources.txtFile);
            imageList.Images.Add(Properties.Resources.pngFile);
            imageList.Images.Add(Properties.Resources.musicFile);
            imageList.Images.Add(Properties.Resources.videoFile);
            imageList.Images.Add(Properties.Resources.lockFile);
            imageList.Images.Add(Properties.Resources.file);
            filesListView.LargeImageList = imageList;
            File.Delete(zipP);

            foreach (var entry in files)
            {
                if (!entry.IsDirectory)
                {
                    if (entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".mp3")
                    {
                        filesListView.Items.Add(entry.FileName.Substring(entry.FileName.IndexOf('/') + 1), 2);
                    }
                    else if (entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".mp4" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".avi" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".mov" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".mkv")
                    {
                        filesListView.Items.Add(entry.FileName.Substring(entry.FileName.IndexOf('/') + 1), 3);
                    }
                    else if (entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".txt" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".doc" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".docx" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".rtf")
                    {
                        filesListView.Items.Add(entry.FileName.Substring(entry.FileName.IndexOf('/') + 1), 0);
                    }
                    else if (entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".jpg" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".png" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".bmp" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".jpeg" || entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".gif")
                    {
                        filesListView.Items.Add(entry.FileName.Substring(entry.FileName.IndexOf('/') + 1), 1);
                    }
                    else if (entry.FileName.Substring(entry.FileName.LastIndexOf('.')) == ".crypt")
                    {
                        filesListView.Items.Add(entry.FileName.Substring(entry.FileName.IndexOf('/') + 1), 4);
                    }
                    else
                    {
                        filesListView.Items.Add(entry.FileName.Substring(entry.FileName.IndexOf('/') + 1), 5);
                    }
                    filesListView.Items[filesListView.Items.Count - 1].Group = filesListView.Groups["zipListViewGroup"];

                }
                else
                {
                    filesListView.Items[filesListView.Items.Count - 1].Group = filesListView.Groups["zipListViewGroup"];
                }
            }
            if (Properties.Settings.Default.offline == false)
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    var s = FTPListDirectoryDetails(@"ftp://" + Core.ftpdomain + @"/", Core.ftplogin, Core.ftppassword, login);
                    foreach (var file in s)
                    {
                        if (file.Substring(file.LastIndexOf('.')) == ".mp3")
                        {
                            filesListView.Items.Add(file, 2);
                        }
                        else if (file.Substring(file.LastIndexOf('.')) == ".mp4" || file.Substring(file.LastIndexOf('.')) == ".avi" || file.Substring(file.LastIndexOf('.')) == ".mov" || file.Substring(file.LastIndexOf('.')) == ".mkv")
                        {
                            filesListView.Items.Add(file, 3);
                        }
                        else if (file.Substring(file.LastIndexOf('.')) == ".txt" || file.Substring(file.LastIndexOf('.')) == ".doc" || file.Substring(file.LastIndexOf('.')) == ".docx" || file.Substring(file.LastIndexOf('.')) == ".rtf")
                        {
                            filesListView.Items.Add(file, 0);
                        }
                        else if (file.Substring(file.LastIndexOf('.')) == ".jpg" || file.Substring(file.LastIndexOf('.')) == ".png" || file.Substring(file.LastIndexOf('.')) == ".bmp" || file.Substring(file.LastIndexOf('.')) == ".jpeg" || file.Substring(file.LastIndexOf('.')) == ".gif")
                        {
                            filesListView.Items.Add(file, 1);
                        }
                        else if (file.Substring(file.LastIndexOf('.')) == ".crypt")
                        {
                            filesListView.Items.Add(file, 4);
                        }
                        else
                        {
                            filesListView.Items.Add(file, 5);
                        }

                        filesListView.Items[filesListView.Items.Count - 1].Group = filesListView.Groups["cloudListViewGroup"];
                    }
                }
                else
                {
                    MessageBox.Show("Соединение с интернетом отсутствует");
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий список имен файлов, находящихся на сервере
        /// </summary>
        public List<string> FTPListDirectoryDetails(string ServerInternal, string LoginInternal, string PasswordInternal, string Directory)
        {
            List<string> ListDirectoryDetails = new List<string>();
            var ftp = (FtpWebRequest)FtpWebRequest.Create(ServerInternal + @"/" + Directory);
            ftp.Credentials = new NetworkCredential(LoginInternal, PasswordInternal);
            ftp.KeepAlive = false;
            ftp.UseBinary = true;
            ftp.Proxy = null;
            ftp.Method = WebRequestMethods.Ftp.ListDirectory;
            var response = (FtpWebResponse)ftp.GetResponse();
            var responseStream = response.GetResponseStream();
            var reader = new StreamReader(responseStream);
            while (!reader.EndOfStream)
            {
                ListDirectoryDetails.Add(reader.ReadLine());
            }
            if (ListDirectoryDetails.Count != 0)
                ListDirectoryDetails.RemoveRange(0, 2);
            responseStream.Close();
            response.Close();
            reader.Close();
            return ListDirectoryDetails;
        }

        /// <summary>
        /// Синхронизация файлов сервера и лолкальной папки
        /// </summary>
        private async void SyncButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                await Task.Run(() => ExtractDirectory());
                GC.Collect();
                string zipP = Application.StartupPath + "\\" + name;
                ICollection<ZipEntry> files;
                List<string> CloudFiles = new List<string>();
                List<string> ZipFiles = new List<string>();
                IEnumerable<string> zipNot;
                IEnumerable<string> cloudNot;
                List<string> filesNameZip = new List<string>();
                using (ZipFile zipExt = ZipFile.Read(zipP))
                {
                    if (!File.Exists(zipP))
                        zipExt.Save(zipP);
                    zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zipExt.Save(zipP);
                    files = zipExt.Entries;


                    var s = FTPListDirectoryDetails(@"ftp://" + Core.ftpdomain + @"/", Core.ftplogin, Core.ftppassword, login);
                    foreach (string f in s)
                    {
                        FtpWebRequest ftp;
                        ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Core.ftpdomain + @"/" + login + "/" + f));
                        ftp.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                        ftp.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                        var response = (FtpWebResponse)ftp.GetResponse();
                        DateTime dateTime = response.LastModified;
                        foreach (var zipFile in files)
                        {
                            if (zipFile.FileName == f)
                            {
                                if (zipFile.ModifiedTime > dateTime)
                                {
                                    DeleteFTP(Core.ftpdomain, login + "//" + f, Core.ftplogin, Core.ftppassword);
                                    zipExt.ExtractSelectedEntries(zipFile.FileName, null, Application.StartupPath, ExtractExistingFileAction.DoNotOverwrite);
                                    UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", zipFile.FileName, Core.ftplogin, Core.ftppassword);
                                    File.Delete(Application.StartupPath + "\\" + zipFile.FileName);
                                }
                                if (zipFile.ModifiedTime < dateTime)
                                {
                                    filesNameZip.Add(zipFile.FileName);
                                    DownloadFTP(Core.ftpdomain, f, Core.ftplogin, Core.ftppassword, Application.StartupPath);
                                }
                            }

                        }
                    }
                    if (filesNameZip.Count > 0)
                    {
                        foreach (string item in filesNameZip)
                        {

                            zipExt.RemoveEntry(item);
                            zipExt.Save();
                            AddFile(Application.StartupPath + "\\" + item);
                            File.Delete(Application.StartupPath + "\\" + item);
                        }


                    }

                    foreach (ListViewItem f in filesListView.Groups[1].Items)
                        CloudFiles.Add(f.Text);

                    foreach (ListViewItem f in filesListView.Groups[0].Items)
                        ZipFiles.Add(f.Text);
                    zipNot = CloudFiles.Except(ZipFiles);
                    cloudNot = ZipFiles.Except(CloudFiles);
                    if (cloudNot.Any())
                    {
                        foreach (string t in cloudNot)
                        {
                            zipExt.ExtractSelectedEntries(t, null, Application.StartupPath, ExtractExistingFileAction.OverwriteSilently);
                            UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", Application.StartupPath + @"\" + t, Core.ftplogin, Core.ftppassword);
                            File.Delete(Application.StartupPath + @"\" + t);
                        }
                    }

                }
                if (zipNot.Any())
                {
                    foreach (string t in zipNot)
                    {

                        DownloadFTP(Core.ftpdomain, t, Core.ftplogin, Core.ftppassword, Application.StartupPath);
                        AddFile(Application.StartupPath + @"\" + t);
                        File.Delete(Application.StartupPath + @"\" + t);
                    }
                }
                AddZip();
                LoadZip();
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        /// <summary>
        /// Метод загрузки файла на сервер
        /// </summary>
        public static void UploadFileToFtp(string url, string filePath, string username, string password)
        {
            var fileName = Path.GetFileName(filePath);
            var request = (FtpWebRequest)WebRequest.Create(url + fileName);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(username, password);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            using (var fileStream = File.OpenRead(filePath))
            {
                using (var requestStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);
                    requestStream.Close();
                }
            }
            var response = (FtpWebResponse)request.GetResponse();
            response.Close();
        }

        /// <summary>
        /// Метод загрузки файла с сервера в локальное хранилище 
        /// </summary>
        public void DownloadFTP(string ftpServerIP, string fileName, string ftpUserID, string ftpPassword, string to)
        {

            string path = "ftp://" + ftpServerIP + "/" + login + "/" + fileName;
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(path);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                FileStream file = File.Create(to + @"\" + fileName);
                byte[] buffer = new byte[512 * 1024];
                int read;

                while ((read = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    file.Write(buffer, 0, read);
                }
                file.Close();
                responseStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка загрузки файла!");
                return;
            }
        }

        /// <summary>
        /// Добавление файлов
        /// </summary>
        private void AddButtonOnClick(object sender, EventArgs e)
        {

            OpenFileDialog files = new OpenFileDialog();
            files.Multiselect = true;
            if (Properties.Settings.Default.AllAdd == true)
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    ExtractDirectory();
                    if (files.ShowDialog() == DialogResult.OK)
                    {
                        if (Properties.Settings.Default.CryptState)
                        {
                            foreach (var file in files.FileNames)
                            {

                                string EditFile = file.Substring(0, file.LastIndexOf("\\")) + file.Substring(file.LastIndexOf("\\"));
                                string str = login;
                                while (str.Length < 32)
                                    str += str;
                                str = str.Substring(0, 32);
                                using (var aes = new AesCryptoServiceProvider())
                                {
                                    byte[] toBytes = new byte[32];
                                    toBytes = Encoding.ASCII.GetBytes(str);
                                    str = str.Substring(0, 16);
                                    byte[] toBytes2 = new byte[16];
                                    toBytes2 = Encoding.ASCII.GetBytes(str);
                                    Array.Reverse(toBytes2);
                                    CryptFile(
                                        EditFile,
                                        EditFile,
                                        aes, toBytes, toBytes2
                                        );
                                }
                                AddFile(file + ".crypt");

                                if (!Properties.Settings.Default.offline)
                                {
                                    UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", EditFile + ".crypt", Core.ftplogin, Core.ftppassword);
                                }
                                if (File.Exists(file + ".crypt"))
                                {
                                    File.Delete(file + ".crypt");
                                }

                            }
                            AddZip();
                        }
                        else
                        {
                            foreach (var file in files.FileNames)
                            {
                                AddFile(file);
                                if (!Properties.Settings.Default.offline)
                                {
                                    string EditFile = file.Substring(0, file.LastIndexOf("\\")) + file.Substring(file.LastIndexOf("\\"));
                                    UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", EditFile, Core.ftplogin, Core.ftppassword);
                                }
                            }
                            AddZip();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Соединение с интернетом отсутствует");
                }

            }
            if (Properties.Settings.Default.OnlyLocalAdd == true)
            {
                ExtractDirectory();
                if (files.ShowDialog() == DialogResult.OK)
                {
                    if (Properties.Settings.Default.CryptState)
                    {
                        foreach (var file in files.FileNames)
                        {
                            string EditFile = file.Substring(0, file.LastIndexOf("\\")) + file.Substring(file.LastIndexOf("\\"));
                            string str = login;
                            while (str.Length < 32)
                                str += str;
                            str = str.Substring(0, 32);
                            using (var aes = new AesCryptoServiceProvider())
                            {
                                byte[] toBytes = new byte[32];
                                toBytes = Encoding.ASCII.GetBytes(str);
                                str = str.Substring(0, 16);
                                byte[] toBytes2 = new byte[16];
                                toBytes2 = Encoding.ASCII.GetBytes(str);
                                Array.Reverse(toBytes2);
                                CryptFile(
                                    EditFile,
                                    EditFile,
                                    aes, toBytes, toBytes2
                                    );
                            }

                            AddFile(file + ".crypt");
                            if (File.Exists(file + ".crypt"))
                            {
                                File.Delete(file + ".crypt");
                            }
                        }
                        AddZip();
                    }
                    else
                    {
                        foreach (var file in files.FileNames)
                        {

                            AddFile(file);
                        }
                        AddZip();
                    }
                }
            }
            if (Properties.Settings.Default.OnlyServerAdd == true)
            {
                if (files.ShowDialog() == DialogResult.OK)
                {
                    if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                    {
                        foreach (var file in files.FileNames)
                        {
                            string EditFile = file.Substring(0, file.LastIndexOf("\\")) + file.Substring(file.LastIndexOf("\\"));
                            if (Properties.Settings.Default.CryptState)
                            {
                                UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", EditFile + ".crypt", Core.ftplogin, Core.ftppassword);
                                if (File.Exists(file + ".crypt"))
                                {
                                    File.Delete(file + ".crypt");
                                }
                            }
                            else
                            {
                                UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", EditFile, Core.ftplogin, Core.ftppassword);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Соединение с интернетом отсутствует");
                    }
                }
            }
            if (Properties.Settings.Default.DelOnAdd)
                foreach (var file in files.FileNames)
                    File.Delete(file);

            LoadZip();
            
        }

        /// <summary>
        /// Экспорт запароленной папки
        /// </summary>
        public void ExtractDirectory()
        {
            using (ZipFile zip = ZipFile.Read(zipPath))
            {
                string currentDirectory = Application.StartupPath;
                var entry = zip.Entries.Where(entr => entr.FileName == name).FirstOrDefault();
                entry.ExtractWithPassword(currentDirectory, ExtractExistingFileAction.OverwriteSilently, password);
            }
        }

        /// <summary>
        /// Добавление файла в экспортированную папку
        /// </summary>
        public void AddFile(string nameFile)
        {
            string zipP = Application.StartupPath + "\\" + name;
            using (ZipFile zip = ZipFile.Read(zipP, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") }))
            {
                if (!File.Exists(zipP))
                    zip.Save(zipP);
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zip.AddFile(nameFile, "");
                zip.Save();
            }

        }

        /// <summary>
        /// Удаление запароленной папки и добавление измененной экпортированной
        /// </summary>
        public void AddZip()
        {
            string archiveName = Application.StartupPath + $"\\{name}";
            using (ZipFile zip = ZipFile.Read(zipPath))
            {
                var entry = zip.Entries.Where(entr => entr.FileName == name).FirstOrDefault();
                if (entry != null)
                {
                    zip.RemoveEntry(entry);
                    zip.Save();
                }
                zip.Password = password;
                zip.AddItem(archiveName, "");
                zip.Save();
            }

        }

        /// <summary>
        /// Экспорт файлов
        /// </summary>
        private void ExportButtonOnClick(object sender, EventArgs e)
        {
            if (filesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Файлы не выбраны!");
            }
            else
            {
                FolderBrowserDialog path = new FolderBrowserDialog();
                if (path.ShowDialog() != DialogResult.Cancel)
                {
                    Extract(path.SelectedPath);

                }
            }
        }

        /// <summary>
        /// Метод экспорта файлов
        /// </summary>
        public async void Extract(string path)
        {
            try
            {
                await Task.Run(() => ExtractDirectory());
                GC.Collect();
                string zipP = Application.StartupPath + "\\" + name;
                using (ZipFile zipExt = ZipFile.Read(zipP))
                {
                    if (!File.Exists(zipP))
                        zipExt.Save(zipP);
                    zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                    zipExt.Save(zipP);
                    for (int i = 0; i < filesListView.SelectedItems.Count; i++)
                    {
                        if (filesListView.SelectedItems[i].Group.Name == "zipListViewGroup")
                        {
                            zipExt.ExtractSelectedEntries(filesListView.SelectedItems[i].Text, "", path);
                        }
                        if (filesListView.SelectedItems[i].Group.Name == "cloudListViewGroup")
                        {
                            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                            {
                                DownloadFTP(Core.ftpdomain, filesListView.SelectedItems[i].Text, Core.ftplogin, Core.ftppassword, path);
                            }
                            else
                            {
                                MessageBox.Show("Соединение с интернетом отсутствует");
                            }
                        }
                        if (filesListView.SelectedItems[i].Text.EndsWith("crypt"))
                        {
                            string str = login;
                            while (str.Length < 32)
                                str += str;
                            str = str.Substring(0, 32);
                            using (var aes = new AesCryptoServiceProvider())
                            {
                                byte[] toBytes = new byte[32];
                                toBytes = Encoding.ASCII.GetBytes(str);
                                str = str.Substring(0, 16);
                                byte[] toBytes2 = new byte[16];
                                toBytes2 = Encoding.ASCII.GetBytes(str);
                                Array.Reverse(toBytes2);
                                if (filesListView.SelectedItems[i].Group.Name == "cloudListViewGroup")
                                {
                                    if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                                    {
                                        DecryptFile(
                                    path + "\\" + filesListView.SelectedItems[i].Text,
                                    Path.Combine(
                                        Path.GetDirectoryName(path + "\\" + filesListView.SelectedItems[i].Text),
                                        Path.GetFileNameWithoutExtension(path + "\\" + filesListView.SelectedItems[i].Text)
                                        ),
                                    aes, toBytes, toBytes2
                                    );
                                    }
                                    else
                                    {
                                        MessageBox.Show("Соединение с интернетом отсутствует");
                                    }
                                }
                                if (filesListView.SelectedItems[i].Group.Name == "zipListViewGroup")
                                    DecryptFile(
                                    path + "\\" + login + "\\" + filesListView.SelectedItems[i].Text,
                                    Path.Combine(
                                        Path.GetDirectoryName(path + "\\" + login + "\\" + filesListView.SelectedItems[i].Text),
                                        Path.GetFileNameWithoutExtension(path + "\\" + login + "\\" + filesListView.SelectedItems[i].Text)
                                        ),
                                    aes, toBytes, toBytes2
                                    );
                            }
                        }
                        if (Properties.Settings.Default.DelOnCheckout)
                        {
                            if (filesListView.SelectedItems[i].Group.Name == "zipListViewGroup")
                            {
                                zipExt.RemoveEntry(filesListView.SelectedItems[i].Text);
                                zipExt.Save();
                                AddZip();
                            }
                            else
                            {
                                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                                {
                                    DeleteFTP(Core.ftpdomain, login + "//" + filesListView.SelectedItems[i].Text, Core.ftplogin, Core.ftppassword);
                                }
                                else
                                {
                                    MessageBox.Show("Соединение с интернетом отсутствует");
                                }
                            }
                        }

                    }
                }
                LoadZip();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:\nВозможно файл уже извлечен. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Шифрование файлов
        /// </summary>
        static void CryptFile(string fileIn, string fileOut, SymmetricAlgorithm algo, byte[] rgbKey, byte[] rgbIV)
        {
            if (string.IsNullOrEmpty(fileIn))
                throw new FileNotFoundException(string.Format("Неверный путь к файлу: {0}.", fileIn));

            if (!File.Exists(fileIn))
                throw new FileNotFoundException(string.Format("Файл '{0}' не найден.", fileIn));

            byte[] buff = null;
            const string CRYPT_EXT = ".crypt";

            using (var sa = algo)
            // Создаем поток для записи зашифрованных данных
            using (var fsw = File.Open(fileOut + CRYPT_EXT, FileMode.Create, FileAccess.Write))
            // Создаем крипто-поток для записи
            using (var cs = new CryptoStream(fsw,
                sa.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write)
                )
            {
                // Читаем исходный файл
                using (var fs = File.Open(fileIn, FileMode.Open, FileAccess.Read))
                {
                    buff = new byte[fs.Length + sizeof(long)];
                    fs.Read(buff, sizeof(long), buff.Length - sizeof(long));
                    /* Записываем в первые 8 байт длину исходного файла
                     * нужно это для того чтобы, после дешифровки не было
                     * лишних данных
                     */
                    int i = 0;
                    foreach (byte @byte in BitConverter.GetBytes(fs.Length))
                        buff[i++] = @byte;
                }

                cs.Write(buff, 0, buff.Length);
                cs.Flush();
            }
            Array.Clear(rgbKey, 0, rgbKey.Length);
            Array.Clear(rgbIV, 0, rgbIV.Length);
        }

        /// <summary>
        /// Расшифровка файлов
        /// </summary>
        static void DecryptFile(string fileIn, string fileOut, SymmetricAlgorithm algo, byte[] rgbKey, byte[] rgbIV)
        {
            if (string.IsNullOrEmpty(fileIn))
                throw new FileNotFoundException(string.Format("Неверный путь к файлу: {0}.", fileIn));

            if (!File.Exists(fileIn))
                throw new FileNotFoundException(string.Format("Файл '{0}' не найден.", fileIn));

            byte[] buff = null;

            using (var sa = algo)
            // Создаем поток для чтения шифрованных данных
            using (var fsr = File.Open(fileIn, FileMode.Open, FileAccess.Read))
            // Создаем крипто-поток для чтения
            using (var cs = new CryptoStream(fsr,
                sa.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Read)
                )
            {
                // Дешифровываем исходный поток данных
                buff = new byte[fsr.Length];
                cs.Read(buff, 0, buff.Length);
                // Пишем дешифрованные данные
                using (var fsw = File.Open(fileOut, FileMode.Create, FileAccess.Write))
                {
                    // Читаем записанную длину исходного файла
                    int len = (int)BitConverter.ToInt64(buff, 0);
                    // Пишем только ту часть дешифрованных данных,
                    // которая представляет исходный файл
                    fsw.Write(buff, sizeof(long), len);
                    fsw.Flush();
                }
            }

            Array.Clear(rgbKey, 0, rgbKey.Length);
            Array.Clear(rgbIV, 0, rgbIV.Length);
        }

        /// <summary>
        /// Вывод информации о файле при наведении
        /// </summary>
        private void FilesListViewOnItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            ExtractDirectory();
            string zipP = Application.StartupPath + "\\" + name;
            ZipFile zipExt = new ZipFile();

            if (!File.Exists(zipP))
                zipExt.Save(zipP);
            zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zipExt = ZipFile.Read(zipP, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
            zipExt.Save(zipP);
            string s = "";
            if (e.Item.Group.Name == "zipListViewGroup")
            {
                s += "[ZIP] Файл: " + e.Item.Text + "\n";
                s += "Дата последнего изменения: ";
                s += zipExt[e.Item.Text].ModifiedTime + "\n";
                s += "Размер с сжатием: ";
                s += zipExt[e.Item.Text].CompressedSize + " байт\n";
                s += "Размер без сжатия: ";
                s += zipExt[e.Item.Text].UncompressedSize + " байт\n";
            }
            if (e.Item.Group.Name == "cloudListViewGroup")
            {
                FtpWebRequest ftp;
                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Core.ftpdomain + @"/" + login + "/" + e.Item.Text));
                s += "[FTP] Файл: " + e.Item.Text + "\n";
                ftp.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                ftp.Method = WebRequestMethods.Ftp.GetFileSize;
                ftp.KeepAlive = true;
                var response = (FtpWebResponse)ftp.GetResponse();
                long size = response.ContentLength;
                response.Dispose();
                response.Close();
                ftp.Abort();

                ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + Core.ftpdomain + @"/" + login + "/" + e.Item.Text));
                ftp.Credentials = new NetworkCredential(Core.ftplogin, Core.ftppassword);
                ftp.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                var response1 = (FtpWebResponse)ftp.GetResponse();
                DateTime dateTime = response1.LastModified;
                response1.Close();
                s += "Дата последнего изменения: " + dateTime.ToString() + "\n";
                s += "Размер: " + size.ToString() + " байт\n";

            }
            s += "-------------------\n";
            e.Item.ToolTipText = s;
            File.Delete(zipP);
        }

        /// <summary>
        /// Удаление файлов
        /// </summary>
        private async void DelButtonOnClick(object sender, EventArgs e)
        {

            await Task.Run(() => ExtractDirectory());
            GC.Collect();
            string zipP = Application.StartupPath + "\\" + name;
            ZipFile zipExt = new ZipFile();

            if (!File.Exists(zipP))
                zipExt.Save(zipP);
            zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zipExt = ZipFile.Read(zipP, new ReadOptions { Encoding = Encoding.GetEncoding("utf-8") });
            zipExt.Save(zipP);
            if (filesListView.SelectedItems.Count > 0)
            {
                for (int i = 0; i < filesListView.SelectedItems.Count; i++)
                {
                    if (filesListView.SelectedItems[i].Group.Name == "zipListViewGroup")
                    {
                        zipExt.RemoveEntry(filesListView.SelectedItems[i].Text);
                        zipExt.Save();
                    }
                    else
                    {
                        if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                        {
                            DeleteFTP(Core.ftpdomain, login + "//" + filesListView.SelectedItems[i].Text, Core.ftplogin, Core.ftppassword);
                        }
                        else
                        {
                            MessageBox.Show("Соединение с интернетом отсутствует");
                        }
                    }
                }
                AddZip();
                LoadZip();
            }
            else
            {
                MessageBox.Show("Файлы не выбраны");
            }
           

        }

        /// <summary>
        /// Удаление файлов сервера
        /// </summary>
        public void DeleteFTP(string ftpServerIP, string fileName, string ftpUserID, string ftpPassword)
        {
            try
            {
                string uri = "ftp://" + ftpServerIP + "/" + fileName;
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + fileName));

                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
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

        /// <summary>
        /// Закрытие приложения
        /// </summary>
        private void CloseButtonOnClick(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Вы действительно хотите выйти из программы?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Переход к форме настроек
        /// </summary>
        private void SettingsButtonOnClick(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        /// <summary>
        /// Переход к форме сведений о программе
        /// </summary>
        private void InfoButtonOnClick(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog();
        }

        /// <summary>
        /// Переход к форме авторизации/регистрации
        /// </summary>
        private void ChageButtonOnClick(object sender, EventArgs e)
        {
            foreach (TextBox item in Program.start.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            this.Close();
            start.Show();
        }

        /// <summary>
        /// Переход к форме администрирования
        /// </summary>
        private void ManagementButtonOnClick(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                ManagementForm management = new ManagementForm();
                management.ShowDialog();
            }
            else
            {
                MessageBox.Show("Соединение с интернетом отсутствует");
            }
        }

        /// <summary>
        /// Переход к руководству пользователя
        /// </summary>
        private void ManualButtonOnClick(object sender, EventArgs e)
        {
            ManualForm manual = new ManualForm();
            manual.ShowDialog();
        }
        string selectFile;

        /// <summary>
        /// Контекстное меню
        /// </summary>
        private void FilesListViewOnItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Group.Name == "zipListViewGroup")
            {
                contextMenuStrip.Items[1].Enabled = false;
                contextMenuStrip.Items[0].Enabled = true;
                filesListView.ContextMenuStrip = contextMenuStrip;
            }
            if (e.Item.Group.Name == "cloudListViewGroup")
            {
                contextMenuStrip.Items[0].Enabled = false;
                contextMenuStrip.Items[1].Enabled = true;
                filesListView.ContextMenuStrip = contextMenuStrip;
            }
            selectFile = e.Item.Text;
        }

        /// <summary>
        /// Метод загрузки выбранного файла на сервер
        /// </summary>
        private async void CloudMenuItemOnClick(object sender, EventArgs e)
        {
            string zipP = Application.StartupPath + "\\" + name;
            await Task.Run(() => ExtractDirectory());
            GC.Collect();
            using (ZipFile zipExt = ZipFile.Read(zipP))
            {
                if (!File.Exists(zipP))
                    zipExt.Save(zipP);
                zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zipExt.Save(zipP);
                var s = FTPListDirectoryDetails(@"ftp://" + Core.ftpdomain + @"/", Core.ftplogin, Core.ftppassword, login);
                foreach (string f in s)
                {
                    if (f == selectFile)
                    {
                        MessageBox.Show("Файл с таким именем уже был добавлен");
                    }
                    else
                    {
                        zipExt.ExtractSelectedEntries(selectFile, null, Application.StartupPath, ExtractExistingFileAction.DoNotOverwrite);
                        UploadFileToFtp(@"ftp://" + Core.ftpdomain + @"/" + login + @"/", selectFile, Core.ftplogin, Core.ftppassword);
                        File.Delete(Application.StartupPath + "\\" + selectFile);
                        break;
                    }
                }


            }
            if (File.Exists(zipP))
            {
                File.Delete(zipP);
            }
            LoadZip();
        }

        /// <summary>
        /// метод добавления выбранного файла в папку
        /// </summary>
        private async void ZipMenuItemOnClick(object sender, EventArgs e)
        {
            string zipP = Application.StartupPath + "\\" + name;
            await Task.Run(() => ExtractDirectory());
            GC.Collect();
            using (ZipFile zipExt = ZipFile.Read(zipP))
            {
                if (!File.Exists(zipP))
                    zipExt.Save(zipP);
                zipExt.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zipExt.Save(zipP);


                if (!zipExt.ContainsEntry(selectFile))
                {
                    DownloadFTP(Core.ftpdomain, selectFile, Core.ftplogin, Core.ftppassword, Application.StartupPath);
                    AddFile(Application.StartupPath + "\\" + selectFile);
                    File.Delete(Application.StartupPath + "\\" + selectFile);
                }
                else
                {
                    MessageBox.Show("Файл с таким именем уже был добавлен");
                }

            }
            AddZip();
            LoadZip();
        }

    }
}
