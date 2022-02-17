
namespace Matab3
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLinkLabel2 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaGradientCircleButton1 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 50;
            this.gunaElipse1.TargetControl = this;
            // 
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = false;
            this.xuiCustomPictureBox1.Image = global::Matab3.Properties.Resources._20210315_203558_۰۰۰۰;
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(800, 450);
            this.xuiCustomPictureBox1.TabIndex = 0;
            this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel1.Location = new System.Drawing.Point(41, 9);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(155, 15);
            this.gunaLinkLabel1.TabIndex = 1;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "hamidprogram@gmail.com";
            // 
            // gunaLinkLabel2
            // 
            this.gunaLinkLabel2.AutoSize = true;
            this.gunaLinkLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLinkLabel2.Location = new System.Drawing.Point(605, 9);
            this.gunaLinkLabel2.Name = "gunaLinkLabel2";
            this.gunaLinkLabel2.Size = new System.Drawing.Size(166, 15);
            this.gunaLinkLabel2.TabIndex = 2;
            this.gunaLinkLabel2.TabStop = true;
            this.gunaLinkLabel2.Text = "hamidprogram@outlook.com";
            // 
            // gunaGradientCircleButton1
            // 
            this.gunaGradientCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton1.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientCircleButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.Image = null;
            this.gunaGradientCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton1.Location = new System.Drawing.Point(672, 330);
            this.gunaGradientCircleButton1.Name = "gunaGradientCircleButton1";
            this.gunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.OnHoverImage = null;
            this.gunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.Size = new System.Drawing.Size(138, 120);
            this.gunaGradientCircleButton1.TabIndex = 3;
            this.gunaGradientCircleButton1.Text = "بستن";
            this.gunaGradientCircleButton1.Click += new System.EventHandler(this.gunaGradientCircleButton1_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaGradientCircleButton1);
            this.Controls.Add(this.gunaLinkLabel2);
            this.Controls.Add(this.gunaLinkLabel1);
            this.Controls.Add(this.xuiCustomPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAbout";
            this.Text = "FrmAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel2;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton1;
    }
}