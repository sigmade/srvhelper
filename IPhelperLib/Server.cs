using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SRVhelperLib
{

    public class Server
    {
        public string Ip { get; set; }
        public string Domen { get; set; }
        public string GetIp()
        {
            string ip = System.Net.Dns.GetHostEntry(Domen).AddressList[0].ToString();
            return ip;
        }
        public string GetServerType()
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
        public static bool CheckIfPortIsOpen(int port, string ip)
        {
            try
            {
                using (var tcpClient = new TcpClient())
                {
                    tcpClient.Connect(ip, port);
                    return true;
                }
            }
            catch (SocketException)
            {
                return false;
            }
        }
    }
}
