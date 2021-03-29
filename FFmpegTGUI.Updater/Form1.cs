using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SevenZip;
using static Alert.Alert;

namespace FFmpegTGUI.Updater
{
    public partial class Form1 : Form
    {
        private string version;
        private string line;
        private string link;
        private string filename;

        public Form1()
        {
            InitializeComponent();
            TextLabel.Text = Text;  
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls |SecurityProtocolType.Tls13 | SecurityProtocolType.Ssl3;
        }

          void guna2Button1_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls |SecurityProtocolType.Tls13 | SecurityProtocolType.Ssl3;
            Downloader.Url = link;


        }
   
        void AlertShow(string Message, AlertType Type)
        {
            new Alert.Alert().ShowAlert(Message, Type);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (WebClient wcstring = new WebClient())
            {
                line = wcstring.DownloadString("https://raw.githubusercontent.com/kzorin52/JSON-UPDATERS/master/db.json");
            }

            JObject obj = JObject.Parse(line);
            var FFmpegTGUIline =  JObject.Parse(obj["FFmpegTGUI"].ToString());
            version = FFmpegTGUIline["FFmpeg-TGUI-Version"].ToString();
            link = FFmpegTGUIline["FFmpeg-TGUI-LastVersion-link"].ToString();
            gunaLabel1.Text = "New version aviable! - " + version;
            var matches = Regex.Matches(link, @"/").Cast<Match>().Select(i => i.Value).ToArray();
            string slash = string.Join("", matches);
            filename = link.Split('/')[slash.Length];
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            using (WebClient wcprog = new WebClient())
            {

                wcprog.DownloadProgressChanged += (s, progress) =>
                {
                    progressbar.Value = progress.ProgressPercentage;
                };
                wcprog.DownloadFileAsync(new Uri(link), filename);

            }
        }
    }
}
