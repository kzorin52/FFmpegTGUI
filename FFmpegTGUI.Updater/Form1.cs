using Newtonsoft.Json.Linq;
using SevenZip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alert.Alert;

namespace FFmpegTGUI.Updater
{
    public partial class Form1 : Form
    {
        WebClient wcprog = new WebClient();
        private string version;
        private string line;
        private string link;
        private string filename;

        public Form1()
        {
            InitializeComponent();
            TextLabel.Text = Text;

            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12
                | SecurityProtocolType.Tls11
                | SecurityProtocolType.Tls
                | SecurityProtocolType.Tls13
                | SecurityProtocolType.Ssl3;
        }

        void guna2Button1_Click(object sender, EventArgs e)
        {
            wcprog.DownloadProgressChanged += (s, progress) => progressbar.Value = progress.ProgressPercentage;
            wcprog.DownloadFileCompleted += (s, ee) => { AlertShow("Completed!", AlertType.Success); Process.Start("FFmpegTGUI.exe"); Environment.Exit(0); };

            wcprog.DownloadFileAsync(new Uri(link), filename);
        }

        void AlertShow(string Message, AlertType Type)
        {
            new Alert.Alert().ShowAlert(Message, Type);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                line = new WebClient().DownloadString("https://pastebin.com/raw/gjUwasYB");

                var obj = JObject.Parse(line);
                version = obj["FFmpeg-TGUI-Version"].ToString();
                link = obj["FFmpeg-TGUI-LastVersion-link"].ToString();

                gunaLabel1.Text = "Last Version - " + version;
                filename = "FFmpegTGUI.exe";
            });
        }


    }
}
