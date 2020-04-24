using System;
using System.Net.Sockets;
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
            string ip;
            int port = Convert.ToInt32(textBox7.Text);
            if (checkBox1.Checked == true)
            {
                 ip = textBox6.Text;
            }
            else
            {
                ip = textBox5.Text;
            }
            
                 
            if (CheckIfPortIsOpen(port, ip) == true)
            {
                label3.Text = "Порт открыт";
            }
            else
            {
                label3.Text = "Порт закрыт";
            }
            
        }

       
    }
}
