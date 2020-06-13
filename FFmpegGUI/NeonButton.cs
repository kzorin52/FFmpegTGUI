using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTGUI
{
    public partial class NeonButton : UserControl
    {
        public NeonButton()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           // pictureBox1.Image = Properties.Resources.NeonButton_hover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.NeonButton;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            pictureBox1.Image = Properties.Resources.NeonButton_pressed;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.NeonButton;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.NeonButton_hover;
        }
    }
}
