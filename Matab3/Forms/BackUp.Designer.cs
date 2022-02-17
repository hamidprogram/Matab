
namespace Matab3
{
    partial class BackUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xuiCustomPictureBox1 = new XanderUI.XUICustomPictureBox();
            this.BtnBackup = new XanderUI.XUISuperButton();
            this.BtnRestore = new XanderUI.XUISuperButton();
            this.SuspendLayout();
            // 
            // xuiCustomPictureBox1
            // 
            this.xuiCustomPictureBox1.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox1.FilterAlpha = 200;
            this.xuiCustomPictureBox1.FilterEnabled = false;
            this.xuiCustomPictureBox1.Image = global::Matab3.Properties.Resources.Backup_Transparent;
            this.xuiCustomPictureBox1.IsElipse = false;
            this.xuiCustomPictureBox1.IsParallax = false;
            this.xuiCustomPictureBox1.Location = new System.Drawing.Point(344, 37);
            this.xuiCustomPictureBox1.Name = "xuiCustomPictureBox1";
            this.xuiCustomPictureBox1.Size = new System.Drawing.Size(706, 287);
            this.xuiCustomPictureBox1.TabIndex = 0;
            this.xuiCustomPictureBox1.Text = "xuiCustomPictureBox1";
            // 
            // BtnBackup
            // 
            this.BtnBackup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(158)))), ((int)(((byte)(24)))));
            this.BtnBackup.ButtonImage = null;
            this.BtnBackup.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnBackup.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnBackup.ButtonText = "پشتیبان گیری از اطلاعات";
            this.BtnBackup.CornerRadius = 20;
            this.BtnBackup.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBackup.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnBackup.HoverTextColor = System.Drawing.Color.White;
            this.BtnBackup.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnBackup.Location = new System.Drawing.Point(545, 330);
            this.BtnBackup.Name = "BtnBackup";
            this.BtnBackup.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(158)))), ((int)(((byte)(24)))));
            this.BtnBackup.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBackup.Size = new System.Drawing.Size(273, 54);
            this.BtnBackup.SuperSelected = false;
            this.BtnBackup.TabIndex = 12;
            this.BtnBackup.TextColor = System.Drawing.Color.White;
            this.BtnBackup.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(158)))), ((int)(((byte)(24)))));
            this.BtnRestore.ButtonImage = null;
            this.BtnRestore.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnRestore.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnRestore.ButtonText = "بازیابی اطلاعات";
            this.BtnRestore.CornerRadius = 20;
            this.BtnRestore.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnRestore.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnRestore.HoverTextColor = System.Drawing.Color.White;
            this.BtnRestore.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnRestore.Location = new System.Drawing.Point(545, 409);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(158)))), ((int)(((byte)(24)))));
            this.BtnRestore.SelectedTextColor = System.Drawing.Color.White;
            this.BtnRestore.Size = new System.Drawing.Size(273, 54);
            this.BtnRestore.SuperSelected = false;
            this.BtnRestore.TabIndex = 13;
            this.BtnRestore.TextColor = System.Drawing.Color.White;
            this.BtnRestore.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // BackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnBackup);
            this.Controls.Add(this.xuiCustomPictureBox1);
            this.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "BackUp";
            this.Size = new System.Drawing.Size(1311, 767);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUICustomPictureBox xuiCustomPictureBox1;
        private XanderUI.XUISuperButton BtnBackup;
        private XanderUI.XUISuperButton BtnRestore;
    }
}
