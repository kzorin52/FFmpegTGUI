namespace FFmpegTGUI
{
    partial class Alert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.GunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GunaLabel1.Location = new System.Drawing.Point(64, 24);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(93, 21);
            this.GunaLabel1.TabIndex = 10;
            this.GunaLabel1.Text = "GunaLabel1";
            // 
            // GunaPanel1
            // 
            this.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.GunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.GunaPanel1.Name = "GunaPanel1";
            this.GunaPanel1.Size = new System.Drawing.Size(5, 70);
            this.GunaPanel1.TabIndex = 8;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GunaPictureBox2
            // 
            this.GunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GunaPictureBox2.Image = global::FFmpegTGUI.Properties.Resources.Multiply_18px;
            this.GunaPictureBox2.Location = new System.Drawing.Point(350, 26);
            this.GunaPictureBox2.Name = "GunaPictureBox2";
            this.GunaPictureBox2.Size = new System.Drawing.Size(18, 18);
            this.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GunaPictureBox2.TabIndex = 11;
            this.GunaPictureBox2.TabStop = false;
            this.GunaPictureBox2.Click += new System.EventHandler(this.GunaPictureBox2_Click);
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Image = global::FFmpegTGUI.Properties.Resources.Checkmark_28px;
            this.GunaPictureBox1.Location = new System.Drawing.Point(30, 21);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GunaPictureBox1.TabIndex = 9;
            this.GunaPictureBox1.TabStop = false;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(380, 70);
            this.Controls.Add(this.GunaPictureBox2);
            this.Controls.Add(this.GunaLabel1);
            this.Controls.Add(this.GunaPictureBox1);
            this.Controls.Add(this.GunaPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Text = "Alert";
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        internal Guna.UI.WinForms.GunaPanel GunaPanel1;
        internal System.Windows.Forms.Timer Timer1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox2;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
    }
}