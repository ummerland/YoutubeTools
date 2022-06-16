using System.IO.Compression;
using System.Net;
using System.Web;
using YoutubeToolsApp.Data;

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


        private void llFfmpeg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32", "url.dll,FileProtocolHandler https://github.com/BtbN/FFmpeg-Builds");
        }

        private void llYdl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32", "url.dll,FileProtocolHandler https://github.com/ytdl-org/youtube-dl");
        }

        private async void btnUpdateFfmpeg_Click(object sender, EventArgs e)
        {
            btnUpdateFfmpeg.Enabled = false;

            var downloadFileUrl = "https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip";
            var destinationFilePath = Path.GetFullPath("ffmpeg-master-latest-win64-gpl.zip");
            var destinationFolder = Path.GetDirectoryName(destinationFilePath);

            if (destinationFolder != null && Directory.Exists(destinationFolder))
            {
                using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePath))
                {
                    client.ProgressChanged += (totalFileSize, totalBytesDownloaded, progressPercentage) =>
                    {
                        pbFfmpeg.Value = Convert.ToInt32(progressPercentage ?? 0);
                        lblStatusFfmpeg.Text = $"Downloading... ({totalBytesDownloaded / 1048576}/{totalFileSize / 1048576}MiB)";
                    };
                    await client.StartDownload();
                }

                pbFfmpeg.Value = 0;
                lblStatusFfmpeg.Text = $"Extracting...";

                ZipFile.ExtractToDirectory(destinationFilePath, destinationFolder);
                var SrcFfmpegFilePath = destinationFolder + @"\ffmpeg-master-latest-win64-gpl\bin\ffmpeg.exe";
                var TarFfmpegFilePath = destinationFolder + @"\ffmpeg.exe";
                if (File.Exists(SrcFfmpegFilePath))
                {
                    File.Copy(SrcFfmpegFilePath, TarFfmpegFilePath);

                    pbFfmpeg.Value = 0;
                    lblStatusFfmpeg.Text = $"Done [OK]";
                    lblStatusFfmpeg.ForeColor = Color.Green;
                }
                else
                {
                    pbFfmpeg.Value = 0;
                    lblStatusFfmpeg.Text = $"Failed";
                    lblStatusFfmpeg.ForeColor = Color.Red;
                }
            }
            else
            {
                pbFfmpeg.Value = 0;
                lblStatusFfmpeg.Text = $"Failed";
                lblStatusFfmpeg.ForeColor = Color.Red;
            }

            btnUpdateFfmpeg.Enabled = true;
        }

        private async void btnUpdateYdl_Click(object sender, EventArgs e)
        {
            btnUpdateYdl.Enabled = false;

            var downloadFileUrl = "https://github.com/ytdl-org/youtube-dl/releases/download/2021.12.17/youtube-dl.exe";
            var destinationFilePath = Path.GetFullPath("youtube-dl.exe");
            using (var client = new HttpClientDownloadWithProgress(downloadFileUrl, destinationFilePath))
            {
                client.ProgressChanged += (totalFileSize, totalBytesDownloaded, progressPercentage) =>
                {
                    pbYdl.Value = Convert.ToInt32(progressPercentage ?? 0);
                    lblStatusYdl.Text = $"Downloading... ({totalBytesDownloaded / 1048576}/{totalFileSize / 1048576}MiB)";
                };
                await client.StartDownload();
            }

            if (File.Exists(destinationFilePath))
            {
                pbYdl.Value = 0;
                lblStatusYdl.Text = $"Done [OK]";
                lblStatusYdl.ForeColor = Color.Green;
            }
            else
            {
                pbYdl.Value = 0;
                lblStatusYdl.Text = $"Failed";
                lblStatusYdl.ForeColor = Color.Red;
            }

            btnUpdateYdl.Enabled = true;
        }
    }
}