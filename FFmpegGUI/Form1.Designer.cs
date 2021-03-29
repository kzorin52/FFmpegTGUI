
using System.Linq;


namespace FFmpegGUI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
           
           
            if (disposing && (components != null))
            {
                xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeOut, 300);
                components.Dispose();
                
            }            
            base.Dispose(disposing);
            string target_name = "FFmpegTGUI.exe";
            System.Diagnostics.Process[] local_procs = System.Diagnostics.Process.GetProcesses();
            try
            {
                System.Diagnostics.Process target_proc = local_procs.First(p => p.ProcessName == target_name);
                target_proc.Kill();
            }
            catch { }
        }
        
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.xuiFlatMenuStrip1 = new XanderUI.XUIFlatMenuStrip();
            this.loToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaResize1 = new Guna.UI.WinForms.GunaResize(this.components);
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.vcodeccopy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.acodeccopy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.scodeccopy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vnbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.anbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.arbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.TBcommand = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.acodecalac = new Bunifu.Framework.UI.BunifuFlatButton();
            this.abbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.passbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.acodec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clearbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.absf = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox3 = new Guna.UI.WinForms.GunaComboBox();
            this.vprebtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.vpreLabel14 = new Guna.UI.WinForms.GunaLabel();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.passval = new Guna.UI.WinForms.GunaNumeric();
            this.ahz = new Guna.UI.WinForms.GunaNumeric();
            this.abtr = new Guna.UI.WinForms.GunaNumeric();
            this.threadsval = new Guna.UI.WinForms.GunaNumeric();
            this.probeval = new Guna.UI.WinForms.GunaNumeric();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.bunifuFlatButton14 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel17 = new Guna.UI.WinForms.GunaLabel();
            this.konec = new EgoldsUI.EgoldsGoogleTextBox();
            this.nachalo = new EgoldsUI.EgoldsGoogleTextBox();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.bunifuFlatButton13 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.speedup2 = new Guna.UI.WinForms.GunaNumeric();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.FilesForSplit = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.xuiObjectAnimator1 = new XanderUI.XUIObjectAnimator();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuMaterialTextbox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuMaterialTextbox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLinePanel1.SuspendLayout();
            this.xuiFlatMenuStrip1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.SeaGreen;
            this.gunaLinePanel1.Controls.Add(this.gunaLabel2);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox3);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox2);
            this.gunaLinePanel1.Controls.Add(this.gunaControlBox1);
            resources.ApplyResources(this.gunaLinePanel1, "gunaLinePanel1");
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            // 
            // gunaLabel2
            // 
            resources.ApplyResources(this.gunaLabel2, "gunaLabel2");
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel2.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Animated = true;
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            resources.ApplyResources(this.gunaControlBox3, "gunaControlBox3");
            this.gunaControlBox3.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Animated = true;
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            resources.ApplyResources(this.gunaControlBox2, "gunaControlBox2");
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Animated = true;
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            resources.ApplyResources(this.gunaControlBox1, "gunaControlBox1");
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.Red;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaLinePanel1;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.xuiFlatMenuStrip1;
            // 
            // xuiFlatMenuStrip1
            // 
            this.xuiFlatMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.xuiFlatMenuStrip1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.xuiFlatMenuStrip1.HoverTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.xuiFlatMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loToolStripMenuItem,
            this.lolToolStripMenuItem});
            resources.ApplyResources(this.xuiFlatMenuStrip1, "xuiFlatMenuStrip1");
            this.xuiFlatMenuStrip1.Name = "xuiFlatMenuStrip1";
            this.xuiFlatMenuStrip1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.xuiFlatMenuStrip1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.SeperatorColor = System.Drawing.Color.White;
            this.xuiFlatMenuStrip1.TextColor = System.Drawing.Color.White;
            // 
            // loToolStripMenuItem
            // 
            this.loToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loToolStripMenuItem.Name = "loToolStripMenuItem";
            resources.ApplyResources(this.loToolStripMenuItem, "loToolStripMenuItem");
            this.loToolStripMenuItem.Click += new System.EventHandler(this.loToolStripMenuItem_Click);
            // 
            // lolToolStripMenuItem
            // 
            this.lolToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lolToolStripMenuItem.Name = "lolToolStripMenuItem";
            resources.ApplyResources(this.lolToolStripMenuItem, "lolToolStripMenuItem");
            this.lolToolStripMenuItem.Click += new System.EventHandler(this.lolToolStripMenuItem_Click);
            // 
            // gunaResize1
            // 
            this.gunaResize1.TargetForm = this;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton1, "bunifuFlatButton1");
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "PROCESS";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton2, "bunifuFlatButton2");
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "...";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton3, "bunifuFlatButton3");
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "...";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton4, "bunifuFlatButton4");
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "PROCESS";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton6, "bunifuFlatButton6");
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "OK";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton6.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // gunaLabel3
            // 
            resources.ApplyResources(this.gunaLabel3, "gunaLabel3");
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel3.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton5, "bunifuFlatButton5");
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "OK";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // gunaLabel4
            // 
            resources.ApplyResources(this.gunaLabel4, "gunaLabel4");
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel4.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // vcodeccopy
            // 
            this.vcodeccopy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.vcodeccopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.vcodeccopy, "vcodeccopy");
            this.vcodeccopy.BorderRadius = 0;
            this.vcodeccopy.ButtonText = "-vcodec copy";
            this.vcodeccopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vcodeccopy.DisabledColor = System.Drawing.Color.Gray;
            this.vcodeccopy.Iconcolor = System.Drawing.Color.Transparent;
            this.vcodeccopy.Iconimage = null;
            this.vcodeccopy.Iconimage_right = null;
            this.vcodeccopy.Iconimage_right_Selected = null;
            this.vcodeccopy.Iconimage_Selected = null;
            this.vcodeccopy.IconMarginLeft = 0;
            this.vcodeccopy.IconMarginRight = 0;
            this.vcodeccopy.IconRightVisible = true;
            this.vcodeccopy.IconRightZoom = 0D;
            this.vcodeccopy.IconVisible = true;
            this.vcodeccopy.IconZoom = 90D;
            this.vcodeccopy.IsTab = false;
            this.vcodeccopy.Name = "vcodeccopy";
            this.vcodeccopy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.vcodeccopy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.vcodeccopy.OnHoverTextColor = System.Drawing.Color.White;
            this.vcodeccopy.selected = false;
            this.vcodeccopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vcodeccopy.Textcolor = System.Drawing.Color.White;
            this.vcodeccopy.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.vcodeccopy.Click += new System.EventHandler(this.vcodeccopy_Click);
            // 
            // acodeccopy
            // 
            this.acodeccopy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acodeccopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.acodeccopy, "acodeccopy");
            this.acodeccopy.BorderRadius = 0;
            this.acodeccopy.ButtonText = "-acodec copy";
            this.acodeccopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acodeccopy.DisabledColor = System.Drawing.Color.Gray;
            this.acodeccopy.Iconcolor = System.Drawing.Color.Transparent;
            this.acodeccopy.Iconimage = null;
            this.acodeccopy.Iconimage_right = null;
            this.acodeccopy.Iconimage_right_Selected = null;
            this.acodeccopy.Iconimage_Selected = null;
            this.acodeccopy.IconMarginLeft = 0;
            this.acodeccopy.IconMarginRight = 0;
            this.acodeccopy.IconRightVisible = true;
            this.acodeccopy.IconRightZoom = 0D;
            this.acodeccopy.IconVisible = true;
            this.acodeccopy.IconZoom = 90D;
            this.acodeccopy.IsTab = false;
            this.acodeccopy.Name = "acodeccopy";
            this.acodeccopy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acodeccopy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.acodeccopy.OnHoverTextColor = System.Drawing.Color.White;
            this.acodeccopy.selected = false;
            this.acodeccopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acodeccopy.Textcolor = System.Drawing.Color.White;
            this.acodeccopy.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.acodeccopy.Click += new System.EventHandler(this.acodeccopy_Click);
            // 
            // scodeccopy
            // 
            this.scodeccopy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.scodeccopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.scodeccopy, "scodeccopy");
            this.scodeccopy.BorderRadius = 0;
            this.scodeccopy.ButtonText = "-scodec copy";
            this.scodeccopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scodeccopy.DisabledColor = System.Drawing.Color.Gray;
            this.scodeccopy.Iconcolor = System.Drawing.Color.Transparent;
            this.scodeccopy.Iconimage = null;
            this.scodeccopy.Iconimage_right = null;
            this.scodeccopy.Iconimage_right_Selected = null;
            this.scodeccopy.Iconimage_Selected = null;
            this.scodeccopy.IconMarginLeft = 0;
            this.scodeccopy.IconMarginRight = 0;
            this.scodeccopy.IconRightVisible = true;
            this.scodeccopy.IconRightZoom = 0D;
            this.scodeccopy.IconVisible = true;
            this.scodeccopy.IconZoom = 90D;
            this.scodeccopy.IsTab = false;
            this.scodeccopy.Name = "scodeccopy";
            this.scodeccopy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.scodeccopy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.scodeccopy.OnHoverTextColor = System.Drawing.Color.White;
            this.scodeccopy.selected = false;
            this.scodeccopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scodeccopy.Textcolor = System.Drawing.Color.White;
            this.scodeccopy.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.scodeccopy.Click += new System.EventHandler(this.scodeccopy_Click);
            // 
            // vnbtn
            // 
            this.vnbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.vnbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.vnbtn, "vnbtn");
            this.vnbtn.BorderRadius = 0;
            this.vnbtn.ButtonText = "video not";
            this.vnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vnbtn.DisabledColor = System.Drawing.Color.Gray;
            this.vnbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.vnbtn.Iconimage = null;
            this.vnbtn.Iconimage_right = null;
            this.vnbtn.Iconimage_right_Selected = null;
            this.vnbtn.Iconimage_Selected = null;
            this.vnbtn.IconMarginLeft = 0;
            this.vnbtn.IconMarginRight = 0;
            this.vnbtn.IconRightVisible = true;
            this.vnbtn.IconRightZoom = 0D;
            this.vnbtn.IconVisible = true;
            this.vnbtn.IconZoom = 90D;
            this.vnbtn.IsTab = false;
            this.vnbtn.Name = "vnbtn";
            this.vnbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.vnbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.vnbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.vnbtn.selected = false;
            this.vnbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vnbtn.Textcolor = System.Drawing.Color.White;
            this.vnbtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.vnbtn.Click += new System.EventHandler(this.vnbtn_Click);
            // 
            // anbtn
            // 
            this.anbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.anbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.anbtn, "anbtn");
            this.anbtn.BorderRadius = 0;
            this.anbtn.ButtonText = "audio not";
            this.anbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anbtn.DisabledColor = System.Drawing.Color.Gray;
            this.anbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.anbtn.Iconimage = null;
            this.anbtn.Iconimage_right = null;
            this.anbtn.Iconimage_right_Selected = null;
            this.anbtn.Iconimage_Selected = null;
            this.anbtn.IconMarginLeft = 0;
            this.anbtn.IconMarginRight = 0;
            this.anbtn.IconRightVisible = true;
            this.anbtn.IconRightZoom = 0D;
            this.anbtn.IconVisible = true;
            this.anbtn.IconZoom = 90D;
            this.anbtn.IsTab = false;
            this.anbtn.Name = "anbtn";
            this.anbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.anbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.anbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.anbtn.selected = false;
            this.anbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.anbtn.Textcolor = System.Drawing.Color.White;
            this.anbtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.anbtn.Click += new System.EventHandler(this.anbtn_Click);
            // 
            // arbtn
            // 
            this.arbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.arbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.arbtn, "arbtn");
            this.arbtn.BorderRadius = 0;
            this.arbtn.ButtonText = "OK";
            this.arbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arbtn.DisabledColor = System.Drawing.Color.Gray;
            this.arbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.arbtn.Iconimage = null;
            this.arbtn.Iconimage_right = null;
            this.arbtn.Iconimage_right_Selected = null;
            this.arbtn.Iconimage_Selected = null;
            this.arbtn.IconMarginLeft = 0;
            this.arbtn.IconMarginRight = 0;
            this.arbtn.IconRightVisible = true;
            this.arbtn.IconRightZoom = 0D;
            this.arbtn.IconVisible = true;
            this.arbtn.IconZoom = 90D;
            this.arbtn.IsTab = false;
            this.arbtn.Name = "arbtn";
            this.arbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.arbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.arbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.arbtn.selected = false;
            this.arbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.arbtn.Textcolor = System.Drawing.Color.White;
            this.arbtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.arbtn.Click += new System.EventHandler(this.arbtn_Click);
            // 
            // gunaLabel5
            // 
            resources.ApplyResources(this.gunaLabel5, "gunaLabel5");
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel5.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // TBcommand
            // 
            resources.ApplyResources(this.TBcommand, "TBcommand");
            this.TBcommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.TBcommand.BorderColor = System.Drawing.Color.DarkGreen;
            this.TBcommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBcommand.Name = "TBcommand";
            // 
            // gunaLabel1
            // 
            resources.ApplyResources(this.gunaLabel1, "gunaLabel1");
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel1.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // gunaLabel6
            // 
            resources.ApplyResources(this.gunaLabel6, "gunaLabel6");
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel6.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // acodecalac
            // 
            this.acodecalac.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acodecalac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.acodecalac, "acodecalac");
            this.acodecalac.BorderRadius = 0;
            this.acodecalac.ButtonText = "alac";
            this.acodecalac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acodecalac.DisabledColor = System.Drawing.Color.Gray;
            this.acodecalac.Iconcolor = System.Drawing.Color.Transparent;
            this.acodecalac.Iconimage = null;
            this.acodecalac.Iconimage_right = null;
            this.acodecalac.Iconimage_right_Selected = null;
            this.acodecalac.Iconimage_Selected = null;
            this.acodecalac.IconMarginLeft = 0;
            this.acodecalac.IconMarginRight = 0;
            this.acodecalac.IconRightVisible = true;
            this.acodecalac.IconRightZoom = 0D;
            this.acodecalac.IconVisible = true;
            this.acodecalac.IconZoom = 90D;
            this.acodecalac.IsTab = false;
            this.acodecalac.Name = "acodecalac";
            this.acodecalac.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acodecalac.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.acodecalac.OnHoverTextColor = System.Drawing.Color.White;
            this.acodecalac.selected = false;
            this.acodecalac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acodecalac.Textcolor = System.Drawing.Color.White;
            this.acodecalac.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.acodecalac.Click += new System.EventHandler(this.acodecalac_Click);
            // 
            // abbtn
            // 
            this.abbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.abbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.abbtn, "abbtn");
            this.abbtn.BorderRadius = 0;
            this.abbtn.ButtonText = "OK";
            this.abbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abbtn.DisabledColor = System.Drawing.Color.Gray;
            this.abbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.abbtn.Iconimage = null;
            this.abbtn.Iconimage_right = null;
            this.abbtn.Iconimage_right_Selected = null;
            this.abbtn.Iconimage_Selected = null;
            this.abbtn.IconMarginLeft = 0;
            this.abbtn.IconMarginRight = 0;
            this.abbtn.IconRightVisible = true;
            this.abbtn.IconRightZoom = 0D;
            this.abbtn.IconVisible = true;
            this.abbtn.IconZoom = 90D;
            this.abbtn.IsTab = false;
            this.abbtn.Name = "abbtn";
            this.abbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.abbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.abbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.abbtn.selected = false;
            this.abbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.abbtn.Textcolor = System.Drawing.Color.White;
            this.abbtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.abbtn.Click += new System.EventHandler(this.abbtn_Click);
            // 
            // gunaLabel7
            // 
            resources.ApplyResources(this.gunaLabel7, "gunaLabel7");
            this.gunaLabel7.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel7.ForeColor = System.Drawing.Color.White;
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel7.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // passbtn
            // 
            this.passbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.passbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.passbtn, "passbtn");
            this.passbtn.BorderRadius = 0;
            this.passbtn.ButtonText = "OK";
            this.passbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passbtn.DisabledColor = System.Drawing.Color.Gray;
            this.passbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.passbtn.Iconimage = null;
            this.passbtn.Iconimage_right = null;
            this.passbtn.Iconimage_right_Selected = null;
            this.passbtn.Iconimage_Selected = null;
            this.passbtn.IconMarginLeft = 0;
            this.passbtn.IconMarginRight = 0;
            this.passbtn.IconRightVisible = true;
            this.passbtn.IconRightZoom = 0D;
            this.passbtn.IconVisible = true;
            this.passbtn.IconZoom = 90D;
            this.passbtn.IsTab = false;
            this.passbtn.Name = "passbtn";
            this.passbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.passbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.passbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.passbtn.selected = false;
            this.passbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passbtn.Textcolor = System.Drawing.Color.White;
            this.passbtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.passbtn.Click += new System.EventHandler(this.passbtn_Click);
            // 
            // gunaLabel8
            // 
            resources.ApplyResources(this.gunaLabel8, "gunaLabel8");
            this.gunaLabel8.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel8.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton7, "bunifuFlatButton7");
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "OK";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton7.Click += new System.EventHandler(this.vcodecbtn_Click);
            // 
            // gunaLabel9
            // 
            resources.ApplyResources(this.gunaLabel9, "gunaLabel9");
            this.gunaLabel9.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel9.ForeColor = System.Drawing.Color.White;
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel9.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // acodec
            // 
            this.acodec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acodec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.acodec, "acodec");
            this.acodec.BorderRadius = 0;
            this.acodec.ButtonText = "OK";
            this.acodec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acodec.DisabledColor = System.Drawing.Color.Gray;
            this.acodec.Iconcolor = System.Drawing.Color.Transparent;
            this.acodec.Iconimage = null;
            this.acodec.Iconimage_right = null;
            this.acodec.Iconimage_right_Selected = null;
            this.acodec.Iconimage_Selected = null;
            this.acodec.IconMarginLeft = 0;
            this.acodec.IconMarginRight = 0;
            this.acodec.IconRightVisible = true;
            this.acodec.IconRightZoom = 0D;
            this.acodec.IconVisible = true;
            this.acodec.IconZoom = 90D;
            this.acodec.IsTab = false;
            this.acodec.Name = "acodec";
            this.acodec.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.acodec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.acodec.OnHoverTextColor = System.Drawing.Color.White;
            this.acodec.selected = false;
            this.acodec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.acodec.Textcolor = System.Drawing.Color.White;
            this.acodec.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.acodec.Click += new System.EventHandler(this.acodec_Click);
            // 
            // gunaLabel10
            // 
            resources.ApplyResources(this.gunaLabel10, "gunaLabel10");
            this.gunaLabel10.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel10.ForeColor = System.Drawing.Color.White;
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel10.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // gunaLabel11
            // 
            resources.ApplyResources(this.gunaLabel11, "gunaLabel11");
            this.gunaLabel11.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel11.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // gunaLabel12
            // 
            resources.ApplyResources(this.gunaLabel12, "gunaLabel12");
            this.gunaLabel12.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))));
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel12.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton8, "bunifuFlatButton8");
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "PRESETS";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton8.Click += new System.EventHandler(this.presets_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.clearbtn, "clearbtn");
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clearbtn.BorderRadius = 0;
            this.clearbtn.ButtonText = "CLEAR";
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.DisabledColor = System.Drawing.Color.Gray;
            this.clearbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.clearbtn.Iconimage = null;
            this.clearbtn.Iconimage_right = null;
            this.clearbtn.Iconimage_right_Selected = null;
            this.clearbtn.Iconimage_Selected = null;
            this.clearbtn.IconMarginLeft = 0;
            this.clearbtn.IconMarginRight = 0;
            this.clearbtn.IconRightVisible = true;
            this.clearbtn.IconRightZoom = 0D;
            this.clearbtn.IconVisible = true;
            this.clearbtn.IconZoom = 90D;
            this.clearbtn.IsTab = false;
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.clearbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.clearbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.clearbtn.selected = false;
            this.clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearbtn.Textcolor = System.Drawing.Color.White;
            this.clearbtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            this.clearbtn.DoubleClick += new System.EventHandler(this.DCCB);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.gunaComboBox1, "gunaComboBox1");
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            resources.GetString("gunaComboBox1.Items"),
            resources.GetString("gunaComboBox1.Items1"),
            resources.GetString("gunaComboBox1.Items2"),
            resources.GetString("gunaComboBox1.Items3"),
            resources.GetString("gunaComboBox1.Items4"),
            resources.GetString("gunaComboBox1.Items5"),
            resources.GetString("gunaComboBox1.Items6")});
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.gunaComboBox2, "gunaComboBox2");
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Items.AddRange(new object[] {
            resources.GetString("gunaComboBox2.Items"),
            resources.GetString("gunaComboBox2.Items1"),
            resources.GetString("gunaComboBox2.Items2"),
            resources.GetString("gunaComboBox2.Items3"),
            resources.GetString("gunaComboBox2.Items4"),
            resources.GetString("gunaComboBox2.Items5"),
            resources.GetString("gunaComboBox2.Items6")});
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            // 
            // absf
            // 
            this.absf.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.absf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.absf, "absf");
            this.absf.BorderRadius = 0;
            this.absf.ButtonText = "OK";
            this.absf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.absf.DisabledColor = System.Drawing.Color.Gray;
            this.absf.Iconcolor = System.Drawing.Color.Transparent;
            this.absf.Iconimage = null;
            this.absf.Iconimage_right = null;
            this.absf.Iconimage_right_Selected = null;
            this.absf.Iconimage_Selected = null;
            this.absf.IconMarginLeft = 0;
            this.absf.IconMarginRight = 0;
            this.absf.IconRightVisible = true;
            this.absf.IconRightZoom = 0D;
            this.absf.IconVisible = true;
            this.absf.IconZoom = 90D;
            this.absf.IsTab = false;
            this.absf.Name = "absf";
            this.absf.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.absf.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.absf.OnHoverTextColor = System.Drawing.Color.White;
            this.absf.selected = false;
            this.absf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.absf.Textcolor = System.Drawing.Color.White;
            this.absf.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.absf.Click += new System.EventHandler(this.absfbtn_Click);
            // 
            // gunaLabel13
            // 
            resources.ApplyResources(this.gunaLabel13, "gunaLabel13");
            this.gunaLabel13.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel13.ForeColor = System.Drawing.Color.White;
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.gunaLabel13.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // gunaComboBox3
            // 
            this.gunaComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox3.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox3.FocusedColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.gunaComboBox3, "gunaComboBox3");
            this.gunaComboBox3.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox3.FormattingEnabled = true;
            this.gunaComboBox3.Items.AddRange(new object[] {
            resources.GetString("gunaComboBox3.Items")});
            this.gunaComboBox3.Name = "gunaComboBox3";
            this.gunaComboBox3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox3.OnHoverItemForeColor = System.Drawing.Color.White;
            // 
            // vprebtn
            // 
            this.vprebtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.vprebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.vprebtn, "vprebtn");
            this.vprebtn.BorderRadius = 0;
            this.vprebtn.ButtonText = "VPRE";
            this.vprebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vprebtn.DisabledColor = System.Drawing.Color.Gray;
            this.vprebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.vprebtn.Iconimage = null;
            this.vprebtn.Iconimage_right = null;
            this.vprebtn.Iconimage_right_Selected = null;
            this.vprebtn.Iconimage_Selected = null;
            this.vprebtn.IconMarginLeft = 0;
            this.vprebtn.IconMarginRight = 0;
            this.vprebtn.IconRightVisible = true;
            this.vprebtn.IconRightZoom = 0D;
            this.vprebtn.IconVisible = true;
            this.vprebtn.IconZoom = 90D;
            this.vprebtn.IsTab = false;
            this.vprebtn.Name = "vprebtn";
            this.vprebtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.vprebtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.vprebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.vprebtn.selected = false;
            this.vprebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.vprebtn.Textcolor = System.Drawing.Color.White;
            this.vprebtn.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.vprebtn.Click += new System.EventHandler(this.vprebtn_Click);
            // 
            // vpreLabel14
            // 
            resources.ApplyResources(this.vpreLabel14, "vpreLabel14");
            this.vpreLabel14.BackColor = System.Drawing.Color.Transparent;
            this.vpreLabel14.ForeColor = System.Drawing.Color.White;
            this.vpreLabel14.Name = "vpreLabel14";
            this.vpreLabel14.Click += new System.EventHandler(this.gunaLabel2_Click);
            this.vpreLabel14.DoubleClick += new System.EventHandler(this.gunaLabel2_DoubleClick);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // passval
            // 
            this.passval.BackColor = System.Drawing.Color.Transparent;
            this.passval.BaseColor = System.Drawing.Color.White;
            this.passval.BorderColor = System.Drawing.Color.Silver;
            this.passval.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.passval.ButtonForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.passval, "passval");
            this.passval.ForeColor = System.Drawing.Color.Black;
            this.passval.Maximum = ((long)(9999999));
            this.passval.Minimum = ((long)(0));
            this.passval.Name = "passval";
            this.passval.Value = ((long)(1));
            // 
            // ahz
            // 
            this.ahz.BackColor = System.Drawing.Color.Transparent;
            this.ahz.BaseColor = System.Drawing.Color.White;
            this.ahz.BorderColor = System.Drawing.Color.Silver;
            this.ahz.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.ahz.ButtonForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ahz, "ahz");
            this.ahz.ForeColor = System.Drawing.Color.Black;
            this.ahz.Maximum = ((long)(9999999));
            this.ahz.Minimum = ((long)(0));
            this.ahz.Name = "ahz";
            this.ahz.Value = ((long)(44100));
            // 
            // abtr
            // 
            this.abtr.BackColor = System.Drawing.Color.Transparent;
            this.abtr.BaseColor = System.Drawing.Color.White;
            this.abtr.BorderColor = System.Drawing.Color.Silver;
            this.abtr.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.abtr.ButtonForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.abtr, "abtr");
            this.abtr.ForeColor = System.Drawing.Color.Black;
            this.abtr.Maximum = ((long)(9999999));
            this.abtr.Minimum = ((long)(0));
            this.abtr.Name = "abtr";
            this.abtr.Value = ((long)(256));
            // 
            // threadsval
            // 
            resources.ApplyResources(this.threadsval, "threadsval");
            this.threadsval.BackColor = System.Drawing.Color.Transparent;
            this.threadsval.BaseColor = System.Drawing.Color.White;
            this.threadsval.BorderColor = System.Drawing.Color.Silver;
            this.threadsval.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.threadsval.ButtonForeColor = System.Drawing.Color.Black;
            this.threadsval.ForeColor = System.Drawing.Color.Black;
            this.threadsval.Maximum = ((long)(9999999));
            this.threadsval.Minimum = ((long)(0));
            this.threadsval.Name = "threadsval";
            this.threadsval.Value = ((long)(0));
            // 
            // probeval
            // 
            resources.ApplyResources(this.probeval, "probeval");
            this.probeval.BackColor = System.Drawing.Color.Transparent;
            this.probeval.BaseColor = System.Drawing.Color.White;
            this.probeval.BorderColor = System.Drawing.Color.Silver;
            this.probeval.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.probeval.ButtonForeColor = System.Drawing.Color.Black;
            this.probeval.ForeColor = System.Drawing.Color.Black;
            this.probeval.Maximum = ((long)(9999999));
            this.probeval.Minimum = ((long)(0));
            this.probeval.Name = "probeval";
            this.probeval.Value = ((long)(5000000));
            // 
            // gunaPanel1
            // 
            resources.ApplyResources(this.gunaPanel1, "gunaPanel1");
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.threadsval);
            this.gunaPanel1.Controls.Add(this.ahz);
            this.gunaPanel1.Controls.Add(this.probeval);
            this.gunaPanel1.Controls.Add(this.abtr);
            this.gunaPanel1.Controls.Add(this.bunifuFlatButton6);
            this.gunaPanel1.Controls.Add(this.passval);
            this.gunaPanel1.Controls.Add(this.bunifuFlatButton5);
            this.gunaPanel1.Controls.Add(this.gunaComboBox2);
            this.gunaPanel1.Controls.Add(this.gunaComboBox3);
            this.gunaPanel1.Controls.Add(this.bunifuFlatButton8);
            this.gunaPanel1.Controls.Add(this.gunaComboBox1);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel10);
            this.gunaPanel1.Controls.Add(this.gunaLabel8);
            this.gunaPanel1.Controls.Add(this.passbtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.abbtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel9);
            this.gunaPanel1.Controls.Add(this.anbtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel13);
            this.gunaPanel1.Controls.Add(this.vnbtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.vprebtn);
            this.gunaPanel1.Controls.Add(this.arbtn);
            this.gunaPanel1.Controls.Add(this.acodec);
            this.gunaPanel1.Controls.Add(this.bunifuFlatButton7);
            this.gunaPanel1.Controls.Add(this.acodecalac);
            this.gunaPanel1.Controls.Add(this.absf);
            this.gunaPanel1.Controls.Add(this.acodeccopy);
            this.gunaPanel1.Controls.Add(this.scodeccopy);
            this.gunaPanel1.Controls.Add(this.vcodeccopy);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // xuiCustomGroupbox1
            // 
            resources.ApplyResources(this.xuiCustomGroupbox1, "xuiCustomGroupbox1");
            this.xuiCustomGroupbox1.BackColor = System.Drawing.Color.Transparent;
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.guna2VSeparator1);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuFlatButton14);
            this.xuiCustomGroupbox1.Controls.Add(this.gunaLabel18);
            this.xuiCustomGroupbox1.Controls.Add(this.gunaLabel17);
            this.xuiCustomGroupbox1.Controls.Add(this.konec);
            this.xuiCustomGroupbox1.Controls.Add(this.nachalo);
            this.xuiCustomGroupbox1.Controls.Add(this.guna2Separator3);
            this.xuiCustomGroupbox1.Controls.Add(this.guna2Separator2);
            this.xuiCustomGroupbox1.Controls.Add(this.guna2Separator1);
            this.xuiCustomGroupbox1.Controls.Add(this.gunaLabel16);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuFlatButton13);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuFlatButton11);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuFlatButton10);
            this.xuiCustomGroupbox1.Controls.Add(this.speedup2);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuFlatButton12);
            this.xuiCustomGroupbox1.Controls.Add(this.gunaLabel15);
            this.xuiCustomGroupbox1.Cursor = System.Windows.Forms.Cursors.No;
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2VSeparator1, "guna2VSeparator1");
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            // 
            // bunifuFlatButton14
            // 
            this.bunifuFlatButton14.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton14, "bunifuFlatButton14");
            this.bunifuFlatButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton14.BorderRadius = 0;
            this.bunifuFlatButton14.ButtonText = "Cut";
            this.bunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton14.Iconimage = null;
            this.bunifuFlatButton14.Iconimage_right = null;
            this.bunifuFlatButton14.Iconimage_right_Selected = null;
            this.bunifuFlatButton14.Iconimage_Selected = null;
            this.bunifuFlatButton14.IconMarginLeft = 0;
            this.bunifuFlatButton14.IconMarginRight = 0;
            this.bunifuFlatButton14.IconRightVisible = true;
            this.bunifuFlatButton14.IconRightZoom = 0D;
            this.bunifuFlatButton14.IconVisible = true;
            this.bunifuFlatButton14.IconZoom = 90D;
            this.bunifuFlatButton14.IsTab = false;
            this.bunifuFlatButton14.Name = "bunifuFlatButton14";
            this.bunifuFlatButton14.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton14.selected = false;
            this.bunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton14.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton14.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton14.Click += new System.EventHandler(this.bunifuFlatButton14_Click);
            // 
            // gunaLabel18
            // 
            resources.ApplyResources(this.gunaLabel18, "gunaLabel18");
            this.gunaLabel18.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel18.ForeColor = System.Drawing.Color.White;
            this.gunaLabel18.Name = "gunaLabel18";
            // 
            // gunaLabel17
            // 
            resources.ApplyResources(this.gunaLabel17, "gunaLabel17");
            this.gunaLabel17.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel17.ForeColor = System.Drawing.Color.White;
            this.gunaLabel17.Name = "gunaLabel17";
            // 
            // konec
            // 
            this.konec.BackColor = System.Drawing.Color.White;
            this.konec.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.konec.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.konec.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.konec, "konec");
            this.konec.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.konec.ForeColor = System.Drawing.Color.Black;
            this.konec.Name = "konec";
            this.konec.TextInput = "";
            this.konec.TextPreview = "00:05:00";
            this.konec.UseSystemPasswordChar = false;
            // 
            // nachalo
            // 
            this.nachalo.BackColor = System.Drawing.Color.White;
            this.nachalo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.nachalo.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.nachalo.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.nachalo, "nachalo");
            this.nachalo.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.nachalo.ForeColor = System.Drawing.Color.Black;
            this.nachalo.Name = "nachalo";
            this.nachalo.TextInput = "";
            this.nachalo.TextPreview = "00:00:00";
            this.nachalo.UseSystemPasswordChar = false;
            // 
            // guna2Separator3
            // 
            resources.ApplyResources(this.guna2Separator3, "guna2Separator3");
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator3.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator3.Name = "guna2Separator3";
            // 
            // guna2Separator2
            // 
            resources.ApplyResources(this.guna2Separator2, "guna2Separator2");
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator2.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator2.Name = "guna2Separator2";
            // 
            // guna2Separator1
            // 
            resources.ApplyResources(this.guna2Separator1, "guna2Separator1");
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.Name = "guna2Separator1";
            // 
            // gunaLabel16
            // 
            resources.ApplyResources(this.gunaLabel16, "gunaLabel16");
            this.gunaLabel16.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel16.ForeColor = System.Drawing.Color.White;
            this.gunaLabel16.Name = "gunaLabel16";
            // 
            // bunifuFlatButton13
            // 
            this.bunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton13, "bunifuFlatButton13");
            this.bunifuFlatButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton13.BorderRadius = 0;
            this.bunifuFlatButton13.ButtonText = "...";
            this.bunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton13.Iconimage = null;
            this.bunifuFlatButton13.Iconimage_right = null;
            this.bunifuFlatButton13.Iconimage_right_Selected = null;
            this.bunifuFlatButton13.Iconimage_Selected = null;
            this.bunifuFlatButton13.IconMarginLeft = 0;
            this.bunifuFlatButton13.IconMarginRight = 0;
            this.bunifuFlatButton13.IconRightVisible = true;
            this.bunifuFlatButton13.IconRightZoom = 0D;
            this.bunifuFlatButton13.IconVisible = true;
            this.bunifuFlatButton13.IconZoom = 90D;
            this.bunifuFlatButton13.IsTab = false;
            this.bunifuFlatButton13.Name = "bunifuFlatButton13";
            this.bunifuFlatButton13.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton13.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton13.selected = false;
            this.bunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton13.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton13.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton13.Click += new System.EventHandler(this.bunifuFlatButton13_Click);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton11, "bunifuFlatButton11");
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "...";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton11.Click += new System.EventHandler(this.bunifuFlatButton11_Click_1);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton10, "bunifuFlatButton10");
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "SPLIT";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = null;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 90D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton10.Click += new System.EventHandler(this.bunifuFlatButton10_Click_1);
            // 
            // speedup2
            // 
            resources.ApplyResources(this.speedup2, "speedup2");
            this.speedup2.BackColor = System.Drawing.Color.Transparent;
            this.speedup2.BaseColor = System.Drawing.Color.White;
            this.speedup2.BorderColor = System.Drawing.Color.Silver;
            this.speedup2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.speedup2.ButtonForeColor = System.Drawing.Color.Black;
            this.speedup2.ForeColor = System.Drawing.Color.Black;
            this.speedup2.Maximum = ((long)(9999999));
            this.speedup2.Minimum = ((long)(0));
            this.speedup2.Name = "speedup2";
            this.speedup2.Value = ((long)(1));
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.bunifuFlatButton12, "bunifuFlatButton12");
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton12.BorderRadius = 0;
            this.bunifuFlatButton12.ButtonText = "OK";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = null;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 90D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Century Gothic", 8.5F);
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton12_Click);
            // 
            // gunaLabel15
            // 
            resources.ApplyResources(this.gunaLabel15, "gunaLabel15");
            this.gunaLabel15.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel15.ForeColor = System.Drawing.Color.White;
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Click += new System.EventHandler(this.gunaLabel15_Click);
            // 
            // FilesForSplit
            // 
            this.FilesForSplit.FileName = "openFileDialog4";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog1";
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.bunifuSwitch1, "bunifuSwitch1");
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.DarkSalmon;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = false;
            this.bunifuSwitch1.Click += new System.EventHandler(this.bunifuSwitch1_Click);
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BackColor = System.Drawing.Color.Transparent;
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.bunifuSwitch1);
            resources.ApplyResources(this.xuiCustomGroupbox2, "xuiCustomGroupbox2");
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            resources.ApplyResources(this.lToolStripMenuItem, "lToolStripMenuItem");
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Animated = true;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.DefaultText = "";
            this.bunifuMaterialTextbox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuMaterialTextbox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuMaterialTextbox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuMaterialTextbox1.DisabledState.Parent = this.bunifuMaterialTextbox1;
            this.bunifuMaterialTextbox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuMaterialTextbox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.bunifuMaterialTextbox1.FocusedState.Parent = this.bunifuMaterialTextbox1;
            resources.ApplyResources(this.bunifuMaterialTextbox1, "bunifuMaterialTextbox1");
            this.bunifuMaterialTextbox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.bunifuMaterialTextbox1.HoverState.Parent = this.bunifuMaterialTextbox1;
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.PasswordChar = '\0';
            this.bunifuMaterialTextbox1.PlaceholderText = "Input";
            this.bunifuMaterialTextbox1.SelectedText = "";
            this.bunifuMaterialTextbox1.ShadowDecoration.Parent = this.bunifuMaterialTextbox1;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Animated = true;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.DefaultText = "";
            this.bunifuMaterialTextbox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bunifuMaterialTextbox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bunifuMaterialTextbox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuMaterialTextbox2.DisabledState.Parent = this.bunifuMaterialTextbox2;
            this.bunifuMaterialTextbox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bunifuMaterialTextbox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.bunifuMaterialTextbox2.FocusedState.Parent = this.bunifuMaterialTextbox2;
            resources.ApplyResources(this.bunifuMaterialTextbox2, "bunifuMaterialTextbox2");
            this.bunifuMaterialTextbox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.bunifuMaterialTextbox2.HoverState.Parent = this.bunifuMaterialTextbox2;
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.PasswordChar = '\0';
            this.bunifuMaterialTextbox2.PlaceholderText = "Output";
            this.bunifuMaterialTextbox2.SelectedText = "";
            this.bunifuMaterialTextbox2.ShadowDecoration.Parent = this.bunifuMaterialTextbox2;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TBcommand);
            this.Controls.Add(this.vpreLabel14);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.xuiFlatMenuStrip1);
            this.Controls.Add(this.gunaLinePanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.xuiFlatMenuStrip1.ResumeLayout(false);
            this.xuiFlatMenuStrip1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaResize gunaResize1;
        private XanderUI.XUIFlatMenuStrip xuiFlatMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lolToolStripMenuItem;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuFlatButton acodeccopy;
        private Bunifu.Framework.UI.BunifuFlatButton scodeccopy;
        private Bunifu.Framework.UI.BunifuFlatButton vcodeccopy;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton anbtn;
        private Bunifu.Framework.UI.BunifuFlatButton vnbtn;
        private Bunifu.Framework.UI.BunifuFlatButton arbtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TBcommand;
        private Bunifu.Framework.UI.BunifuFlatButton acodecalac;
        private Bunifu.Framework.UI.BunifuFlatButton abbtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Bunifu.Framework.UI.BunifuFlatButton passbtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Bunifu.Framework.UI.BunifuFlatButton acodec;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private Bunifu.Framework.UI.BunifuFlatButton clearbtn;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox3;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private Bunifu.Framework.UI.BunifuFlatButton absf;
        private Guna.UI.WinForms.GunaLabel vpreLabel14;
        private Bunifu.Framework.UI.BunifuFlatButton vprebtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private Guna.UI.WinForms.GunaNumeric passval;
        private Guna.UI.WinForms.GunaNumeric ahz;
        private Guna.UI.WinForms.GunaNumeric abtr;
        private Guna.UI.WinForms.GunaNumeric probeval;
        private Guna.UI.WinForms.GunaNumeric threadsval;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.OpenFileDialog FilesForSplit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton13;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;
        private Guna.UI.WinForms.GunaNumeric speedup2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton12;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private EgoldsUI.EgoldsGoogleTextBox konec;
        private EgoldsUI.EgoldsGoogleTextBox nachalo;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton14;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaLabel gunaLabel17;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator1;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox bunifuMaterialTextbox2;
        private Guna.UI2.WinForms.Guna2TextBox bunifuMaterialTextbox1;
    }
}

