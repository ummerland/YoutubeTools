namespace YoutubeToolsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            tbSearch = new TextBox();
            btnSearch = new Button();
            statusStrip1 = new StatusStrip();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnDownloadVideo = new Button();
            tbOutput = new TextBox();
            btnDownload = new Button();
            groupBox2 = new GroupBox();
            pbFfmpeg = new ProgressBar();
            llFfmpeg = new LinkLabel();
            lblStatusFfmpeg = new Label();
            btnUpdateFfmpeg = new Button();
            llYdl = new LinkLabel();
            lblStatusYdl = new Label();
            btnUpdateYdl = new Button();
            groupBox3 = new GroupBox();
            pbYdl = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(12, 65);
            webView.Name = "webView";
            webView.Size = new Size(924, 262);
            webView.TabIndex = 0;
            webView.ZoomFactor = 1D;
            // 
            // tbSearch
            // 
            tbSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSearch.Location = new Point(37, 36);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(818, 23);
            tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(861, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 510);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(948, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(948, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 5;
            label1.Text = "F3";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDownloadVideo);
            groupBox1.Controls.Add(tbOutput);
            groupBox1.Controls.Add(btnDownload);
            groupBox1.Location = new Point(12, 333);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 174);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Download Control";
            // 
            // btnDownloadVideo
            // 
            btnDownloadVideo.Location = new Point(6, 51);
            btnDownloadVideo.Name = "btnDownloadVideo";
            btnDownloadVideo.Size = new Size(131, 23);
            btnDownloadVideo.TabIndex = 2;
            btnDownloadVideo.Text = "Download Video";
            btnDownloadVideo.UseVisualStyleBackColor = true;
            btnDownloadVideo.Click += btnDownloadVideo_Click;
            // 
            // tbOutput
            // 
            tbOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbOutput.BackColor = Color.Black;
            tbOutput.Font = new Font("Lucida Console", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbOutput.ForeColor = Color.White;
            tbOutput.Location = new Point(6, 112);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ScrollBars = ScrollBars.Vertical;
            tbOutput.Size = new Size(593, 56);
            tbOutput.TabIndex = 1;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(6, 22);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(131, 23);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download MP3";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(pbFfmpeg);
            groupBox2.Controls.Add(llFfmpeg);
            groupBox2.Controls.Add(lblStatusFfmpeg);
            groupBox2.Controls.Add(btnUpdateFfmpeg);
            groupBox2.Location = new Point(623, 333);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(313, 84);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "FFMPEG";
            // 
            // pbFfmpeg
            // 
            pbFfmpeg.Location = new Point(6, 51);
            pbFfmpeg.Name = "pbFfmpeg";
            pbFfmpeg.Size = new Size(301, 23);
            pbFfmpeg.TabIndex = 5;
            // 
            // llFfmpeg
            // 
            llFfmpeg.AutoSize = true;
            llFfmpeg.Location = new Point(81, 0);
            llFfmpeg.Name = "llFfmpeg";
            llFfmpeg.Size = new Size(226, 15);
            llFfmpeg.TabIndex = 4;
            llFfmpeg.TabStop = true;
            llFfmpeg.Text = "https://github.com/BtbN/FFmpeg-Builds";
            llFfmpeg.LinkClicked += llFfmpeg_LinkClicked;
            // 
            // lblStatusFfmpeg
            // 
            lblStatusFfmpeg.AutoSize = true;
            lblStatusFfmpeg.Location = new Point(157, 26);
            lblStatusFfmpeg.Name = "lblStatusFfmpeg";
            lblStatusFfmpeg.Size = new Size(39, 15);
            lblStatusFfmpeg.TabIndex = 1;
            lblStatusFfmpeg.Text = "Ready";
            // 
            // btnUpdateFfmpeg
            // 
            btnUpdateFfmpeg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateFfmpeg.Location = new Point(6, 22);
            btnUpdateFfmpeg.Name = "btnUpdateFfmpeg";
            btnUpdateFfmpeg.Size = new Size(145, 23);
            btnUpdateFfmpeg.TabIndex = 0;
            btnUpdateFfmpeg.Text = "Update";
            btnUpdateFfmpeg.UseVisualStyleBackColor = true;
            btnUpdateFfmpeg.Click += btnUpdateFfmpeg_Click;
            // 
            // llYdl
            // 
            llYdl.AutoSize = true;
            llYdl.Location = new Point(81, 0);
            llYdl.Name = "llYdl";
            llYdl.Size = new Size(224, 15);
            llYdl.TabIndex = 5;
            llYdl.TabStop = true;
            llYdl.Text = "https://github.com/ytdl-org/ytdl-nightly";
            llYdl.LinkClicked += llYdl_LinkClicked;
            // 
            // lblStatusYdl
            // 
            lblStatusYdl.AutoSize = true;
            lblStatusYdl.Location = new Point(157, 26);
            lblStatusYdl.Name = "lblStatusYdl";
            lblStatusYdl.Size = new Size(39, 15);
            lblStatusYdl.TabIndex = 3;
            lblStatusYdl.Text = "Ready";
            // 
            // btnUpdateYdl
            // 
            btnUpdateYdl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUpdateYdl.Location = new Point(6, 22);
            btnUpdateYdl.Name = "btnUpdateYdl";
            btnUpdateYdl.Size = new Size(145, 23);
            btnUpdateYdl.TabIndex = 2;
            btnUpdateYdl.Text = "Update";
            btnUpdateYdl.UseVisualStyleBackColor = true;
            btnUpdateYdl.Click += btnUpdateYdl_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Controls.Add(pbYdl);
            groupBox3.Controls.Add(llYdl);
            groupBox3.Controls.Add(lblStatusYdl);
            groupBox3.Controls.Add(btnUpdateYdl);
            groupBox3.Location = new Point(623, 423);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(313, 84);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "youtube-dl";
            // 
            // pbYdl
            // 
            pbYdl.Location = new Point(6, 51);
            pbYdl.Name = "pbYdl";
            pbYdl.Size = new Size(301, 23);
            pbYdl.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 532);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(webView);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Youtube Tools";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private TextBox tbSearch;
        private Button btnSearch;
        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnDownload;
        private GroupBox groupBox2;
        private Button btnUpdateFfmpeg;
        private LinkLabel llYdl;
        private LinkLabel llFfmpeg;
        private Label lblStatusYdl;
        private Button btnUpdateYdl;
        private Label lblStatusFfmpeg;
        private GroupBox groupBox3;
        private ProgressBar pbFfmpeg;
        private ProgressBar pbYdl;
        private TextBox tbOutput;
        private Button btnDownloadVideo;
    }
}