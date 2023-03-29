using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzradaWebPreglednika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.google.com");
        }
        private void bntHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtBoxSearch.Text);
        }

        private void bntBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void bntForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void bntRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void bntTabs_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New Tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webBrowser = new WebBrowser();
            webBrowser.Parent = tabpage;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate("www.google.com");
        }

        private void bntBookmark_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(webBrowser1.Url.ToString());
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(listBox1.SelectedItem.ToString());
        }
    }
}
