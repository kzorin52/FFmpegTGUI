using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegGUI
{
    public partial class Settings : Form
    {
        public string filename = @"FFmpegs\20190805\bin\ffmpeg.exe";
        public Settings(string filename)
        {
            InitializeComponent();
            this.filename = filename;
            openFileDialog1.Filter = "FFmpeg(ffmpeg.exe)|ffmpeg.exe|All files(*.*)|*.*";
            TBPath.Text = filename;
        }


        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            filename = openFileDialog1.FileName;
            TBPath.Text = filename;
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            filename = TBPath.Text;
            Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"FFmpegs\NIGHTLY\bin\ffmpeg.exe")){
                filename = @"FFmpegs\NIGHTLY\bin\ffmpeg.exe";
                TBPath.Text = filename;
            }
            else
            {
                TBPath.Text = "Error";
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"FFmpegs\STATIC\bin\ffmpeg.exe"))
            {
                filename = @"FFmpegs\STATIC\bin\ffmpeg.exe";
                TBPath.Text = filename;
            }
            else
            {
                TBPath.Text = "Error";
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"FFmpegs\20190805\bin\ffmpeg.exe"))
            {
                filename = @"FFmpegs\20190805\bin\ffmpeg.exe";
                TBPath.Text = filename;
            }
            else
            {
                TBPath.Text = "Error";
            }
        }
    }
}
