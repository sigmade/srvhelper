using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Hosting;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    
    public partial class Form1 : Form
    {

        public string IpInfo() // считывает ip с поля
        {
            string ip = IpBox.Text;
            return ip;
        }

        public string DmnInfo() // считывает domen с поля
        {
            string dmn = domenBox.Text;
            return dmn;
        }
        

        public string IpPath() // путь файла
        {
            string path = @"C:\Users\PC501\Source\Repos\IPhelper\FormsApp\bin\Debug\ip.csv";
            return path;
        }

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
        public void IpBtn_Click(object sender, EventArgs e)
        {
            //textBox6.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text));
            //label1.Text = $"Ваш возраст: {textBox6.Text}";
            string ip = System.Net.Dns.GetHostEntry(domenBox.Text).AddressList[0].ToString();

            IpBox.Text = ip;
            label1.Text = $"IP адрес домена {ip}";
                        
        }


        private void domenBox_Click(object sender, EventArgs e) // очищает поле при клике
        {
            domenBox.Text = "";
        }

        async private void PortBtn_Click(object sender, EventArgs e)
        {
            PortLbl.Text = "Ожидание ...";
            PortLbl.BackColor = System.Drawing.Color.Empty;
            
            await Task.Run(() =>
            {
            string ip = "";
            int port = Convert.ToInt32(PortBox.Text);
            if (String.IsNullOrWhiteSpace(IpBox.Text) == true && String.IsNullOrWhiteSpace(IpPortBox.Text) == true)
                {
                    MessageBox.Show("Введите IP адрес", "Пустое поле", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PortLbl.Text = "";
                    PortLbl.BackColor = System.Drawing.Color.Empty;
                }
            else if (checkBox1.Checked == true && String.IsNullOrWhiteSpace(IpBox.Text) == false)
            {
                ip = IpInfo();
            }

            else if (checkBox1.Checked == false && String.IsNullOrWhiteSpace(IpPortBox.Text) == false)
            {
                ip = IpPortBox.Text;
            }

            if (CheckIfPortIsOpen(port, ip) == true)
            {
                PortLbl.Text = "Порт открыт";
                PortLbl.BackColor = System.Drawing.Color.Lime;
            }
            //else if (!String.IsNullOrWhiteSpace(IpPortBox.Text) | checkBox1.Checked == true)
            else
            {
                PortLbl.Text = "Порт закрыт";
                PortLbl.BackColor = System.Drawing.Color.Red;
            }
            });
        }

        private void PinBtn_Click(object sender, EventArgs e)
        {
            // Cmd($"ping {IpInfo()}");
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c chcp 65001 & ping {IpInfo()}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });


            label3.Text = process.StandardOutput.ReadToEnd();

        }

        private void TraceBtn_Click(object sender, EventArgs e)
        {
            // Cmd($"tracert {DmnInfo()}");
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c chcp 65001 & tracert {DmnInfo()}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });


            label3.Text = process.StandardOutput.ReadToEnd();
        }

        public static void Cmd(string line)
        {
            
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/k {line}",
                WindowStyle = ProcessWindowStyle.Normal
            });
            

        }
        public static void Explorer(string line)
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer",
                Arguments = $"/n, /select, {line}"
            });


        }

        private void ServBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string url = $"http://{IpInfo()}";
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                string method;
                method = myHttpWebResponse.Method;
                ServLbl.Text = myHttpWebResponse.Server;
                myHttpWebResponse.Close();
            }
            catch
            {
                MessageBox.Show("Настройки сервера не позволяют получить информацию о нем", "Сервер не передает информацию", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public static void Cnsl(string d, string i)
        {
            

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    
                    FileName = @"C:\Users\PC501\Source\Repos\IPhelper\Cons\bin\Debug\Cons.exe",
                    Arguments = $"{d}, {i}",
                    WindowStyle = ProcessWindowStyle.Normal
                });
            }
            catch { }

        }

        private void CnslBtn_Click(object sender, EventArgs e)
        {
          Cnsl(DmnInfo(), IpInfo());
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string line = $"{DmnInfo()}, {IpInfo()}";
            using (StreamWriter stream = new StreamWriter(IpPath(), true))
            {
                stream.WriteLine(line);
            }
            ReadCsv();
        }

        public void ReadCsv()
        {
            CsvBox.Text = File.ReadAllText(IpPath());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCsv();
            Pathlabel.Text = IpPath();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(IpPath(), CsvBox.Text);
            ReadCsv();
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(CsvBox.Text);
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Explorer(IpPath());
        }



        //async private void ProgressBar()
        //{

        //    while (progressBar1.Value != 100)
        //    {
        //        progressBar1.Value++;
        //        await Task.Delay(10);
        //    }
        //    Close();

        //}
    }
}
