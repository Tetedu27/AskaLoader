namespace AskaBuilder.AskaForms
{
    partial class ProtectorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtectorWindow));
            this.ProtectorBorders = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ProtectorFormAnimation = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.MinimazeBoxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseBoxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.StrongChk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.MediumChk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.LightWeightChk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ProtectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SelectFile1Btn = new Guna.UI2.WinForms.Guna2Button();
            this.FileProtect1Path = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MessageBoxEx = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.HighLabelSupp = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ProtectorBorders
            // 
            this.ProtectorBorders.AnimateWindow = true;
            this.ProtectorBorders.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.ProtectorBorders.ContainerControl = this;
            this.ProtectorBorders.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.ProtectorBorders.DockIndicatorTransparencyValue = 1D;
            this.ProtectorBorders.DragEndTransparencyValue = 0.85D;
            this.ProtectorBorders.DragStartTransparencyValue = 0.85D;
            this.ProtectorBorders.ResizeForm = false;
            this.ProtectorBorders.ShadowColor = System.Drawing.Color.IndianRed;
            this.ProtectorBorders.TransparentWhileDrag = true;
            // 
            // ProtectorFormAnimation
            // 
            this.ProtectorFormAnimation.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE;
            this.ProtectorFormAnimation.TargetForm = this;
            // 
            // MinimazeBoxBtn
            // 
            this.MinimazeBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimazeBoxBtn.Animated = true;
            this.MinimazeBoxBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.MinimazeBoxBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimazeBoxBtn.FillColor = System.Drawing.Color.IndianRed;
            this.MinimazeBoxBtn.IconColor = System.Drawing.Color.White;
            this.MinimazeBoxBtn.Location = new System.Drawing.Point(249, 12);
            this.MinimazeBoxBtn.Name = "MinimazeBoxBtn";
            this.MinimazeBoxBtn.Size = new System.Drawing.Size(45, 29);
            this.MinimazeBoxBtn.TabIndex = 3;
            // 
            // CloseBoxBtn
            // 
            this.CloseBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBoxBtn.Animated = true;
            this.CloseBoxBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.CloseBoxBtn.FillColor = System.Drawing.Color.IndianRed;
            this.CloseBoxBtn.IconColor = System.Drawing.Color.White;
            this.CloseBoxBtn.Location = new System.Drawing.Point(300, 12);
            this.CloseBoxBtn.Name = "CloseBoxBtn";
            this.CloseBoxBtn.Size = new System.Drawing.Size(45, 29);
            this.CloseBoxBtn.TabIndex = 2;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BorderColor = System.Drawing.Color.IndianRed;
            this.MainGroupBox.Controls.Add(this.StrongChk);
            this.MainGroupBox.Controls.Add(this.MediumChk);
            this.MainGroupBox.Controls.Add(this.LightWeightChk);
            this.MainGroupBox.Controls.Add(this.label3);
            this.MainGroupBox.Controls.Add(this.ProtectBtn);
            this.MainGroupBox.Controls.Add(this.SelectFile1Btn);
            this.MainGroupBox.Controls.Add(this.FileProtect1Path);
            this.MainGroupBox.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.MainGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainGroupBox.ForeColor = System.Drawing.Color.White;
            this.MainGroupBox.Location = new System.Drawing.Point(7, 62);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(337, 312);
            this.MainGroupBox.TabIndex = 13;
            this.MainGroupBox.Text = "Protect Window | Auxiliary";
            // 
            // StrongChk
            // 
            this.StrongChk.Animated = true;
            this.StrongChk.AutoSize = true;
            this.StrongChk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.StrongChk.CheckedState.BorderThickness = 0;
            this.StrongChk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.StrongChk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.StrongChk.CheckedState.InnerOffset = -4;
            this.StrongChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StrongChk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StrongChk.Location = new System.Drawing.Point(208, 163);
            this.StrongChk.Name = "StrongChk";
            this.StrongChk.Size = new System.Drawing.Size(113, 24);
            this.StrongChk.TabIndex = 14;
            this.StrongChk.Text = "StrongProtect";
            this.StrongChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.StrongChk.UncheckedState.BorderThickness = 2;
            this.StrongChk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.StrongChk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // MediumChk
            // 
            this.MediumChk.Animated = true;
            this.MediumChk.AutoSize = true;
            this.MediumChk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.MediumChk.CheckedState.BorderThickness = 0;
            this.MediumChk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.MediumChk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.MediumChk.CheckedState.InnerOffset = -4;
            this.MediumChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumChk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MediumChk.Location = new System.Drawing.Point(124, 163);
            this.MediumChk.Name = "MediumChk";
            this.MediumChk.Size = new System.Drawing.Size(78, 24);
            this.MediumChk.TabIndex = 13;
            this.MediumChk.Text = "Medium";
            this.MediumChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MediumChk.UncheckedState.BorderThickness = 2;
            this.MediumChk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.MediumChk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // LightWeightChk
            // 
            this.LightWeightChk.Animated = true;
            this.LightWeightChk.AutoSize = true;
            this.LightWeightChk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.LightWeightChk.CheckedState.BorderThickness = 0;
            this.LightWeightChk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.LightWeightChk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.LightWeightChk.CheckedState.InnerOffset = -4;
            this.LightWeightChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LightWeightChk.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LightWeightChk.Location = new System.Drawing.Point(14, 163);
            this.LightWeightChk.Name = "LightWeightChk";
            this.LightWeightChk.Size = new System.Drawing.Size(104, 24);
            this.LightWeightChk.TabIndex = 12;
            this.LightWeightChk.Text = "LightWeight";
            this.LightWeightChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LightWeightChk.UncheckedState.BorderThickness = 2;
            this.LightWeightChk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.LightWeightChk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Target File ( To Protect )";
            // 
            // ProtectBtn
            // 
            this.ProtectBtn.Animated = true;
            this.ProtectBtn.AnimatedGIF = true;
            this.ProtectBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.ProtectBtn.BorderThickness = 1;
            this.ProtectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProtectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProtectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProtectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProtectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ProtectBtn.Font = new System.Drawing.Font("Segoe UI Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.ProtectBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ProtectBtn.Image = global::AskaBuilder.Properties.Resources.ProtectLogo;
            this.ProtectBtn.ImageOffset = new System.Drawing.Point(-5, 1);
            this.ProtectBtn.ImageSize = new System.Drawing.Size(37, 37);
            this.ProtectBtn.Location = new System.Drawing.Point(29, 214);
            this.ProtectBtn.Name = "ProtectBtn";
            this.ProtectBtn.Size = new System.Drawing.Size(262, 64);
            this.ProtectBtn.TabIndex = 8;
            this.ProtectBtn.Text = "Protect App";
            this.ProtectBtn.Click += new System.EventHandler(this.ProtectBtn_Click);
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
            // FileProtect1Path
            // 
            this.FileProtect1Path.Animated = true;
            this.FileProtect1Path.BorderColor = System.Drawing.Color.IndianRed;
            this.FileProtect1Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileProtect1Path.DefaultText = "";
            this.FileProtect1Path.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileProtect1Path.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileProtect1Path.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileProtect1Path.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileProtect1Path.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FileProtect1Path.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileProtect1Path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileProtect1Path.ForeColor = System.Drawing.Color.LightCoral;
            this.FileProtect1Path.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileProtect1Path.Location = new System.Drawing.Point(14, 87);
            this.FileProtect1Path.Name = "FileProtect1Path";
            this.FileProtect1Path.PasswordChar = '\0';
            this.FileProtect1Path.PlaceholderText = "";
            this.FileProtect1Path.SelectedText = "";
            this.FileProtect1Path.Size = new System.Drawing.Size(238, 36);
            this.FileProtect1Path.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FileProtect1Path.TabIndex = 4;
            this.FileProtect1Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AskaBuilder.Properties.Resources.ProtectVector;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // MessageBoxEx
            // 
            this.MessageBoxEx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxEx.Caption = "~ Information ~";
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
            this.HighLabelSupp.Location = new System.Drawing.Point(72, 18);
            this.HighLabelSupp.Name = "HighLabelSupp";
            this.HighLabelSupp.Size = new System.Drawing.Size(137, 23);
            this.HighLabelSupp.TabIndex = 15;
            this.HighLabelSupp.Text = "Protect Functions";
            // 
            // ProtectorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(357, 386);
            this.Controls.Add(this.HighLabelSupp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.MinimazeBoxBtn);
            this.Controls.Add(this.CloseBoxBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProtectorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ A S K A ] - [ P R O T E C T ] ";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ProtectorBorders;
        private Guna.UI2.WinForms.Guna2AnimateWindow ProtectorFormAnimation;
        private Guna.UI2.WinForms.Guna2ControlBox MinimazeBoxBtn;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBoxBtn;
        private Guna.UI2.WinForms.Guna2GroupBox MainGroupBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button ProtectBtn;
        private Guna.UI2.WinForms.Guna2Button SelectFile1Btn;
        private Guna.UI2.WinForms.Guna2TextBox FileProtect1Path;
        private Guna.UI2.WinForms.Guna2RadioButton LightWeightChk;
        private Guna.UI2.WinForms.Guna2RadioButton StrongChk;
        private Guna.UI2.WinForms.Guna2RadioButton MediumChk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxEx;
        private System.Windows.Forms.Label HighLabelSupp;
    }
}