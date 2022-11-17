using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public static class Core
    {
        public static string login;
        public static MySqlConnectionStringBuilder str_connect { get; set; }
        public static string  ftpdomain = "f0580448.xsph.ru";
        public static string  ftppassword = "uvedtuedad";
        public static string  ftplogin = "f0580448";
        static MySqlCommand com;
        static MySqlConnection con;

        public static MySqlConnectionStringBuilder Connect()
        {
            ns1.BunifuDragControl g = new ns1.BunifuDragControl();
            g.Fixed = true;
            str_connect = new MySqlConnectionStringBuilder();
            str_connect.Server = "f0580448.xsph.ru";
            str_connect.UserID = "f0580448_groupProject";
            str_connect.Password = "123Abc";
            str_connect.SslMode = MySqlSslMode.None;
            str_connect.Database = "f0580448_groupProject";
            str_connect.PersistSecurityInfo = true;


            return str_connect;
        }
        
        public static MySqlConnection Connection(MySqlConnectionStringBuilder conString)
        {
            con = new MySqlConnection(conString.ToString());
            return con;
        }
    }
}
