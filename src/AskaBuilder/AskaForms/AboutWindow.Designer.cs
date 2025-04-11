namespace AskaBuilder.AskaForms
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.AboutAnimate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.AboutBorders = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CloseBoxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MainGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageBoxEx = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.OpenRepositoryBtn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutAnimate
            // 
            this.AboutAnimate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
            this.AboutAnimate.TargetForm = this;
            // 
            // AboutBorders
            // 
            this.AboutBorders.AnimateWindow = true;
            this.AboutBorders.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.AboutBorders.ContainerControl = this;
            this.AboutBorders.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.AboutBorders.DockIndicatorTransparencyValue = 0.6D;
            this.AboutBorders.ShadowColor = System.Drawing.Color.IndianRed;
            this.AboutBorders.TransparentWhileDrag = true;
            // 
            // CloseBoxBtn
            // 
            this.CloseBoxBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBoxBtn.Animated = true;
            this.CloseBoxBtn.BorderColor = System.Drawing.Color.IndianRed;
            this.CloseBoxBtn.FillColor = System.Drawing.Color.IndianRed;
            this.CloseBoxBtn.IconColor = System.Drawing.Color.White;
            this.CloseBoxBtn.Location = new System.Drawing.Point(641, 9);
            this.CloseBoxBtn.Name = "CloseBoxBtn";
            this.CloseBoxBtn.Size = new System.Drawing.Size(45, 29);
            this.CloseBoxBtn.TabIndex = 3;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BorderColor = System.Drawing.Color.IndianRed;
            this.MainGroupBox.Controls.Add(this.label4);
            this.MainGroupBox.Controls.Add(this.OpenRepositoryBtn);
            this.MainGroupBox.Controls.Add(this.label2);
            this.MainGroupBox.Controls.Add(this.guna2CirclePictureBox1);
            this.MainGroupBox.Controls.Add(this.label1);
            this.MainGroupBox.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.MainGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainGroupBox.ForeColor = System.Drawing.Color.White;
            this.MainGroupBox.Location = new System.Drawing.Point(1, 49);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(686, 291);
            this.MainGroupBox.TabIndex = 14;
            this.MainGroupBox.Text = "About | Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(540, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Author: K3rnel-Dev";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::AskaBuilder.Properties.Resources.logo;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(520, 84);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(122, 116);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 114);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "About Software | A S K A ";
            // 
            // MessageBoxEx
            // 
            this.MessageBoxEx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxEx.Caption = "~ Error ~";
            this.MessageBoxEx.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageBoxEx.Parent = this;
            this.MessageBoxEx.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageBoxEx.Text = null;
            // 
            // OpenRepositoryBtn
            // 
            this.OpenRepositoryBtn.AutoSize = true;
            this.OpenRepositoryBtn.BackColor = System.Drawing.Color.Transparent;
            this.OpenRepositoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenRepositoryBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenRepositoryBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.OpenRepositoryBtn.Location = new System.Drawing.Point(11, 259);
            this.OpenRepositoryBtn.Name = "OpenRepositoryBtn";
            this.OpenRepositoryBtn.Size = new System.Drawing.Size(192, 20);
            this.OpenRepositoryBtn.TabIndex = 19;
            this.OpenRepositoryBtn.Text = "Detailed Repository ( click )";
            this.OpenRepositoryBtn.Click += new System.EventHandler(this.OpenRepositoryBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(11, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(480, 57);
            this.label4.TabIndex = 20;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(702, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.CloseBoxBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A S K A - [ A  B O U T ] ";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow AboutAnimate;
        private Guna.UI2.WinForms.Guna2BorderlessForm AboutBorders;
        private Guna.UI2.WinForms.Guna2ControlBox CloseBoxBtn;
        private Guna.UI2.WinForms.Guna2GroupBox MainGroupBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxEx;
        private System.Windows.Forms.Label OpenRepositoryBtn;
        private System.Windows.Forms.Label label4;
    }
}