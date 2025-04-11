namespace AskaBuilder
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.AnimateDeamon = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.BorderDaemon = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CloseBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MinimazeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ClearBoxesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EncryptFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FileEncryptPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.EncryptionXorKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.UrlFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.SoftwareNotify = new System.Windows.Forms.Label();
            this.Obfuscation_Chk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.InjectProcessBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GenerateMutexBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MutexBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MutexControl_Chk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SelfDelete_Chk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AntiAnalysis_Chk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.AntiAnyRun_Chk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BuildXorKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.BuildBtn = new Guna.UI2.WinForms.Guna2Button();
            this.OpenAboutForm = new System.Windows.Forms.Label();
            this.OpenProtectorForm = new System.Windows.Forms.Label();
            this.OpenSignForm = new System.Windows.Forms.Label();
            this.XorGenTimer = new System.Windows.Forms.Timer(this.components);
            this.MessageBoxEx = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SelectIconBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CloneAssemblyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.UsePackerChk = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimateDeamon
            // 
            this.AnimateDeamon.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            this.AnimateDeamon.TargetForm = this;
            // 
            // BorderDaemon
            // 
            this.BorderDaemon.AnimateWindow = true;
            this.BorderDaemon.ContainerControl = this;
            this.BorderDaemon.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.BorderDaemon.DockIndicatorTransparencyValue = 0.6D;
            this.BorderDaemon.DragStartTransparencyValue = 0.75D;
            this.BorderDaemon.ResizeForm = false;
            this.BorderDaemon.ShadowColor = System.Drawing.Color.IndianRed;
            this.BorderDaemon.TransparentWhileDrag = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.BorderColor = System.Drawing.Color.RosyBrown;
            this.CloseBtn.FillColor = System.Drawing.Color.IndianRed;
            this.CloseBtn.IconColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(807, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 29);
            this.CloseBtn.TabIndex = 0;
            // 
            // MinimazeBtn
            // 
            this.MinimazeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimazeBtn.Animated = true;
            this.MinimazeBtn.BorderColor = System.Drawing.Color.RosyBrown;
            this.MinimazeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimazeBtn.FillColor = System.Drawing.Color.IndianRed;
            this.MinimazeBtn.IconColor = System.Drawing.Color.White;
            this.MinimazeBtn.Location = new System.Drawing.Point(743, 12);
            this.MinimazeBtn.Name = "MinimazeBtn";
            this.MinimazeBtn.Size = new System.Drawing.Size(45, 29);
            this.MinimazeBtn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aska Loader V 1.0";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox2.Controls.Add(this.ClearBoxesBtn);
            this.guna2GroupBox2.Controls.Add(this.EncryptFileBtn);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.SelectFileBtn);
            this.guna2GroupBox2.Controls.Add(this.FileEncryptPath);
            this.guna2GroupBox2.Controls.Add(this.EncryptionXorKey);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(451, 57);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(412, 262);
            this.guna2GroupBox2.TabIndex = 10;
            this.guna2GroupBox2.Text = "Stub Encrypt | Crypto";
            // 
            // ClearBoxesBtn
            // 
            this.ClearBoxesBtn.Animated = true;
            this.ClearBoxesBtn.AnimatedGIF = true;
            this.ClearBoxesBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.ClearBoxesBtn.BorderThickness = 1;
            this.ClearBoxesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearBoxesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearBoxesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearBoxesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearBoxesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClearBoxesBtn.Font = new System.Drawing.Font("Segoe UI Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.ClearBoxesBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClearBoxesBtn.Image = global::AskaBuilder.Properties.Resources.CleanLogo;
            this.ClearBoxesBtn.ImageOffset = new System.Drawing.Point(-5, 1);
            this.ClearBoxesBtn.ImageSize = new System.Drawing.Size(37, 37);
            this.ClearBoxesBtn.Location = new System.Drawing.Point(11, 206);
            this.ClearBoxesBtn.Name = "ClearBoxesBtn";
            this.ClearBoxesBtn.Size = new System.Drawing.Size(189, 45);
            this.ClearBoxesBtn.TabIndex = 8;
            this.ClearBoxesBtn.Text = "Clear";
            this.ClearBoxesBtn.Click += new System.EventHandler(this.ClearBoxesBtn_Click);
            // 
            // EncryptFileBtn
            // 
            this.EncryptFileBtn.Animated = true;
            this.EncryptFileBtn.AnimatedGIF = true;
            this.EncryptFileBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.EncryptFileBtn.BorderThickness = 1;
            this.EncryptFileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EncryptFileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EncryptFileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EncryptFileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EncryptFileBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EncryptFileBtn.Font = new System.Drawing.Font("Segoe UI Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.EncryptFileBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EncryptFileBtn.Image = global::AskaBuilder.Properties.Resources.LockPng;
            this.EncryptFileBtn.ImageOffset = new System.Drawing.Point(-5, 1);
            this.EncryptFileBtn.ImageSize = new System.Drawing.Size(37, 37);
            this.EncryptFileBtn.Location = new System.Drawing.Point(210, 206);
            this.EncryptFileBtn.Name = "EncryptFileBtn";
            this.EncryptFileBtn.Size = new System.Drawing.Size(189, 45);
            this.EncryptFileBtn.TabIndex = 6;
            this.EncryptFileBtn.Text = "Encrypt";
            this.EncryptFileBtn.Click += new System.EventHandler(this.EncryptFileBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crypto Form ( Encrypt stub ) - Algorithm: XOR";
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Animated = true;
            this.SelectFileBtn.AnimatedGIF = true;
            this.SelectFileBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.SelectFileBtn.BorderThickness = 1;
            this.SelectFileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectFileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectFileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectFileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectFileBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SelectFileBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectFileBtn.ForeColor = System.Drawing.Color.White;
            this.SelectFileBtn.Image = global::AskaBuilder.Properties.Resources.SelectFile;
            this.SelectFileBtn.Location = new System.Drawing.Point(342, 102);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(57, 36);
            this.SelectFileBtn.TabIndex = 2;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // FileEncryptPath
            // 
            this.FileEncryptPath.Animated = true;
            this.FileEncryptPath.BorderColor = System.Drawing.Color.IndianRed;
            this.FileEncryptPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileEncryptPath.DefaultText = "";
            this.FileEncryptPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileEncryptPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileEncryptPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileEncryptPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileEncryptPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FileEncryptPath.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileEncryptPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileEncryptPath.ForeColor = System.Drawing.Color.LightCoral;
            this.FileEncryptPath.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.FileEncryptPath.Location = new System.Drawing.Point(19, 102);
            this.FileEncryptPath.Name = "FileEncryptPath";
            this.FileEncryptPath.PasswordChar = '\0';
            this.FileEncryptPath.PlaceholderText = "";
            this.FileEncryptPath.SelectedText = "";
            this.FileEncryptPath.Size = new System.Drawing.Size(318, 36);
            this.FileEncryptPath.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FileEncryptPath.TabIndex = 3;
            this.FileEncryptPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EncryptionXorKey
            // 
            this.EncryptionXorKey.Animated = true;
            this.EncryptionXorKey.BorderColor = System.Drawing.Color.IndianRed;
            this.EncryptionXorKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EncryptionXorKey.DefaultText = "";
            this.EncryptionXorKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EncryptionXorKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EncryptionXorKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EncryptionXorKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EncryptionXorKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EncryptionXorKey.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.EncryptionXorKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EncryptionXorKey.ForeColor = System.Drawing.Color.LightCoral;
            this.EncryptionXorKey.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.EncryptionXorKey.Location = new System.Drawing.Point(18, 155);
            this.EncryptionXorKey.Name = "EncryptionXorKey";
            this.EncryptionXorKey.PasswordChar = '\0';
            this.EncryptionXorKey.PlaceholderText = "";
            this.EncryptionXorKey.SelectedText = "";
            this.EncryptionXorKey.Size = new System.Drawing.Size(381, 37);
            this.EncryptionXorKey.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.EncryptionXorKey.TabIndex = 1;
            this.EncryptionXorKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UrlFile
            // 
            this.UrlFile.Animated = true;
            this.UrlFile.BorderColor = System.Drawing.Color.IndianRed;
            this.UrlFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UrlFile.DefaultText = "";
            this.UrlFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UrlFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UrlFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UrlFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UrlFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UrlFile.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.UrlFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlFile.ForeColor = System.Drawing.Color.LightCoral;
            this.UrlFile.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.UrlFile.Location = new System.Drawing.Point(16, 77);
            this.UrlFile.Name = "UrlFile";
            this.UrlFile.PasswordChar = '\0';
            this.UrlFile.PlaceholderForeColor = System.Drawing.Color.IndianRed;
            this.UrlFile.PlaceholderText = "";
            this.UrlFile.SelectedText = "";
            this.UrlFile.Size = new System.Drawing.Size(384, 36);
            this.UrlFile.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UrlFile.TabIndex = 0;
            this.UrlFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SoftwareNotify
            // 
            this.SoftwareNotify.AutoSize = true;
            this.SoftwareNotify.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoftwareNotify.ForeColor = System.Drawing.Color.Gray;
            this.SoftwareNotify.Location = new System.Drawing.Point(14, 54);
            this.SoftwareNotify.Name = "SoftwareNotify";
            this.SoftwareNotify.Size = new System.Drawing.Size(118, 20);
            this.SoftwareNotify.TabIndex = 7;
            this.SoftwareNotify.Text = "File to load | URL";
            // 
            // Obfuscation_Chk
            // 
            this.Obfuscation_Chk.Animated = true;
            this.Obfuscation_Chk.AutoSize = true;
            this.Obfuscation_Chk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.Obfuscation_Chk.CheckedState.BorderRadius = 0;
            this.Obfuscation_Chk.CheckedState.BorderThickness = 0;
            this.Obfuscation_Chk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.Obfuscation_Chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Obfuscation_Chk.Location = new System.Drawing.Point(16, 314);
            this.Obfuscation_Chk.Name = "Obfuscation_Chk";
            this.Obfuscation_Chk.Size = new System.Drawing.Size(106, 25);
            this.Obfuscation_Chk.TabIndex = 9;
            this.Obfuscation_Chk.Text = "Obfuscator";
            this.Obfuscation_Chk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Obfuscation_Chk.UncheckedState.BorderRadius = 0;
            this.Obfuscation_Chk.UncheckedState.BorderThickness = 0;
            this.Obfuscation_Chk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox1.Controls.Add(this.UsePackerChk);
            this.guna2GroupBox1.Controls.Add(this.InjectProcessBox);
            this.guna2GroupBox1.Controls.Add(this.GenerateMutexBtn);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.MutexBox);
            this.guna2GroupBox1.Controls.Add(this.MutexControl_Chk);
            this.guna2GroupBox1.Controls.Add(this.SelfDelete_Chk);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.AntiAnalysis_Chk);
            this.guna2GroupBox1.Controls.Add(this.AntiAnyRun_Chk);
            this.guna2GroupBox1.Controls.Add(this.pictureBox2);
            this.guna2GroupBox1.Controls.Add(this.BuildXorKey);
            this.guna2GroupBox1.Controls.Add(this.Obfuscation_Chk);
            this.guna2GroupBox1.Controls.Add(this.SoftwareNotify);
            this.guna2GroupBox1.Controls.Add(this.BuildBtn);
            this.guna2GroupBox1.Controls.Add(this.UrlFile);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 57);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(412, 450);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Loader Settings | Modules";
            // 
            // InjectProcessBox
            // 
            this.InjectProcessBox.BackColor = System.Drawing.Color.Transparent;
            this.InjectProcessBox.BorderColor = System.Drawing.Color.IndianRed;
            this.InjectProcessBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.InjectProcessBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InjectProcessBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InjectProcessBox.FocusedColor = System.Drawing.Color.RosyBrown;
            this.InjectProcessBox.FocusedState.BorderColor = System.Drawing.Color.RosyBrown;
            this.InjectProcessBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InjectProcessBox.ForeColor = System.Drawing.Color.LightCoral;
            this.InjectProcessBox.ItemHeight = 30;
            this.InjectProcessBox.Items.AddRange(new object[] {
            "RegSvcs.exe",
            "csc.exe",
            "RegAsm.exe",
            "CasPol.exe",
            "dfsvc.exe",
            "InstallUtil.exe",
            "jsc.exe",
            "cvtres.exe",
            "MSBuild.exe",
            "AddInUtil.exe",
            "aspnet_compiler.exe",
            "ngen.exe",
            "vbc.exe",
            "ComSvcConfig.exe",
            "AppLaunch.exe"});
            this.InjectProcessBox.Location = new System.Drawing.Point(19, 268);
            this.InjectProcessBox.Name = "InjectProcessBox";
            this.InjectProcessBox.Size = new System.Drawing.Size(238, 36);
            this.InjectProcessBox.TabIndex = 19;
            // 
            // GenerateMutexBtn
            // 
            this.GenerateMutexBtn.Animated = true;
            this.GenerateMutexBtn.AnimatedGIF = true;
            this.GenerateMutexBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.GenerateMutexBtn.BorderThickness = 1;
            this.GenerateMutexBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateMutexBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateMutexBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateMutexBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateMutexBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.GenerateMutexBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GenerateMutexBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateMutexBtn.Image = global::AskaBuilder.Properties.Resources.GenerateLogo;
            this.GenerateMutexBtn.Location = new System.Drawing.Point(343, 220);
            this.GenerateMutexBtn.Name = "GenerateMutexBtn";
            this.GenerateMutexBtn.Size = new System.Drawing.Size(57, 36);
            this.GenerateMutexBtn.TabIndex = 9;
            this.GenerateMutexBtn.Click += new System.EventHandler(this.GenerateMutexBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(15, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mutex ( Need enabled checkbox )";
            // 
            // MutexBox
            // 
            this.MutexBox.Animated = true;
            this.MutexBox.BorderColor = System.Drawing.Color.IndianRed;
            this.MutexBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MutexBox.DefaultText = "";
            this.MutexBox.DisabledState.BorderColor = System.Drawing.Color.IndianRed;
            this.MutexBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MutexBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MutexBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.LightCoral;
            this.MutexBox.Enabled = false;
            this.MutexBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MutexBox.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.MutexBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MutexBox.ForeColor = System.Drawing.Color.LightCoral;
            this.MutexBox.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.MutexBox.Location = new System.Drawing.Point(18, 220);
            this.MutexBox.Name = "MutexBox";
            this.MutexBox.PasswordChar = '\0';
            this.MutexBox.PlaceholderText = "";
            this.MutexBox.SelectedText = "";
            this.MutexBox.Size = new System.Drawing.Size(316, 36);
            this.MutexBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MutexBox.TabIndex = 17;
            this.MutexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MutexControl_Chk
            // 
            this.MutexControl_Chk.Animated = true;
            this.MutexControl_Chk.AutoSize = true;
            this.MutexControl_Chk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.MutexControl_Chk.CheckedState.BorderRadius = 0;
            this.MutexControl_Chk.CheckedState.BorderThickness = 0;
            this.MutexControl_Chk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.MutexControl_Chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MutexControl_Chk.Location = new System.Drawing.Point(16, 376);
            this.MutexControl_Chk.Name = "MutexControl_Chk";
            this.MutexControl_Chk.Size = new System.Drawing.Size(129, 25);
            this.MutexControl_Chk.TabIndex = 16;
            this.MutexControl_Chk.Text = "Mutex-Control";
            this.MutexControl_Chk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MutexControl_Chk.UncheckedState.BorderRadius = 0;
            this.MutexControl_Chk.UncheckedState.BorderThickness = 0;
            this.MutexControl_Chk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MutexControl_Chk.CheckedChanged += new System.EventHandler(this.MutexControl_Chk_CheckedChanged);
            // 
            // SelfDelete_Chk
            // 
            this.SelfDelete_Chk.Animated = true;
            this.SelfDelete_Chk.AutoSize = true;
            this.SelfDelete_Chk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.SelfDelete_Chk.CheckedState.BorderRadius = 0;
            this.SelfDelete_Chk.CheckedState.BorderThickness = 0;
            this.SelfDelete_Chk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.SelfDelete_Chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelfDelete_Chk.Location = new System.Drawing.Point(271, 268);
            this.SelfDelete_Chk.Name = "SelfDelete_Chk";
            this.SelfDelete_Chk.Size = new System.Drawing.Size(104, 25);
            this.SelfDelete_Chk.TabIndex = 15;
            this.SelfDelete_Chk.Text = "Self-Delete";
            this.SelfDelete_Chk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SelfDelete_Chk.UncheckedState.BorderRadius = 0;
            this.SelfDelete_Chk.UncheckedState.BorderThickness = 0;
            this.SelfDelete_Chk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Xor Key ( Randomization )";
            // 
            // AntiAnalysis_Chk
            // 
            this.AntiAnalysis_Chk.Animated = true;
            this.AntiAnalysis_Chk.AutoSize = true;
            this.AntiAnalysis_Chk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.AntiAnalysis_Chk.CheckedState.BorderRadius = 0;
            this.AntiAnalysis_Chk.CheckedState.BorderThickness = 0;
            this.AntiAnalysis_Chk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.AntiAnalysis_Chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntiAnalysis_Chk.Location = new System.Drawing.Point(16, 345);
            this.AntiAnalysis_Chk.Name = "AntiAnalysis_Chk";
            this.AntiAnalysis_Chk.Size = new System.Drawing.Size(119, 25);
            this.AntiAnalysis_Chk.TabIndex = 13;
            this.AntiAnalysis_Chk.Text = "Anti-Analysis";
            this.AntiAnalysis_Chk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AntiAnalysis_Chk.UncheckedState.BorderRadius = 0;
            this.AntiAnalysis_Chk.UncheckedState.BorderThickness = 0;
            this.AntiAnalysis_Chk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // AntiAnyRun_Chk
            // 
            this.AntiAnyRun_Chk.Animated = true;
            this.AntiAnyRun_Chk.AutoSize = true;
            this.AntiAnyRun_Chk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.AntiAnyRun_Chk.CheckedState.BorderRadius = 0;
            this.AntiAnyRun_Chk.CheckedState.BorderThickness = 0;
            this.AntiAnyRun_Chk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.AntiAnyRun_Chk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntiAnyRun_Chk.Location = new System.Drawing.Point(271, 299);
            this.AntiAnyRun_Chk.Name = "AntiAnyRun_Chk";
            this.AntiAnyRun_Chk.Size = new System.Drawing.Size(117, 25);
            this.AntiAnyRun_Chk.TabIndex = 12;
            this.AntiAnyRun_Chk.Text = "Anti-AnyRun";
            this.AntiAnyRun_Chk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AntiAnyRun_Chk.UncheckedState.BorderRadius = 0;
            this.AntiAnyRun_Chk.UncheckedState.BorderThickness = 0;
            this.AntiAnyRun_Chk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AskaBuilder.Properties.Resources.SignDeveloper;
            this.pictureBox2.Location = new System.Drawing.Point(11, 403);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // BuildXorKey
            // 
            this.BuildXorKey.Animated = true;
            this.BuildXorKey.BorderColor = System.Drawing.Color.IndianRed;
            this.BuildXorKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BuildXorKey.DefaultText = "";
            this.BuildXorKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BuildXorKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BuildXorKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BuildXorKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BuildXorKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BuildXorKey.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.BuildXorKey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuildXorKey.ForeColor = System.Drawing.Color.LightCoral;
            this.BuildXorKey.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.BuildXorKey.Location = new System.Drawing.Point(16, 149);
            this.BuildXorKey.Name = "BuildXorKey";
            this.BuildXorKey.PasswordChar = '\0';
            this.BuildXorKey.PlaceholderText = "";
            this.BuildXorKey.SelectedText = "";
            this.BuildXorKey.Size = new System.Drawing.Size(384, 36);
            this.BuildXorKey.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BuildXorKey.TabIndex = 10;
            this.BuildXorKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuildBtn
            // 
            this.BuildBtn.Animated = true;
            this.BuildBtn.AnimatedGIF = true;
            this.BuildBtn.BackColor = System.Drawing.Color.Transparent;
            this.BuildBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.BuildBtn.BorderThickness = 1;
            this.BuildBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuildBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuildBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuildBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuildBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BuildBtn.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BuildBtn.Image = global::AskaBuilder.Properties.Resources._2;
            this.BuildBtn.ImageOffset = new System.Drawing.Point(-7, 0);
            this.BuildBtn.ImageSize = new System.Drawing.Size(38, 38);
            this.BuildBtn.Location = new System.Drawing.Point(168, 383);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.ShadowDecoration.Color = System.Drawing.Color.LightCoral;
            this.BuildBtn.Size = new System.Drawing.Size(232, 53);
            this.BuildBtn.TabIndex = 6;
            this.BuildBtn.Text = "BUILD";
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // OpenAboutForm
            // 
            this.OpenAboutForm.AutoSize = true;
            this.OpenAboutForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenAboutForm.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenAboutForm.ForeColor = System.Drawing.Color.IndianRed;
            this.OpenAboutForm.Location = new System.Drawing.Point(685, 20);
            this.OpenAboutForm.Name = "OpenAboutForm";
            this.OpenAboutForm.Size = new System.Drawing.Size(52, 21);
            this.OpenAboutForm.TabIndex = 12;
            this.OpenAboutForm.Text = "About";
            this.OpenAboutForm.Click += new System.EventHandler(this.OpenAboutForm_Click);
            // 
            // OpenProtectorForm
            // 
            this.OpenProtectorForm.AutoSize = true;
            this.OpenProtectorForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenProtectorForm.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenProtectorForm.ForeColor = System.Drawing.Color.IndianRed;
            this.OpenProtectorForm.Location = new System.Drawing.Point(421, 20);
            this.OpenProtectorForm.Name = "OpenProtectorForm";
            this.OpenProtectorForm.Size = new System.Drawing.Size(129, 21);
            this.OpenProtectorForm.TabIndex = 13;
            this.OpenProtectorForm.Text = "Protector ( Click )\r\n";
            this.OpenProtectorForm.Click += new System.EventHandler(this.OpenProtectorForm_Click);
            // 
            // OpenSignForm
            // 
            this.OpenSignForm.AutoSize = true;
            this.OpenSignForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenSignForm.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenSignForm.ForeColor = System.Drawing.Color.IndianRed;
            this.OpenSignForm.Location = new System.Drawing.Point(556, 20);
            this.OpenSignForm.Name = "OpenSignForm";
            this.OpenSignForm.Size = new System.Drawing.Size(123, 21);
            this.OpenSignForm.TabIndex = 14;
            this.OpenSignForm.Text = "Sign File ( Click )\r\n";
            this.OpenSignForm.Click += new System.EventHandler(this.OpenSignForm_Click);
            // 
            // MessageBoxEx
            // 
            this.MessageBoxEx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxEx.Caption = "Builder Information";
            this.MessageBoxEx.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageBoxEx.Parent = this;
            this.MessageBoxEx.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageBoxEx.Text = null;
            // 
            // SelectIconBtn
            // 
            this.SelectIconBtn.Animated = true;
            this.SelectIconBtn.AnimatedGIF = true;
            this.SelectIconBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.SelectIconBtn.BorderThickness = 1;
            this.SelectIconBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectIconBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectIconBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectIconBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectIconBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SelectIconBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectIconBtn.ForeColor = System.Drawing.Color.White;
            this.SelectIconBtn.Image = global::AskaBuilder.Properties.Resources.EngineLogo;
            this.SelectIconBtn.Location = new System.Drawing.Point(139, 103);
            this.SelectIconBtn.Name = "SelectIconBtn";
            this.SelectIconBtn.Size = new System.Drawing.Size(119, 53);
            this.SelectIconBtn.TabIndex = 7;
            this.SelectIconBtn.Text = "Select Icon";
            this.SelectIconBtn.Click += new System.EventHandler(this.SelectIconBtn_Click);
            // 
            // CloneAssemblyBtn
            // 
            this.CloneAssemblyBtn.Animated = true;
            this.CloneAssemblyBtn.AnimatedGIF = true;
            this.CloneAssemblyBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.CloneAssemblyBtn.BorderThickness = 1;
            this.CloneAssemblyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloneAssemblyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloneAssemblyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloneAssemblyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloneAssemblyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloneAssemblyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloneAssemblyBtn.ForeColor = System.Drawing.Color.White;
            this.CloneAssemblyBtn.Image = global::AskaBuilder.Properties.Resources.AssemblyLogo;
            this.CloneAssemblyBtn.Location = new System.Drawing.Point(270, 103);
            this.CloneAssemblyBtn.Name = "CloneAssemblyBtn";
            this.CloneAssemblyBtn.Size = new System.Drawing.Size(129, 53);
            this.CloneAssemblyBtn.TabIndex = 6;
            this.CloneAssemblyBtn.Text = "Clone Assembly";
            this.CloneAssemblyBtn.Click += new System.EventHandler(this.CloneAssemblyBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(135, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "File Customization ( Icon | Assembly )";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox3.Controls.Add(this.IconBox);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.SelectIconBtn);
            this.guna2GroupBox3.Controls.Add(this.CloneAssemblyBtn);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox3.Location = new System.Drawing.Point(451, 333);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(412, 174);
            this.guna2GroupBox3.TabIndex = 11;
            this.guna2GroupBox3.Text = "File Settings | Manager";
            // 
            // IconBox
            // 
            this.IconBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IconBox.Location = new System.Drawing.Point(15, 59);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(100, 94);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconBox.TabIndex = 9;
            this.IconBox.TabStop = false;
            // 
            // UsePackerChk
            // 
            this.UsePackerChk.Animated = true;
            this.UsePackerChk.AutoSize = true;
            this.UsePackerChk.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.UsePackerChk.CheckedState.BorderRadius = 0;
            this.UsePackerChk.CheckedState.BorderThickness = 0;
            this.UsePackerChk.CheckedState.FillColor = System.Drawing.Color.IndianRed;
            this.UsePackerChk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsePackerChk.Location = new System.Drawing.Point(168, 345);
            this.UsePackerChk.Name = "UsePackerChk";
            this.UsePackerChk.Size = new System.Drawing.Size(201, 25);
            this.UsePackerChk.TabIndex = 20;
            this.UsePackerChk.Text = "Packer(AMSI/ETW Patch)";
            this.UsePackerChk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.UsePackerChk.UncheckedState.BorderRadius = 0;
            this.UsePackerChk.UncheckedState.BorderThickness = 0;
            this.UsePackerChk.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(875, 519);
            this.Controls.Add(this.OpenSignForm);
            this.Controls.Add(this.OpenProtectorForm);
            this.Controls.Add(this.OpenAboutForm);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.MinimazeBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aska Loader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AnimateDeamon;
        private Guna.UI2.WinForms.Guna2BorderlessForm BorderDaemon;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBtn;
        private Guna.UI2.WinForms.Guna2ControlBox MinimazeBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button EncryptFileBtn;
        private Guna.UI2.WinForms.Guna2Button SelectFileBtn;
        private Guna.UI2.WinForms.Guna2TextBox FileEncryptPath;
        private Guna.UI2.WinForms.Guna2TextBox EncryptionXorKey;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox AntiAnalysis_Chk;
        private Guna.UI2.WinForms.Guna2CheckBox AntiAnyRun_Chk;
        private Guna.UI2.WinForms.Guna2TextBox BuildXorKey;
        private Guna.UI2.WinForms.Guna2CheckBox Obfuscation_Chk;
        private System.Windows.Forms.Label SoftwareNotify;
        private Guna.UI2.WinForms.Guna2Button BuildBtn;
        private Guna.UI2.WinForms.Guna2TextBox UrlFile;
        private Guna.UI2.WinForms.Guna2Button SelectIconBtn;
        private Guna.UI2.WinForms.Guna2Button CloneAssemblyBtn;
        private System.Windows.Forms.Label OpenAboutForm;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CheckBox SelfDelete_Chk;
        private Guna.UI2.WinForms.Guna2CheckBox MutexControl_Chk;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox MutexBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label OpenSignForm;
        private System.Windows.Forms.Label OpenProtectorForm;
        private System.Windows.Forms.Timer XorGenTimer;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxEx;
        private Guna.UI2.WinForms.Guna2Button ClearBoxesBtn;
        private Guna.UI2.WinForms.Guna2Button GenerateMutexBtn;
        private Guna.UI2.WinForms.Guna2ComboBox InjectProcessBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.PictureBox IconBox;
        private Guna.UI2.WinForms.Guna2CheckBox UsePackerChk;
    }
}

