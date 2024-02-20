using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benim_Tarayicim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(panel3.Visible) panel3.Visible = false;
            else panel3.Visible = true;
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
