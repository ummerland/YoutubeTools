using System.Web;

namespace YoutubeToolsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate($"https://www.youtube.com/results?search_query={HttpUtility.HtmlEncode(tbSearch.Text)}");
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView.EnsureCoreWebView2Async();
        }
    }
}