namespace AskaBuilder.AskaForms
{
    partial class SignWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignWindow));
            this.SignAnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SignWindowBorders = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CloseBoxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimazeBoxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StealCertBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SelectFile2Btn = new Guna.UI2.WinForms.Guna2Button();
            this.FileSign2Path = new Guna.UI2.WinForms.Guna2TextBox();
            this.SelectFile1Btn = new Guna.UI2.WinForms.Guna2Button();
            this.FileSign1Path = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MessageBoxEx = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.HighLabelSupp = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // SignWindowBorders
            // 
            this.SignWindowBorders.AnimateWindow = true;
            this.SignWindowBorders.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_NEGATIVE;
            this.SignWindowBorders.ContainerControl = this;
            this.SignWindowBorders.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.SignWindowBorders.DockIndicatorTransparencyValue = 1D;
            this.SignWindowBorders.DragEndTransparencyValue = 0.85D;
            this.SignWindowBorders.DragStartTransparencyValue = 0.85D;
            this.SignWindowBorders.ResizeForm = false;
            this.SignWindowBorders.ShadowColor = System.Drawing.Color.IndianRed;
            this.SignWindowBorders.TransparentWhileDrag = true;
            // 
            // CloseBoxBtn
            // 
            this.CloseBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBoxBtn.Animated = true;
            this.CloseBoxBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.CloseBoxBtn.FillColor = System.Drawing.Color.IndianRed;
            this.CloseBoxBtn.IconColor = System.Drawing.Color.White;
            this.CloseBoxBtn.Location = new System.Drawing.Point(282, 12);
            this.CloseBoxBtn.Name = "CloseBoxBtn";
            this.CloseBoxBtn.Size = new System.Drawing.Size(45, 29);
            this.CloseBoxBtn.TabIndex = 0;
            // 
            // MinimazeBoxBtn
            // 
            this.MinimazeBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimazeBoxBtn.Animated = true;
            this.MinimazeBoxBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.MinimazeBoxBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimazeBoxBtn.FillColor = System.Drawing.Color.IndianRed;
            this.MinimazeBoxBtn.IconColor = System.Drawing.Color.White;
            this.MinimazeBoxBtn.Location = new System.Drawing.Point(231, 12);
            this.MinimazeBoxBtn.Name = "MinimazeBoxBtn";
            this.MinimazeBoxBtn.Size = new System.Drawing.Size(45, 29);
            this.MinimazeBoxBtn.TabIndex = 1;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BorderColor = System.Drawing.Color.IndianRed;
            this.MainGroupBox.Controls.Add(this.label1);
            this.MainGroupBox.Controls.Add(this.label3);
            this.MainGroupBox.Controls.Add(this.StealCertBtn);
            this.MainGroupBox.Controls.Add(this.SelectFile2Btn);
            this.MainGroupBox.Controls.Add(this.FileSign2Path);
            this.MainGroupBox.Controls.Add(this.SelectFile1Btn);
            this.MainGroupBox.Controls.Add(this.FileSign1Path);
            this.MainGroupBox.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.MainGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainGroupBox.ForeColor = System.Drawing.Color.White;
            this.MainGroupBox.Location = new System.Drawing.Point(12, 69);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(323, 330);
            this.MainGroupBox.TabIndex = 12;
            this.MainGroupBox.Text = "Sign Window | Auxiliary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Legimate File ( Steal Certificate )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Target File ( To Sign )";
            // 
            // StealCertBtn
            // 
            this.StealCertBtn.Animated = true;
            this.StealCertBtn.AnimatedGIF = true;
            this.StealCertBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.StealCertBtn.BorderThickness = 1;
            this.StealCertBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StealCertBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StealCertBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StealCertBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StealCertBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.StealCertBtn.Font = new System.Drawing.Font("Segoe UI Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.StealCertBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.StealCertBtn.Image = global::AskaBuilder.Properties.Resources.CertificateLogo;
            this.StealCertBtn.ImageOffset = new System.Drawing.Point(-5, 1);
            this.StealCertBtn.ImageSize = new System.Drawing.Size(37, 37);
            this.StealCertBtn.Location = new System.Drawing.Point(27, 239);
            this.StealCertBtn.Name = "StealCertBtn";
            this.StealCertBtn.Size = new System.Drawing.Size(262, 64);
            this.StealCertBtn.TabIndex = 8;
            this.StealCertBtn.Text = "Steal Cerificate";
            this.StealCertBtn.Click += new System.EventHandler(this.StealCertBtn_Click);
            // 
            // SelectFile2Btn
            // 
            this.SelectFile2Btn.Animated = true;
            this.SelectFile2Btn.AnimatedGIF = true;
            this.SelectFile2Btn.BorderColor = System.Drawing.Color.IndianRed;
            this.SelectFile2Btn.BorderThickness = 1;
            this.SelectFile2Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectFile2Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectFile2Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectFile2Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectFile2Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SelectFile2Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectFile2Btn.ForeColor = System.Drawing.Color.White;
            this.SelectFile2Btn.Image = global::AskaBuilder.Properties.Resources.SettingsLogo;
            this.SelectFile2Btn.Location = new System.Drawing.Point(258, 164);
            this.SelectFile2Btn.Name = "SelectFile2Btn";
            this.SelectFile2Btn.Size = new System.Drawing.Size(57, 36);
            this.SelectFile2Btn.TabIndex = 7;
            this.SelectFile2Btn.Click += new System.EventHandler(this.SelectFile2Btn_Click);
            // 
            // FileSign2Path
            // 
            this.FileSign2Path.Animated = true;
            this.FileSign2Path.BorderColor = System.Drawing.Color.IndianRed;
            this.FileSign2Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileSign2Path.DefaultText = "";
            this.FileSign2Path.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileSign2Path.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileSign2Path.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileSign2Path.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileSign2Path.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FileSign2Path.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileSign2Path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileSign2Path.ForeColor = System.Drawing.Color.LightCoral;
            this.FileSign2Path.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileSign2Path.Location = new System.Drawing.Point(14, 164);
            this.FileSign2Path.Name = "FileSign2Path";
            this.FileSign2Path.PasswordChar = '\0';
            this.FileSign2Path.PlaceholderText = "";
            this.FileSign2Path.SelectedText = "";
            this.FileSign2Path.Size = new System.Drawing.Size(238, 36);
            this.FileSign2Path.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FileSign2Path.TabIndex = 6;
            this.FileSign2Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectFile1Btn
            // 
            this.SelectFile1Btn.Animated = true;
            this.SelectFile1Btn.AnimatedGIF = true;
            this.SelectFile1Btn.BorderColor = System.Drawing.Color.IndianRed;
            this.SelectFile1Btn.BorderThickness = 1;
            this.SelectFile1Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectFile1Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectFile1Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectFile1Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectFile1Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SelectFile1Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectFile1Btn.ForeColor = System.Drawing.Color.White;
            this.SelectFile1Btn.Image = global::AskaBuilder.Properties.Resources.SettingsLogo;
            this.SelectFile1Btn.Location = new System.Drawing.Point(258, 87);
            this.SelectFile1Btn.Name = "SelectFile1Btn";
            this.SelectFile1Btn.Size = new System.Drawing.Size(57, 36);
            this.SelectFile1Btn.TabIndex = 5;
            this.SelectFile1Btn.Click += new System.EventHandler(this.SelectFile1Btn_Click);
            // 
            // FileSign1Path
            // 
            this.FileSign1Path.Animated = true;
            this.FileSign1Path.BorderColor = System.Drawing.Color.IndianRed;
            this.FileSign1Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileSign1Path.DefaultText = "";
            this.FileSign1Path.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileSign1Path.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileSign1Path.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileSign1Path.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileSign1Path.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FileSign1Path.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileSign1Path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileSign1Path.ForeColor = System.Drawing.Color.LightCoral;
            this.FileSign1Path.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileSign1Path.Location = new System.Drawing.Point(14, 87);
            this.FileSign1Path.Name = "FileSign1Path";
            this.FileSign1Path.PasswordChar = '\0';
            this.FileSign1Path.PlaceholderText = "";
            this.FileSign1Path.SelectedText = "";
            this.FileSign1Path.Size = new System.Drawing.Size(238, 36);
            this.FileSign1Path.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FileSign1Path.TabIndex = 4;
            this.FileSign1Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AskaBuilder.Properties.Resources.SignVector;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // MessageBoxEx
            // 
            this.MessageBoxEx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxEx.Caption = "~ Information Message ~";
            this.MessageBoxEx.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageBoxEx.Parent = this;
            this.MessageBoxEx.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageBoxEx.Text = null;
            // 
            // HighLabelSupp
            // 
            this.HighLabelSupp.AutoSize = true;
            this.HighLabelSupp.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Italic);
            this.HighLabelSupp.ForeColor = System.Drawing.Color.IndianRed;
            this.HighLabelSupp.Location = new System.Drawing.Point(74, 18);
            this.HighLabelSupp.Name = "HighLabelSupp";
            this.HighLabelSupp.Size = new System.Drawing.Size(84, 23);
            this.HighLabelSupp.TabIndex = 16;
            this.HighLabelSupp.Text = "Sign Form";
            // 
            // SignWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(349, 427);
            this.Controls.Add(this.HighLabelSupp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.MinimazeBoxBtn);
            this.Controls.Add(this.CloseBoxBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[ A S K A ] - [ S I G N ] ";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow SignAnimateWindow;
        private Guna.UI2.WinForms.Guna2BorderlessForm SignWindowBorders;
        private Guna.UI2.WinForms.Guna2ControlBox MinimazeBoxBtn;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBoxBtn;
        private Guna.UI2.WinForms.Guna2GroupBox MainGroupBox;
        private Guna.UI2.WinForms.Guna2TextBox FileSign1Path;
        private Guna.UI2.WinForms.Guna2Button SelectFile2Btn;
        private Guna.UI2.WinForms.Guna2TextBox FileSign2Path;
        private Guna.UI2.WinForms.Guna2Button SelectFile1Btn;
        private Guna.UI2.WinForms.Guna2Button StealCertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxEx;
        private System.Windows.Forms.Label HighLabelSupp;
    }
}