using System;

using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Расчет возраста";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = Convert.ToString(Convert.ToInt32(textBox5.Text) - Convert.ToInt32(textBox4.Text));
            label1.Text = $"Ваш возраст: {textBox6.Text}";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }
    }
}
