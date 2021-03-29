using FFmpegTGUI;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static FFmpegTGUI.Alert;

namespace FFmpegGUI
{
    public partial class Form1 : Form
    {
        private string filename = @"FFmpegs\20190805\bin\ffmpeg.exe";
        private string preset;
        private string vpre;
        private string input;
        private string saveoutput;
        private readonly StringBuilder icommand = new StringBuilder("");
        private bool isCEtrue;
        public Form1()
        {
            InitializeComponent();
            isCEtruemethod();

            // MessageBox.Show(file.ReadTextFromFile("config.ini"));

            CESlider();

            openFileDialog1.Filter = "Video files(*.*)|*.*";
            openFileDialog4.Filter = "Music files(*.*)|*.*";
            saveFileDialog1.Filter = "Video files(*.*)|*.*";
            openFileDialog2.Filter = "FFpresets|*.ffpreset|All files(*.*)|*.*";
            openFileDialog3.Filter = "FFpresets|*.ffpreset|All files(*.*)|*.*";
            saveFileDialog2.Filter = "MP4 Files(*.mp4)|*.mp4|All files(*.*)|*.*";

            TBcommand.Text = icommand.ToString();

            if (filename.Contains("NIGHTLY"))
            {
                gunaLabel11.Text = "FFmpeg NIGHTLY";
            }
            if (filename.Contains("4.2.2"))
            {
                gunaLabel11.Text = "FFmpeg STATIC";
            }
            if (filename.Contains("20190805"))
            {
                gunaLabel11.Text = "FFmpeg 20190805";
            }
            gunaLabel12.Text = filename;

        }

        private void isCEtruemethod()
        {

            xFilewriter.FileWriter file = new xFilewriter.FileWriter();
            isCEtrue = bunifuSwitch1.Value;
            if (!File.Exists("config.ini"))
            {
                file.CreateFile("config.ini");
            }
            if (file.ReadTextFromFile("config.ini").Contains("true"))
            {
                isCEtrue = true;
                bunifuSwitch1.Value = true;
            }
            else
            {
                isCEtrue = false;
                bunifuSwitch1.Value = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //guna2Transition1.Show(TBcommand);
            xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeIn, 300);


        }
        public void AlertNotify(string message, AlertType type)
        {
            Alert alert = new Alert();
            alert.setAlert(message, type);
            Focus();
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
                gunaLabel11.Text = "FFmpeg NIGHTLY";
            }
            if (filename.Contains("STATIC"))
            {
                gunaLabel11.Text = "FFmpeg 4.2.3";
            }
            if (filename.Contains("20190805"))
            {
                gunaLabel11.Text = "FFmpeg 20190805";
            }


            gunaLabel12.Text = filename;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            //try
            //{
            //Clipboard.SetText("/c " + Directory.GetCurrentDirectory() + "\\" + filename + " " + TBcommand.Text);
            try
            {
                Process FFstart = Process.Start(new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + Directory.GetCurrentDirectory() + "\\" + filename + " " + TBcommand.Text,
                    WindowStyle = ProcessWindowStyle.Normal,
                });
                AlertNotify("Success!", AlertType.Success);
            }catch
            {
                AlertNotify("Error!", AlertType.Error);
            }
           // FFstart.BeginOutputReadLine();
           // FFstart.OutputDataReceived += (o, output) => { bunifuCustomTextbox1.BeginInvoke((MethodInvoker)(() => bunifuCustomTextbox1.Text = output.Data)); };
            //bunifuCustomTextbox1.Text = FFstart.StandardOutput.ReadToEnd();
            //if (!FFstart.StandardOutput.ReadToEnd().Equals(""))
            //{
            //    AlertNotify("Success!", Alert.AlertType.Success);
            //}
            //else
            //{
            //    AlertNotify("An error ocurred", Alert.AlertType.Error);
            //}

            //}
            //catch
            //{
            // AlertNotify("An error ocurred", Alert.AlertType.Error);

            //}
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            input = openFileDialog1.FileName;
            string output = openFileDialog1.FileName;
            int x1 = output.Length - 4;
            string outputnew = output.Remove(x1);
            outputnew = outputnew + "_new." + output.Split('.')[1];

            icommand.Append(" -i \"");
            icommand.Append(input);
            icommand.Append("\"");
            TBcommand.Text = icommand.ToString();
            bunifuMaterialTextbox1.Text = "\"" + input + "\"";
            icommand.Append(" ");
            icommand.Append("\"" + outputnew + "\"");
            TBcommand.Text = icommand.ToString();
            bunifuMaterialTextbox2.Text = "\"" + outputnew + "\"";

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            icommand.Clear();
            input = openFileDialog1.FileName;
            icommand.Append(" -i \"");
            icommand.Append(input);
            icommand.Append("\"");
            TBcommand.Text = icommand.ToString();
            string output = saveFileDialog1.FileName;
            icommand.Append(" ");
            icommand.Append("\"" + output + "\"");
            TBcommand.Text = icommand.ToString();
            bunifuMaterialTextbox2.Text = "\"" + output + "\"";
        }

        private void gunaLabel2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(":-)= : : : " + " TEMNIJ ");

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            icommand.Append(" -threads " + threadsval.Value);
            TBcommand.Text = icommand.ToString();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            icommand.Append(" -probesize " + probeval.Value);
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
            icommand.Append(" -ar " + ahz.Value);
            TBcommand.Text = icommand.ToString();
        }

        private void abbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -ab " + abtr.Value + "k");
            TBcommand.Text = icommand.ToString();
        }

        private void passbtn_Click(object sender, EventArgs e)
        {
            icommand.Append(" -pass " + passval.Value);
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



        private void presets_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            preset = openFileDialog2.FileName;

            icommand.Append(" -preset \"");
            icommand.Append(preset);
            icommand.Append("\"");
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
            {
                return;
            }
            // получаем выбранный файл
            vpre = openFileDialog3.FileName;

            icommand.Append(" -vpre \"");
            icommand.Append(vpre);
            icommand.Append("\"");
            TBcommand.Text = icommand.ToString();
            vpreLabel14.Text = vpre;
            //bunifuMaterialTextbox1.Text = input;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            try
            {



                // имя каждой директории добавляем в новую строку файла.
                using (StreamWriter sw1 = new StreamWriter("files.txt"))
                {
                    foreach (string dir in FilesForSplit.FileNames)
                    {
                        sw1.WriteLine("file '" + dir + "'");

                    }
                }
                if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                // получаем выбранный файл
                string output = saveFileDialog2.FileName;
                saveoutput = output;
                icommand.Append(" -f concat -safe 0 -i files.txt -c copy \"" + saveoutput + "\"");
                TBcommand.Text = icommand.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            FilesForSplit.Multiselect = true;
            FilesForSplit.Title = "Выберите файлы";
            FilesForSplit.InitialDirectory = @"D:\";
            FilesForSplit.Filter =
    "Videos (*.mp4;*.avi;*.mpg)|*.mp4;*.avi;*.mpg|" +
    "All files (*.*)|*.*";
            FilesForSplit.ShowDialog();




            //if (folderforsplit.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        private void speedupbtn1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            icommand.Clear();
            //-i html.mp4 -lavfi "setpts=0.033*PTS" -r 30  output-x30.mp4
            double z = 1.0 / speedup2.Value;

            icommand.Append(" -i " + bunifuMaterialTextbox1.Text + " -lavfi \"setpts=" + z + "*PTS\" -r 30 " + bunifuMaterialTextbox2.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {

            icommand.Clear();
            string zvuk;
            if (openFileDialog4.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            zvuk = openFileDialog4.FileName;

            // -i "+ bunifuMaterialTextbox1.Text +" -i "+ zvuk +" -vcodec copy -acodec copy -map 0:0 -map 1:0" +bunifuMaterialTextbox2.Text
            icommand.Append("-i " + bunifuMaterialTextbox1.Text + " -i \"" + zvuk + "\" -vcodec copy -acodec copy -map 0:0 -map 1:0 " + bunifuMaterialTextbox2.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void gunaLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            //ffmpeg -ss 00:00:00 -t 00:01:14 -i  "+bunifuMaterialTextbox1.Text+" -vcodec copy -acodec copy "+bunifuMaterialTextbox2.Text
            icommand.Clear();

            icommand.Append("-ss " + nachalo.Text + " -t " + konec.Text + " -i  " + bunifuMaterialTextbox1.Text + " -vcodec copy -acodec copy " + bunifuMaterialTextbox2.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            icommand.Clear();
            //-i html.mp4 -lavfi "setpts=0.033*PTS" -r 30  output-x30.mp4
            double z = 1.0 / speedup2.Value;

            icommand.Append(" -i " + bunifuMaterialTextbox1.Text + " -lavfi \"setpts=" + z + "*PTS\" -r 30 " + bunifuMaterialTextbox2.Text);
            TBcommand.Text = icommand.ToString();
        }

        private void bunifuFlatButton11_Click_1(object sender, EventArgs e)
        {
            FilesForSplit.Multiselect = true;
            FilesForSplit.Title = "Выберите файлы";
            FilesForSplit.InitialDirectory = @"D:\";
            FilesForSplit.Filter =
    "Videos (*.mp4;*.avi;*.mpg)|*.mp4;*.avi;*.mpg|" +
    "All files (*.*)|*.*";
            FilesForSplit.ShowDialog();
        }

        private void bunifuFlatButton10_Click_1(object sender, EventArgs e)
        {
            try
            {  // имя каждой директории добавляем в новую строку файла.
                using (StreamWriter sw1 = new StreamWriter("files.txt"))
                {
                    foreach (string dir in FilesForSplit.FileNames)
                    {
                        sw1.WriteLine("file '" + dir + "'");

                    }
                }
                if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                // получаем выбранный файл
                string output = saveFileDialog2.FileName;

                icommand.Append(" -f concat -safe 0 -i files.txt -c copy \"" + output + "\" -acodec copy -vcodec copy");
                TBcommand.Text = icommand.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CESlider()
        {
            isCEtrue = bunifuSwitch1.Value;
            xFilewriter.FileWriter file = new xFilewriter.FileWriter();


            if (isCEtrue)
            {
                BackgroundImage = FFmpegTGUI.Properties.Resources.neuro_texture_lava;

                file.AppendTextToFile("true", "config.ini", FileMode.Open);

            }
            else
            {
                file.AppendTextToFile("false", "config.ini", FileMode.Open);
                BackgroundImage = null;
            }
        }
        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            CESlider();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            icommand.Append($" -i {URLBox.Text} -c copy {bunifuMaterialTextbox2.Text}");
            TBcommand.Text = icommand.ToString();
        }
    }
}