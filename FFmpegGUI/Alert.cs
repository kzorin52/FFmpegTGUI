using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTGUI
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }
        public enum AlertType
        {
            Success,
            Warning,
            Error,
            Info
        }

        private int x, y;
        public void setAlert(string msg, AlertType type)
        {
            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Alert f = (Alert)Application.OpenForms[fname];

                if (f == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    break;
                }

            }

            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            switch (type)
            {
                case AlertType.Success:
                    GunaPictureBox1.Image = Properties.Resources.Checkmark_28px;
                    BackColor = Color.FromArgb(42, 171, 160);
                    break;
                case AlertType.Warning:
                    GunaPictureBox1.Image = Properties.Resources.Warning_28px;
                    BackColor = Color.FromArgb(255, 179, 2);
                    break;
                case AlertType.Error:
                    GunaPictureBox1.Image = Properties.Resources.Error_28px;
                    BackColor = Color.FromArgb(255, 121, 70);
                    break;
                case AlertType.Info:
                    GunaPictureBox1.Image = Properties.Resources.Info_28px;
                    BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }
            GunaLabel1.Text = msg;

            TopMost = false;
            ShowIcon = false;
            ShowInTaskbar = false;

            Show();
            action = actionEnum.start;
            Timer1.Interval = 1;
            Timer1.Start();


        }

        public enum actionEnum
        {
            wait,
            start,
            close
        }

        private actionEnum action;


        private void GunaPictureBox2_Click(object sender, EventArgs e)
        {
            Timer1.Interval = 1;
            action = actionEnum.close;
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case actionEnum.wait:
                    Timer1.Interval = 5000;
                    action = actionEnum.close;
                    break;
                case actionEnum.start:
                    Timer1.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            action = actionEnum.wait;
                        }
                    }
                    break;
                case actionEnum.close:
                    Timer1.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

    }
}
