
namespace Matab3
{
    partial class Mine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mine));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.xuiSwitch1 = new XanderUI.XUISwitch();
            this.BtnRestore = new XanderUI.XUISuperButton();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.BtnUser = new XanderUI.XUISuperButton();
            this.BtnExit = new XanderUI.XUISuperButton();
            this.BtnGozaresh = new XanderUI.XUISuperButton();
            this.BtnBalckUp = new XanderUI.XUISuperButton();
            this.BtnDate = new XanderUI.XUISuperButton();
            this.BtnTurn = new XanderUI.XUISuperButton();
            this.BtnCustomer = new XanderUI.XUISuperButton();
            this.analogClock1 = new AnalogClock.AnalogClock();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.xuiCustomPictureBox2 = new XanderUI.XUICustomPictureBox();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.Gray;
            this.gunaElipsePanel1.Controls.Add(this.xuiSwitch1);
            this.gunaElipsePanel1.Controls.Add(this.BtnRestore);
            this.gunaElipsePanel1.Controls.Add(this.xuiSuperButton1);
            this.gunaElipsePanel1.Controls.Add(this.BtnUser);
            this.gunaElipsePanel1.Controls.Add(this.BtnExit);
            this.gunaElipsePanel1.Controls.Add(this.BtnGozaresh);
            this.gunaElipsePanel1.Controls.Add(this.BtnBalckUp);
            this.gunaElipsePanel1.Controls.Add(this.BtnDate);
            this.gunaElipsePanel1.Controls.Add(this.BtnTurn);
            this.gunaElipsePanel1.Controls.Add(this.BtnCustomer);
            this.gunaElipsePanel1.Controls.Add(this.analogClock1);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(1079, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(287, 749);
            this.gunaElipsePanel1.TabIndex = 16;
            // 
            // xuiSwitch1
            // 
            this.xuiSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.xuiSwitch1.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiSwitch1.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xuiSwitch1.Location = new System.Drawing.Point(46, 254);
            this.xuiSwitch1.Name = "xuiSwitch1";
            this.xuiSwitch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xuiSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.xuiSwitch1.Size = new System.Drawing.Size(60, 30);
            this.xuiSwitch1.SwitchState = XanderUI.XUISwitch.State.Off;
            this.xuiSwitch1.SwitchStyle = XanderUI.XUISwitch.Style.Dark;
            this.xuiSwitch1.TabIndex = 29;
            this.xuiSwitch1.Text = "xuiSwitch1";
            this.toolTip1.SetToolTip(this.xuiSwitch1, "اگر این را فعال کنید رنگ پس زمینه سیاه میشود");
            this.xuiSwitch1.Click += new System.EventHandler(this.xuiSwitch1_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnRestore.ButtonImage = global::Matab3.Properties.Resources.icons8_restore_96;
            this.BtnRestore.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnRestore.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnRestore.ButtonText = "بازیابی اطلاعات";
            this.BtnRestore.CornerRadius = 25;
            this.BtnRestore.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnRestore.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnRestore.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnRestore.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnRestore.Location = new System.Drawing.Point(46, 482);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnRestore.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnRestore.SelectedTextColor = System.Drawing.Color.White;
            this.BtnRestore.Size = new System.Drawing.Size(315, 42);
            this.BtnRestore.SuperSelected = false;
            this.BtnRestore.TabIndex = 28;
            this.BtnRestore.TextColor = System.Drawing.Color.White;
            this.BtnRestore.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "درباره ی ما";
            this.xuiSuperButton1.CornerRadius = 25;
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(46, 694);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.Gray;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(315, 42);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 27;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnUser.ButtonImage = global::Matab3.Properties.Resources.icons8_customer_64__1_;
            this.BtnUser.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnUser.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnUser.ButtonText = "مدیریت کاربران";
            this.BtnUser.CornerRadius = 25;
            this.BtnUser.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUser.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnUser.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnUser.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnUser.Location = new System.Drawing.Point(46, 578);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnUser.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnUser.SelectedTextColor = System.Drawing.Color.White;
            this.BtnUser.Size = new System.Drawing.Size(315, 42);
            this.BtnUser.SuperSelected = false;
            this.BtnUser.TabIndex = 25;
            this.BtnUser.TextColor = System.Drawing.Color.White;
            this.BtnUser.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            this.BtnUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnUser_KeyDown);
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnExit.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.ButtonImage")));
            this.BtnExit.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnExit.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnExit.ButtonText = "خروج از برنامه";
            this.BtnExit.CornerRadius = 25;
            this.BtnExit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExit.HoverBackgroundColor = System.Drawing.Color.Red;
            this.BtnExit.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnExit.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnExit.Location = new System.Drawing.Point(46, 646);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnExit.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnExit.SelectedTextColor = System.Drawing.Color.White;
            this.BtnExit.Size = new System.Drawing.Size(315, 42);
            this.BtnExit.SuperSelected = false;
            this.BtnExit.TabIndex = 23;
            this.BtnExit.TextColor = System.Drawing.Color.White;
            this.BtnExit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExit.Click += new System.EventHandler(this.xuiSuperButton6_Click);
            this.BtnExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnExit_KeyDown);
            // 
            // BtnGozaresh
            // 
            this.BtnGozaresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnGozaresh.ButtonImage = global::Matab3.Properties.Resources.icons8_business_report_100;
            this.BtnGozaresh.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnGozaresh.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnGozaresh.ButtonText = "گزارش گیری";
            this.BtnGozaresh.CornerRadius = 25;
            this.BtnGozaresh.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnGozaresh.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnGozaresh.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnGozaresh.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnGozaresh.Location = new System.Drawing.Point(46, 530);
            this.BtnGozaresh.Name = "BtnGozaresh";
            this.BtnGozaresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnGozaresh.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnGozaresh.SelectedTextColor = System.Drawing.Color.White;
            this.BtnGozaresh.Size = new System.Drawing.Size(315, 42);
            this.BtnGozaresh.SuperSelected = false;
            this.BtnGozaresh.TabIndex = 22;
            this.BtnGozaresh.TextColor = System.Drawing.Color.White;
            this.BtnGozaresh.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnGozaresh.Click += new System.EventHandler(this.BtnGozaresh_Click);
            this.BtnGozaresh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnGozaresh_KeyDown);
            // 
            // BtnBalckUp
            // 
            this.BtnBalckUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnBalckUp.ButtonImage = global::Matab3.Properties.Resources.icons8_database_backup_100;
            this.BtnBalckUp.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnBalckUp.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnBalckUp.ButtonText = "پشتیبان گیری";
            this.BtnBalckUp.CornerRadius = 25;
            this.BtnBalckUp.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBalckUp.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnBalckUp.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnBalckUp.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnBalckUp.Location = new System.Drawing.Point(46, 434);
            this.BtnBalckUp.Name = "BtnBalckUp";
            this.BtnBalckUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnBalckUp.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnBalckUp.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBalckUp.Size = new System.Drawing.Size(315, 42);
            this.BtnBalckUp.SuperSelected = false;
            this.BtnBalckUp.TabIndex = 21;
            this.BtnBalckUp.TextColor = System.Drawing.Color.White;
            this.BtnBalckUp.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBalckUp.Click += new System.EventHandler(this.BtnBalckUp_Click);
            this.BtnBalckUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnBalckUp_KeyDown);
            // 
            // BtnDate
            // 
            this.BtnDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnDate.ButtonImage = global::Matab3.Properties.Resources.icons8_hospital_bed_100__1_;
            this.BtnDate.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnDate.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnDate.ButtonText = "تاریخ های عمل";
            this.BtnDate.CornerRadius = 25;
            this.BtnDate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnDate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnDate.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnDate.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnDate.Location = new System.Drawing.Point(46, 386);
            this.BtnDate.Name = "BtnDate";
            this.BtnDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDate.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnDate.SelectedTextColor = System.Drawing.Color.White;
            this.BtnDate.Size = new System.Drawing.Size(315, 42);
            this.BtnDate.SuperSelected = false;
            this.BtnDate.TabIndex = 20;
            this.BtnDate.TextColor = System.Drawing.Color.White;
            this.BtnDate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnDate.Click += new System.EventHandler(this.BtnDate_Click);
            this.BtnDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnDate_KeyDown);
            // 
            // BtnTurn
            // 
            this.BtnTurn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnTurn.ButtonImage = global::Matab3.Properties.Resources.icons8_out_patient_department_100;
            this.BtnTurn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnTurn.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnTurn.ButtonText = "نوبت دهی";
            this.BtnTurn.CornerRadius = 25;
            this.BtnTurn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnTurn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnTurn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnTurn.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnTurn.Location = new System.Drawing.Point(46, 338);
            this.BtnTurn.Name = "BtnTurn";
            this.BtnTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnTurn.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnTurn.SelectedTextColor = System.Drawing.Color.White;
            this.BtnTurn.Size = new System.Drawing.Size(315, 42);
            this.BtnTurn.SuperSelected = false;
            this.BtnTurn.TabIndex = 19;
            this.BtnTurn.TextColor = System.Drawing.Color.White;
            this.BtnTurn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnTurn.Click += new System.EventHandler(this.BtnTurn_Click);
            this.BtnTurn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnTurn_KeyDown);
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.BtnCustomer.ButtonImage = global::Matab3.Properties.Resources.icons8_hospital_bed_100;
            this.BtnCustomer.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnCustomer.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnCustomer.ButtonText = "بیمار ها";
            this.BtnCustomer.CornerRadius = 25;
            this.BtnCustomer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCustomer.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnCustomer.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.BtnCustomer.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnCustomer.Location = new System.Drawing.Point(46, 290);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnCustomer.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnCustomer.SelectedTextColor = System.Drawing.Color.White;
            this.BtnCustomer.Size = new System.Drawing.Size(315, 42);
            this.BtnCustomer.SuperSelected = false;
            this.BtnCustomer.TabIndex = 17;
            this.BtnCustomer.TextColor = System.Drawing.Color.White;
            this.BtnCustomer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            this.BtnCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnCustomer_KeyDown);
            // 
            // analogClock1
            // 
            this.analogClock1.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.analogClock1.AllowDrop = true;
            this.analogClock1.BackColor = System.Drawing.Color.Transparent;
            this.analogClock1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("analogClock1.BackgroundImage")));
            this.analogClock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(56, 64);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(214, 205);
            this.analogClock1.TabIndex = 18;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kalameh Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "نرم افزار مدیریت مطب سپهر";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.gunaPanel1.Location = new System.Drawing.Point(-2, 1);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1080, 767);
            this.gunaPanel1.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "رنگ پس زمینه";
            // 
            // xuiCustomPictureBox2
            // 
            this.xuiCustomPictureBox2.Color1 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox2.Color2 = System.Drawing.Color.DodgerBlue;
            this.xuiCustomPictureBox2.FilterAlpha = 200;
            this.xuiCustomPictureBox2.FilterEnabled = false;
            this.xuiCustomPictureBox2.Image = global::Matab3.Properties.Resources.icons8_menu_512;
            this.xuiCustomPictureBox2.IsElipse = false;
            this.xuiCustomPictureBox2.IsParallax = false;
            this.xuiCustomPictureBox2.Location = new System.Drawing.Point(1318, 1);
            this.xuiCustomPictureBox2.Name = "xuiCustomPictureBox2";
            this.xuiCustomPictureBox2.Size = new System.Drawing.Size(49, 45);
            this.xuiCustomPictureBox2.TabIndex = 27;
            this.xuiCustomPictureBox2.Text = "xuiCustomPictureBox2";
            this.xuiCustomPictureBox2.Click += new System.EventHandler(this.xuiCustomPictureBox2_Click);
            // 
            // Mine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.xuiCustomPictureBox2);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mine_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Mine_KeyDown);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUISuperButton BtnCustomer;
        private AnalogClock.AnalogClock analogClock1;
        private XanderUI.XUISuperButton BtnExit;
        private XanderUI.XUISuperButton BtnGozaresh;
        private XanderUI.XUISuperButton BtnBalckUp;
        private XanderUI.XUISuperButton BtnDate;
        private XanderUI.XUISuperButton BtnTurn;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private XanderUI.XUISuperButton BtnUser;
        private XanderUI.XUICustomPictureBox xuiCustomPictureBox2;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private XanderUI.XUISuperButton BtnRestore;
        private XanderUI.XUISwitch xuiSwitch1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}