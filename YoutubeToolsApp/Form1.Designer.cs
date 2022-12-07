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
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbFfmpeg = new System.Windows.Forms.ProgressBar();
            this.llFfmpeg = new System.Windows.Forms.LinkLabel();
            this.lblStatusFfmpeg = new System.Windows.Forms.Label();
            this.btnUpdateFfmpeg = new System.Windows.Forms.Button();
            this.llYdl = new System.Windows.Forms.LinkLabel();
            this.lblStatusYdl = new System.Windows.Forms.Label();
            this.btnUpdateYdl = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbYdl = new System.Windows.Forms.ProgressBar();
            this.btnDownloadVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 65);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(924, 262);
            this.webView.TabIndex = 0;
            this.webView.ZoomFactor = 1D;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(37, 36);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(818, 23);
            this.tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(861, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(948, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "F3";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDownloadVideo);
            this.groupBox1.Controls.Add(this.tbOutput);
            this.groupBox1.Controls.Add(this.btnDownload);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 174);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Control";
            // 
            // tbOutput
            // 
            this.tbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutput.BackColor = System.Drawing.Color.Black;
            this.tbOutput.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOutput.ForeColor = System.Drawing.Color.White;
            this.tbOutput.Location = new System.Drawing.Point(6, 112);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(593, 56);
            this.tbOutput.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(6, 22);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(131, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download MP3";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pbFfmpeg);
            this.groupBox2.Controls.Add(this.llFfmpeg);
            this.groupBox2.Controls.Add(this.lblStatusFfmpeg);
            this.groupBox2.Controls.Add(this.btnUpdateFfmpeg);
            this.groupBox2.Location = new System.Drawing.Point(623, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FFMPEG";
            // 
            // pbFfmpeg
            // 
            this.pbFfmpeg.Location = new System.Drawing.Point(6, 51);
            this.pbFfmpeg.Name = "pbFfmpeg";
            this.pbFfmpeg.Size = new System.Drawing.Size(301, 23);
            this.pbFfmpeg.TabIndex = 5;
            // 
            // llFfmpeg
            // 
            this.llFfmpeg.AutoSize = true;
            this.llFfmpeg.Location = new System.Drawing.Point(81, 0);
            this.llFfmpeg.Name = "llFfmpeg";
            this.llFfmpeg.Size = new System.Drawing.Size(226, 15);
            this.llFfmpeg.TabIndex = 4;
            this.llFfmpeg.TabStop = true;
            this.llFfmpeg.Text = "https://github.com/BtbN/FFmpeg-Builds";
            this.llFfmpeg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFfmpeg_LinkClicked);
            // 
            // lblStatusFfmpeg
            // 
            this.lblStatusFfmpeg.AutoSize = true;
            this.lblStatusFfmpeg.Location = new System.Drawing.Point(157, 26);
            this.lblStatusFfmpeg.Name = "lblStatusFfmpeg";
            this.lblStatusFfmpeg.Size = new System.Drawing.Size(39, 15);
            this.lblStatusFfmpeg.TabIndex = 1;
            this.lblStatusFfmpeg.Text = "Ready";
            // 
            // btnUpdateFfmpeg
            // 
            this.btnUpdateFfmpeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateFfmpeg.Location = new System.Drawing.Point(6, 22);
            this.btnUpdateFfmpeg.Name = "btnUpdateFfmpeg";
            this.btnUpdateFfmpeg.Size = new System.Drawing.Size(145, 23);
            this.btnUpdateFfmpeg.TabIndex = 0;
            this.btnUpdateFfmpeg.Text = "Update";
            this.btnUpdateFfmpeg.UseVisualStyleBackColor = true;
            this.btnUpdateFfmpeg.Click += new System.EventHandler(this.btnUpdateFfmpeg_Click);
            // 
            // llYdl
            // 
            this.llYdl.AutoSize = true;
            this.llYdl.Location = new System.Drawing.Point(81, 0);
            this.llYdl.Name = "llYdl";
            this.llYdl.Size = new System.Drawing.Size(221, 15);
            this.llYdl.TabIndex = 5;
            this.llYdl.TabStop = true;
            this.llYdl.Text = "https://github.com/ytdl-org/youtube-dl";
            this.llYdl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llYdl_LinkClicked);
            // 
            // lblStatusYdl
            // 
            this.lblStatusYdl.AutoSize = true;
            this.lblStatusYdl.Location = new System.Drawing.Point(157, 26);
            this.lblStatusYdl.Name = "lblStatusYdl";
            this.lblStatusYdl.Size = new System.Drawing.Size(39, 15);
            this.lblStatusYdl.TabIndex = 3;
            this.lblStatusYdl.Text = "Ready";
            // 
            // btnUpdateYdl
            // 
            this.btnUpdateYdl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateYdl.Location = new System.Drawing.Point(6, 22);
            this.btnUpdateYdl.Name = "btnUpdateYdl";
            this.btnUpdateYdl.Size = new System.Drawing.Size(145, 23);
            this.btnUpdateYdl.TabIndex = 2;
            this.btnUpdateYdl.Text = "Update";
            this.btnUpdateYdl.UseVisualStyleBackColor = true;
            this.btnUpdateYdl.Click += new System.EventHandler(this.btnUpdateYdl_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pbYdl);
            this.groupBox3.Controls.Add(this.llYdl);
            this.groupBox3.Controls.Add(this.lblStatusYdl);
            this.groupBox3.Controls.Add(this.btnUpdateYdl);
            this.groupBox3.Location = new System.Drawing.Point(623, 423);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "youtube-dl";
            // 
            // pbYdl
            // 
            this.pbYdl.Location = new System.Drawing.Point(6, 51);
            this.pbYdl.Name = "pbYdl";
            this.pbYdl.Size = new System.Drawing.Size(301, 23);
            this.pbYdl.TabIndex = 6;
            // 
            // btnDownloadVideo
            // 
            this.btnDownloadVideo.Location = new System.Drawing.Point(6, 51);
            this.btnDownloadVideo.Name = "btnDownloadVideo";
            this.btnDownloadVideo.Size = new System.Drawing.Size(131, 23);
            this.btnDownloadVideo.TabIndex = 2;
            this.btnDownloadVideo.Text = "Download Video";
            this.btnDownloadVideo.UseVisualStyleBackColor = true;
            this.btnDownloadVideo.Click += new System.EventHandler(this.btnDownloadVideo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 532);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.webView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Youtube Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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