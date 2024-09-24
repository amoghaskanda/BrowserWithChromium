using BrowserWithChromium.Properties;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrowserWithChromium
{
    public partial class FormMain : Form
    {
        ChromiumWebBrowser browser;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(textUrl.Text);
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);
            Icon = Icon.FromHandle(new Bitmap(Resources.CompassIcon).GetHicon());
        }

        private void ButtonGo_Click(object sender, EventArgs e)
        {
            browser.Load(textUrl.Text);
        }

        private void TextUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                browser.Load(textUrl.Text);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            browser.Reload();
        }
    }
}
