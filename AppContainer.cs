using BrowserWithChromium.Properties;
using EasyTabs;
using EasyTabs.Drawing;
using System.Drawing;

namespace BrowserWithChromium
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Icon.FromHandle(new Bitmap(Resources.CompassIcon).GetHicon());
        }

        private void AppContainer_CreatingForm(object sender, EasyTabs.Model.FormEventArgs e)
        {
            e.Form = new FormMain { Text = "New Tab" };
        }
    }
}
