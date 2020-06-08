using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPhelperLib
{

    public class Info
    {
        public string Ip { get; set; }
        public string Domen { get; set; }
        public string GetIp()
        {
            string ip = System.Net.Dns.GetHostEntry(Domen).AddressList[0].ToString();
            return ip;
        }
        public string GetServerName()
        {
            string serverName = "Упс..("; 
            try
            {
                string url = $"http://{Ip}";
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                string method;
                method = myHttpWebResponse.Method;
                serverName = myHttpWebResponse.Server;
                myHttpWebResponse.Close();
                
            }
            catch
            {
                MessageBox.Show("Настройки сервера не позволяют получить информацию о нем", "Сервер не передает информацию", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return serverName;
        }
    }
}
