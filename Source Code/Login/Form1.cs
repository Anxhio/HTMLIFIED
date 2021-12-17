using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<button class='button1' onclick='console.log('Javascript goes here!')'>ButtonText</button>\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<p class='text1'>Text</p>\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<input class='input1'>\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<h1 class='header1'>Header</h1>\n<h2 class='headertype2'>Header Type 2 (Tiny)</h2>\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<img src='image directory' class='img1'></img>\n"; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<code class='code1'>Code Text Here</code>\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<p><cite>2016 Election</cite> Donald J. Trump won the 2016 election in the USA</p>\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "<audio controls>" +
                "<source src='audio.mp3' type='audio/mpeg'></audio>\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UC6e6n_2FtWFKIgMFkK35r1g");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        public void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
