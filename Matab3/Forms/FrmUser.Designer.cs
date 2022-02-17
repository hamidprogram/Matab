
namespace Matab3
{
    partial class FrmUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUserName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TxtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TxtRePassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnAdd = new XanderUI.XUISuperButton();
            this.GrdShowUser = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edituser = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteuser = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.TxtRePassword);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1068, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات کاربر";
            // 
            // TxtUserName
            // 
            this.TxtUserName.AcceptsReturn = false;
            this.TxtUserName.AcceptsTab = false;
            this.TxtUserName.AnimationSpeed = 200;
            this.TxtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtUserName.BackColor = System.Drawing.Color.Transparent;
            this.TxtUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtUserName.BackgroundImage")));
            this.TxtUserName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtUserName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtUserName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtUserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtUserName.BorderRadius = 20;
            this.TxtUserName.BorderThickness = 1;
            this.TxtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.DefaultFont = new System.Drawing.Font("B Nazanin", 15.75F);
            this.TxtUserName.DefaultText = "";
            this.TxtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtUserName.ForeColor = System.Drawing.Color.Black;
            this.TxtUserName.HideSelection = true;
            this.TxtUserName.IconLeft = global::Matab3.Properties.Resources.icons8_customer_64;
            this.TxtUserName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.IconPadding = 10;
            this.TxtUserName.IconRight = null;
            this.TxtUserName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.Lines = new string[0];
            this.TxtUserName.Location = new System.Drawing.Point(841, 74);
            this.TxtUserName.MaxLength = 32767;
            this.TxtUserName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtUserName.Modified = false;
            this.TxtUserName.Multiline = false;
            this.TxtUserName.Name = "TxtUserName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtUserName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtUserName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtUserName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtUserName.OnIdleState = stateProperties4;
            this.TxtUserName.Padding = new System.Windows.Forms.Padding(3);
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtUserName.PlaceholderText = "نام بیمار*";
            this.TxtUserName.ReadOnly = false;
            this.TxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.SelectionLength = 0;
            this.TxtUserName.SelectionStart = 0;
            this.TxtUserName.ShortcutsEnabled = true;
            this.TxtUserName.Size = new System.Drawing.Size(221, 52);
            this.TxtUserName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtUserName.TabIndex = 20;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUserName.TextMarginBottom = 0;
            this.TxtUserName.TextMarginLeft = 3;
            this.TxtUserName.TextMarginTop = 0;
            this.TxtUserName.TextPlaceholder = "نام بیمار*";
            this.TxtUserName.UseSystemPasswordChar = false;
            this.TxtUserName.WordWrap = true;
            this.TxtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUserName_KeyDown);
            // 
            // TxtPassword
            // 
            this.TxtPassword.AcceptsReturn = false;
            this.TxtPassword.AcceptsTab = false;
            this.TxtPassword.AnimationSpeed = 200;
            this.TxtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtPassword.BackColor = System.Drawing.Color.Transparent;
            this.TxtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtPassword.BackgroundImage")));
            this.TxtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtPassword.BorderRadius = 20;
            this.TxtPassword.BorderThickness = 1;
            this.TxtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultFont = new System.Drawing.Font("B Nazanin", 15.75F);
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.HideSelection = true;
            this.TxtPassword.IconLeft = global::Matab3.Properties.Resources.icons8_forgot_password_100;
            this.TxtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.IconPadding = 10;
            this.TxtPassword.IconRight = null;
            this.TxtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(614, 74);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtPassword.Modified = false;
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtPassword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtPassword.OnIdleState = stateProperties8;
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(3);
            this.TxtPassword.PasswordChar = '\0';
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtPassword.PlaceholderText = "رمز عبور*";
            this.TxtPassword.ReadOnly = false;
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(221, 52);
            this.TxtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtPassword.TabIndex = 19;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtPassword.TextMarginBottom = 0;
            this.TxtPassword.TextMarginLeft = 3;
            this.TxtPassword.TextMarginTop = 0;
            this.TxtPassword.TextPlaceholder = "رمز عبور*";
            this.TxtPassword.UseSystemPasswordChar = false;
            this.TxtPassword.WordWrap = true;
            this.TxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPassword_KeyDown);
            // 
            // TxtRePassword
            // 
            this.TxtRePassword.AcceptsReturn = false;
            this.TxtRePassword.AcceptsTab = false;
            this.TxtRePassword.AnimationSpeed = 200;
            this.TxtRePassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtRePassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtRePassword.BackColor = System.Drawing.Color.Transparent;
            this.TxtRePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtRePassword.BackgroundImage")));
            this.TxtRePassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtRePassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtRePassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtRePassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtRePassword.BorderRadius = 20;
            this.TxtRePassword.BorderThickness = 1;
            this.TxtRePassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRePassword.DefaultFont = new System.Drawing.Font("B Nazanin", 15.75F);
            this.TxtRePassword.DefaultText = "";
            this.TxtRePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtRePassword.ForeColor = System.Drawing.Color.Black;
            this.TxtRePassword.HideSelection = true;
            this.TxtRePassword.IconLeft = global::Matab3.Properties.Resources.icons8_forgot_password_100;
            this.TxtRePassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRePassword.IconPadding = 10;
            this.TxtRePassword.IconRight = null;
            this.TxtRePassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRePassword.Lines = new string[0];
            this.TxtRePassword.Location = new System.Drawing.Point(387, 74);
            this.TxtRePassword.MaxLength = 32767;
            this.TxtRePassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtRePassword.Modified = false;
            this.TxtRePassword.Multiline = false;
            this.TxtRePassword.Name = "TxtRePassword";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtRePassword.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtRePassword.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtRePassword.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties12.ForeColor = System.Drawing.Color.Black;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtRePassword.OnIdleState = stateProperties12;
            this.TxtRePassword.Padding = new System.Windows.Forms.Padding(3);
            this.TxtRePassword.PasswordChar = '\0';
            this.TxtRePassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtRePassword.PlaceholderText = "تکرار رمز*";
            this.TxtRePassword.ReadOnly = false;
            this.TxtRePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRePassword.SelectedText = "";
            this.TxtRePassword.SelectionLength = 0;
            this.TxtRePassword.SelectionStart = 0;
            this.TxtRePassword.ShortcutsEnabled = true;
            this.TxtRePassword.Size = new System.Drawing.Size(221, 52);
            this.TxtRePassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtRePassword.TabIndex = 18;
            this.TxtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtRePassword.TextMarginBottom = 0;
            this.TxtRePassword.TextMarginLeft = 3;
            this.TxtRePassword.TextMarginTop = 0;
            this.TxtRePassword.TextPlaceholder = "تکرار رمز*";
            this.TxtRePassword.UseSystemPasswordChar = false;
            this.TxtRePassword.WordWrap = true;
            this.TxtRePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtRePassword_KeyDown);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ButtonImage")));
            this.BtnAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnAdd.ButtonText = "اضافه کردن کاربر";
            this.BtnAdd.CornerRadius = 20;
            this.BtnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnAdd.HoverTextColor = System.Drawing.Color.White;
            this.BtnAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnAdd.Location = new System.Drawing.Point(126, 72);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnAdd.SelectedTextColor = System.Drawing.Color.White;
            this.BtnAdd.Size = new System.Drawing.Size(228, 54);
            this.BtnAdd.SuperSelected = false;
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GrdShowUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GrdShowUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdShowUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdShowUser.BackgroundColor = System.Drawing.Color.White;
            this.GrdShowUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdShowUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdShowUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrdShowUser.ColumnHeadersHeight = 49;
            this.GrdShowUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.password});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdShowUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.GrdShowUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdShowUser.EnableHeadersVisualStyles = false;
            this.GrdShowUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowUser.Location = new System.Drawing.Point(0, 223);
            this.GrdShowUser.Name = "GrdShowUser";
            this.GrdShowUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdShowUser.RowHeadersVisible = false;
            this.GrdShowUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdShowUser.Size = new System.Drawing.Size(1080, 544);
            this.GrdShowUser.TabIndex = 6;
            this.GrdShowUser.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GrdShowUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GrdShowUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GrdShowUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GrdShowUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GrdShowUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GrdShowUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdShowUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.GrdShowUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GrdShowUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GrdShowUser.ThemeStyle.HeaderStyle.Height = 49;
            this.GrdShowUser.ThemeStyle.ReadOnly = false;
            this.GrdShowUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.GrdShowUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowUser.ThemeStyle.RowsStyle.Height = 22;
            this.GrdShowUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdShowUser_CellClick);
            this.GrdShowUser.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdShowUser_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "شماره";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "UserName";
            this.username.HeaderText = "نام کاربری";
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "کلمه ی عبور";
            this.password.Name = "password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edituser,
            this.deleteuser});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            // 
            // edituser
            // 
            this.edituser.Image = global::Matab3.Properties.Resources.icons8_edit_property_100;
            this.edituser.Name = "edituser";
            this.edituser.Size = new System.Drawing.Size(146, 22);
            this.edituser.Text = "تصحیح پروفایل";
            this.edituser.Click += new System.EventHandler(this.edituser_Click);
            // 
            // deleteuser
            // 
            this.deleteuser.Image = global::Matab3.Properties.Resources.icons8_remove_480;
            this.deleteuser.Name = "deleteuser";
            this.deleteuser.Size = new System.Drawing.Size(146, 22);
            this.deleteuser.Text = "حذف پروفایل";
            this.deleteuser.Click += new System.EventHandler(this.deleteuser_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdShowUser);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "FrmUser";
            this.Size = new System.Drawing.Size(1080, 767);
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private XanderUI.XUISuperButton BtnAdd;
        private Guna.UI.WinForms.GunaDataGridView GrdShowUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edituser;
        private System.Windows.Forms.ToolStripMenuItem deleteuser;
        private Bunifu.UI.WinForms.BunifuTextBox TxtUserName;
        private Bunifu.UI.WinForms.BunifuTextBox TxtPassword;
        private Bunifu.UI.WinForms.BunifuTextBox TxtRePassword;
    }
}
