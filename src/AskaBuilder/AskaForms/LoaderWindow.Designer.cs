namespace AskaBuilder.AskaForms
{
    partial class LoaderWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderWindow));
            this.LoadAnimate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LoadBorders = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ProgressCheckBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AskaLoadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadAnimate
            // 
            this.LoadAnimate.TargetForm = this;
            // 
            // LoadBorders
            // 
            this.LoadBorders.AnimateWindow = true;
            this.LoadBorders.ContainerControl = this;
            this.LoadBorders.DockIndicatorColor = System.Drawing.Color.IndianRed;
            this.LoadBorders.DockIndicatorTransparencyValue = 1D;
            this.LoadBorders.DragForm = false;
            this.LoadBorders.ResizeForm = false;
            this.LoadBorders.ShadowColor = System.Drawing.Color.IndianRed;
            this.LoadBorders.TransparentWhileDrag = true;
            // 
            // ProgressCheckBar
            // 
            this.ProgressCheckBar.BorderColor = System.Drawing.Color.IndianRed;
            this.ProgressCheckBar.BorderThickness = 1;
            this.ProgressCheckBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ProgressCheckBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ProgressCheckBar.Location = new System.Drawing.Point(12, 320);
            this.ProgressCheckBar.Name = "ProgressCheckBar";
            this.ProgressCheckBar.ProgressColor = System.Drawing.Color.IndianRed;
            this.ProgressCheckBar.ProgressColor2 = System.Drawing.Color.IndianRed;
            this.ProgressCheckBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProgressCheckBar.Size = new System.Drawing.Size(265, 22);
            this.ProgressCheckBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressCheckBar.TabIndex = 0;
            this.ProgressCheckBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AskaBuilder.Properties.Resources.LoadVector;
            this.pictureBox1.Location = new System.Drawing.Point(236, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AskaLoadLabel
            // 
            this.AskaLoadLabel.AutoSize = true;
            this.AskaLoadLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskaLoadLabel.ForeColor = System.Drawing.Color.White;
            this.AskaLoadLabel.Location = new System.Drawing.Point(12, 297);
            this.AskaLoadLabel.Name = "AskaLoadLabel";
            this.AskaLoadLabel.Size = new System.Drawing.Size(167, 20);
            this.AskaLoadLabel.TabIndex = 2;
            this.AskaLoadLabel.Text = "Checking ASKA modules:";
            // 
            // LoaderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImage = global::AskaBuilder.Properties.Resources.BackgroundVector;
            this.ClientSize = new System.Drawing.Size(638, 393);
            this.Controls.Add(this.AskaLoadLabel);
            this.Controls.Add(this.ProgressCheckBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaderWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L O A D E R - [ A S K A ] ";
            this.Load += new System.EventHandler(this.LoaderWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow LoadAnimate;
        private Guna.UI2.WinForms.Guna2BorderlessForm LoadBorders;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressCheckBar;
        private System.Windows.Forms.Label AskaLoadLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}