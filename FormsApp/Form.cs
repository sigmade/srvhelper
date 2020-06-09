using SRVhelperLib;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    
    public partial class Form : System.Windows.Forms.Form
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
            string path = @"C:\Users\Public\ip.csv";
            return path;
        }

        public Form()
        {
            InitializeComponent();
        }

        

        Server server = new Server();
        public void IpBtn_Click(object sender, EventArgs e)
        {
            server.Domen = domenBox.Text;
            IpBox.Text = server.GetIp();                           
        }

        private void ServerBtn_Click(object sender, EventArgs e)
        {
            server.Ip = IpBox.Text;
            ServerNameLabel.Text = server.GetServerType();
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

            if (Server.CheckIfPortIsOpen(port, ip) == true)
            {
                PortLbl.Text = "Порт открыт";
                PortLbl.BackColor = System.Drawing.Color.Lime;
                PortLbl.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                PortLbl.Text = "Порт закрыт";
                PortLbl.BackColor = System.Drawing.Color.Red;
                PortLbl.ForeColor = System.Drawing.Color.Black;
                }
            });
        }

        Diagnostic diagnostic = new Diagnostic();
        private void PinBtn_Click(object sender, EventArgs e)
        { 
            diagnostic.Ip = IpBox.Text;
            ResultBox.Text = diagnostic.ExecutePing();
        }

        async private void TraceBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "Ожидайте, выполняется трассировка маршрута";
            diagnostic.Domen = domenBox.Text;
            await Task.Run(() =>
            {
                ResultBox.Text = diagnostic.ExecuteTrace();
            });
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
            try
            {
                ReadCsv();
            }
            catch
            {
                MessageBox.Show("Будет создан файл ip.csv в папке Public", "Создание файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            server.Domen = domenBox.Text;
            IpBox.Text = server.GetIp();

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText(IpPath(), CsvBox.Text);
            ReadCsv();
        }


        private void CopyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(ResultBox.Text);
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Explorer(IpPath());
        }
    }
}
