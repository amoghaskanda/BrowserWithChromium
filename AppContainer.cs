using EasyTabs;
using EasyTabs.Drawing;
using System.Threading.Tasks;

namespace BrowserWithChromium
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            //Icon = properties.Resources. img;
        }

        public override Task<TitleBarTab> CreateTab()
        {

            return new Task<TitleBarTab>(() =>
            new TitleBarTab(this)
            {
                Content = new FormMain { Text = "New Tab" }
            }
            );
        }

    }
}
