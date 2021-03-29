namespace FFmpegTGUI.Updater
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
                components.Dispose();
            }
            base.Dispose(disposing);
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
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeBoxC = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeBoxC = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TextLabel = new Guna.UI.WinForms.GunaLabel();
            this.CloseBoxC = new Guna.UI2.WinForms.Guna2ControlBox();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.progressbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.LabelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Controls.Add(this.MinimizeBoxC);
            this.TopPanel.Controls.Add(this.MaximizeBoxC);
            this.TopPanel.Controls.Add(this.TextLabel);
            this.TopPanel.Controls.Add(this.CloseBoxC);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(444, 30);
            this.TopPanel.TabIndex = 0;
            // 
            // MinimizeBoxC
            // 
            this.MinimizeBoxC.Animated = true;
            this.MinimizeBoxC.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBoxC.FillColor = System.Drawing.Color.White;
            this.MinimizeBoxC.HoverState.Parent = this.MinimizeBoxC;
            this.MinimizeBoxC.IconColor = System.Drawing.Color.Black;
            this.MinimizeBoxC.Location = new System.Drawing.Point(309, 0);
            this.MinimizeBoxC.Name = "MinimizeBoxC";
            this.MinimizeBoxC.PressedColor = System.Drawing.Color.Gainsboro;
            this.MinimizeBoxC.ShadowDecoration.Parent = this.MinimizeBoxC;
            this.MinimizeBoxC.Size = new System.Drawing.Size(45, 30);
            this.MinimizeBoxC.TabIndex = 7;
            // 
            // MaximizeBoxC
            // 
            this.MaximizeBoxC.Animated = true;
            this.MaximizeBoxC.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.MaximizeBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeBoxC.Enabled = false;
            this.MaximizeBoxC.FillColor = System.Drawing.Color.White;
            this.MaximizeBoxC.HoverState.Parent = this.MaximizeBoxC;
            this.MaximizeBoxC.IconColor = System.Drawing.Color.Black;
            this.MaximizeBoxC.Location = new System.Drawing.Point(354, 0);
            this.MaximizeBoxC.Name = "MaximizeBoxC";
            this.MaximizeBoxC.PressedColor = System.Drawing.Color.Gainsboro;
            this.MaximizeBoxC.ShadowDecoration.Parent = this.MaximizeBoxC;
            this.MaximizeBoxC.Size = new System.Drawing.Size(45, 30);
            this.MaximizeBoxC.TabIndex = 6;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextLabel.Location = new System.Drawing.Point(3, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(59, 15);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "{this.Text}";
            // 
            // CloseBoxC
            // 
            this.CloseBoxC.Animated = true;
            this.CloseBoxC.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBoxC.FillColor = System.Drawing.Color.White;
            this.CloseBoxC.HoverState.Parent = this.CloseBoxC;
            this.CloseBoxC.IconColor = System.Drawing.Color.Black;
            this.CloseBoxC.Location = new System.Drawing.Point(399, 0);
            this.CloseBoxC.Name = "CloseBoxC";
            this.CloseBoxC.PressedColor = System.Drawing.Color.Gainsboro;
            this.CloseBoxC.ShadowDecoration.Parent = this.CloseBoxC;
            this.CloseBoxC.Size = new System.Drawing.Size(45, 30);
            this.CloseBoxC.TabIndex = 5;
            // 
            // FormDrag
            // 
            this.FormDrag.ContainerControl = this;
            this.FormDrag.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormDrag.TargetControl = this.TopPanel;
            this.FormDrag.TransparentWhileDrag = true;
            this.FormDrag.UseTransparentDrag = true;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.Transparent;
            this.progressbar.BorderColor = System.Drawing.Color.Transparent;
            this.progressbar.BorderRadius = 4;
            this.progressbar.FillColor = System.Drawing.Color.Transparent;
            this.progressbar.Font = new System.Drawing.Font("Lato Hairline", 8F);
            this.progressbar.ForeColor = System.Drawing.Color.Black;
            this.progressbar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressbar.Location = new System.Drawing.Point(12, 113);
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressColor = System.Drawing.Color.SeaGreen;
            this.progressbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.progressbar.ShadowDecoration.Parent = this.progressbar;
            this.progressbar.Size = new System.Drawing.Size(420, 10);
            this.progressbar.TabIndex = 1;
            this.progressbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressbar.UseWaitCursor = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(235)))), ((int)(((byte)(129)))));
            this.guna2Button1.BorderRadius = 1;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(136, 146);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(173, 33);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Download Last Version";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 42);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(420, 29);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Last Version";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDrag
            // 
            this.LabelDrag.ContainerControl = this;
            this.LabelDrag.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LabelDrag.TargetControl = this.TextLabel;
            this.LabelDrag.TransparentWhileDrag = true;
            this.LabelDrag.UseTransparentDrag = true;
            // 
            // FormShadow
            // 
            this.FormShadow.BorderRadius = 0;
            this.FormShadow.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormShadow.TargetForm = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 201);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFmpegTGUI.Updater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBoxC;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBoxC;
        private Guna.UI.WinForms.GunaLabel TextLabel;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBoxC;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2ProgressBar progressbar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2DragControl LabelDrag;
        private Guna.UI2.WinForms.Guna2ShadowForm FormShadow;
    }
}

