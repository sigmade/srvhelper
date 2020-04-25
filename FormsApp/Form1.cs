using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Hosting;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CheckIfPortIsOpen(int port, string ip)
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
        private void button2_Click(object sender, EventArgs e)
        {
            //textBox6.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text));
            //label1.Text = $"Ваш возраст: {textBox6.Text}";
            string ip = System.Net.Dns.GetHostEntry(textBox4.Text).AddressList[0].ToString();

            textBox6.Text = ip;
            label1.Text = $"IP адрес домена {ip}";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ip = "";
            int port = Convert.ToInt32(textBox7.Text);
            if (checkBox1.Checked == true)
            {
                ip = textBox6.Text;
            }
            else if (String.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Введите IP адрес", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label3.Text = "";
                label3.BackColor = System.Drawing.Color.Empty;
            }
            else
            {
                ip = textBox5.Text;
            }

            if (CheckIfPortIsOpen(port, ip) == true)
            {
                label3.Text = "Порт открыт";
                label3.BackColor = System.Drawing.Color.Lime;
            }
            else if (!String.IsNullOrWhiteSpace(textBox5.Text) | checkBox1.Checked == true)
            {
                label3.Text = "Порт закрыт";
                label3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string pinIp = textBox6.Text;
            Cmd($"ping {pinIp}");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dmn = textBox4.Text;
            Cmd($"tracert {dmn}");

        }

        public static void Cmd(string line)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/k {line}",
                    WindowStyle = ProcessWindowStyle.Normal
                });
            }
            catch { }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = $"http://{textBox6.Text}";
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            string method;
            method = myHttpWebResponse.Method;
            label8.Text = myHttpWebResponse.Server;
            
            myHttpWebResponse.Close();
        }
    }
}
