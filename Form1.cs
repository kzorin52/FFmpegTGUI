using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegGUI
{
    public partial class Form1 : Form
    {
        string filename = @"FFmpegs\20190805\bin\ffmpeg.exe";
        string preset;
        string command;
        string vpre;
        string input;
        StringBuilder icommand = new StringBuilder("");
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Video files(*.*)|*.*";
           saveFileDialog1.Filter = "Video files|*.*";
           openFileDialog2.Filter = "FFpresets|*.ffpreset";
           openFileDialog3.Filter = "FFpresets|*.ffpreset";

           TBcommand.Text = icommand.ToString();
            if (filename.Contains("NIGHTLY"))
            {
                this.gunaLabel11.Text = "FFmpeg NIGHTLY";
            }
            if (filename.Contains("4.2.2"))
            {
                this.gunaLabel11.Text = "FFmpeg STATIC";
            }
            if (filename.Contains("20190805"))
            {
                this.gunaLabel11.Text = "FFmpeg 20190805";
            }
            this.gunaLabel12.Text = filename;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lolToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void loToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(filename);
            settings.ShowDialog();
            filename = settings.filename;
            if (filename.Contains("NIGHTLY"))
            {
                this.gunaLabel11.Text = "FFmpeg NIGHTLY";
            }
            if (filename.Contains("STATIC"))
            {
                this.gunaLabel11.Text = "FFmpeg 4.2.2";
            }
            if (filename.Contains("20190805"))
            {
                this.gunaLabel11.Text = "FFmpeg 20190805";
            }
            this.gunaLabel12.Text = filename;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try{
                Process.Start(filename, TBcommand.Text);
            }
            catch
            {
                MessageBox.Show("Select FFmpeg path");
                
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            input = openFileDialog1.FileName;

            icommand.Append(" -i ");
            icommand.Append(input);
            TBcommand.Text = icommand.ToString();
            bunifuMaterialTextbox1.Text =  input;
               
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string output = saveFileDialog1.FileName;
            icommand.Append(" ");
            icommand.Append(output);
            TBcommand.Text = icommand.ToString();
            bunifuMaterialTextbox2.Text = output;
        }

        private void gunaLabel2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(":-)= : : : "+" TEMNIJ ");
            
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            icommand.Append(" -threads " + materialSingleLineTextField1.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            icommand.Append(" -probesize " + materialSingleLineTextField2.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void ccopy_Click(object sender, EventArgs e)
        {
            icommand.Append(" -c copy ");
            TBcommand.Text = icommand.ToString();
        }

        private void acodeccopy_Click(object sender, EventArgs e)
        {
            icommand.Append(" -acodec copy ");
            TBcommand.Text = icommand.ToString();
        }

        private void acodecalac_Click(object sender, EventArgs e)
        {
            icommand.Append(" -acodec alac ");
            TBcommand.Text = icommand.ToString();
        }

        private void vcodeccopy_Click(object sender, EventArgs e)
        {
            icommand.Append(" -vcodec copy ");
            TBcommand.Text = icommand.ToString();
        }

        private void scodeccopy_Click(object sender, EventArgs e)
        {
            icommand.Append(" -scodec copy ");
            TBcommand.Text = icommand.ToString();
        }

        private void vnbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -vn ");
            TBcommand.Text = icommand.ToString();
        }

        private void anbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -an ");
            TBcommand.Text = icommand.ToString();
        }

        private void arbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -ar "+ materialSingleLineTextField3.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void abbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -ab " + materialSingleLineTextField4.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void passbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -pass " + materialSingleLineTextField5.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void vcodecbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -vcodec " + gunaComboBox1.SelectedItem);
            TBcommand.Text = icommand.ToString();
        }

        private void acodec_Click(object sender, EventArgs e)
        {
            icommand.Append(" -acodec " + gunaComboBox2.SelectedItem);
            TBcommand.Text = icommand.ToString();
        }

        private void test_Hover(object sender, EventArgs e)
        {
            MessageBox.Show("NOTWORK");
        }

        private void test2_Hover(object sender, EventArgs e)
        {
            MessageBox.Show("NOTWORK");
        }

        private void presets_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            preset = openFileDialog2.FileName;

            icommand.Append(" -preset ");
            icommand.Append(preset);
            TBcommand.Text = icommand.ToString();
            //bunifuMaterialTextbox1.Text = input;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            icommand.Clear();
            TBcommand.Text = icommand.ToString();
        }

        private void DCCB(object sender, EventArgs e)
        {
            MessageBox.Show("CLEARED");
        }

        private void absfbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -absf " + gunaComboBox3.SelectedItem);
            TBcommand.Text = icommand.ToString();
        }

        private void vprebtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            vpre = openFileDialog3.FileName;

            icommand.Append(" -vpre ");
            icommand.Append(vpre);
            TBcommand.Text = icommand.ToString();
            vpreLabel14.Text = vpre;
            //bunifuMaterialTextbox1.Text = input;
        }
    }
}
