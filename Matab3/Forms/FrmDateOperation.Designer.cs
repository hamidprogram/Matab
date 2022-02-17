
namespace Matab3
{
    partial class FrmDateOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDateOperation));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnSerch = new XanderUI.XUISuperButton();
            this.TxtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.TxtDateOperation = new System.Windows.Forms.MaskedTextBox();
            this.BtnAdd = new XanderUI.XUISuperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdShowDateOperation = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateopertion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editdate = new System.Windows.Forms.ToolStripMenuItem();
            this.deletedate = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowDateOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.BtnSerch);
            this.groupBox1.Controls.Add(this.TxtSerch);
            this.groupBox1.Controls.Add(this.xuiSuperButton1);
            this.groupBox1.Controls.Add(this.TxtDateOperation);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1074, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوبت عمل";
            // 
            // TxtName
            // 
            this.TxtName.AcceptsReturn = false;
            this.TxtName.AcceptsTab = false;
            this.TxtName.AnimationSpeed = 200;
            this.TxtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtName.BackColor = System.Drawing.Color.Transparent;
            this.TxtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TxtName.BackgroundImage")));
            this.TxtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtName.BorderRadius = 20;
            this.TxtName.BorderThickness = 1;
            this.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultFont = new System.Drawing.Font("B Nazanin", 15.75F);
            this.TxtName.DefaultText = "";
            this.TxtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.HideSelection = true;
            this.TxtName.IconLeft = global::Matab3.Properties.Resources.icons8_customer_64;
            this.TxtName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.IconPadding = 10;
            this.TxtName.IconRight = null;
            this.TxtName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(826, 64);
            this.TxtName.MaxLength = 32767;
            this.TxtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtName.Modified = false;
            this.TxtName.Multiline = false;
            this.TxtName.Name = "TxtName";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtName.OnIdleState = stateProperties4;
            this.TxtName.Padding = new System.Windows.Forms.Padding(3);
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtName.PlaceholderText = "نام بیمار*";
            this.TxtName.ReadOnly = false;
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(242, 52);
            this.TxtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtName.TabIndex = 21;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtName.TextMarginBottom = 0;
            this.TxtName.TextMarginLeft = 3;
            this.TxtName.TextMarginTop = 0;
            this.TxtName.TextPlaceholder = "نام بیمار*";
            this.TxtName.UseSystemPasswordChar = false;
            this.TxtName.WordWrap = true;
            this.TxtName.Click += new System.EventHandler(this.TxtName_Click_1);
            // 
            // BtnSerch
            // 
            this.BtnSerch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(58)))));
            this.BtnSerch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnSerch.ButtonImage")));
            this.BtnSerch.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnSerch.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnSerch.ButtonText = "جست و جو";
            this.BtnSerch.CornerRadius = 20;
            this.BtnSerch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSerch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnSerch.HoverTextColor = System.Drawing.Color.White;
            this.BtnSerch.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnSerch.Location = new System.Drawing.Point(820, 174);
            this.BtnSerch.Name = "BtnSerch";
            this.BtnSerch.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(58)))));
            this.BtnSerch.SelectedTextColor = System.Drawing.Color.White;
            this.BtnSerch.Size = new System.Drawing.Size(33, 32);
            this.BtnSerch.SuperSelected = false;
            this.BtnSerch.TabIndex = 19;
            this.BtnSerch.TextColor = System.Drawing.Color.White;
            this.BtnSerch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSerch.Click += new System.EventHandler(this.BtnSerch_Click_1);
            // 
            // TxtSerch
            // 
            this.TxtSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            // 
            // 
            // 
            this.TxtSerch.Border.Class = "TextBoxBorder";
            this.TxtSerch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtSerch.Font = new System.Drawing.Font("B Nazanin", 15.75F);
            this.TxtSerch.ForeColor = System.Drawing.Color.Black;
            this.TxtSerch.Location = new System.Drawing.Point(859, 163);
            this.TxtSerch.Name = "TxtSerch";
            this.TxtSerch.PreventEnterBeep = true;
            this.TxtSerch.Size = new System.Drawing.Size(215, 39);
            this.TxtSerch.TabIndex = 18;
            this.TxtSerch.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtSerch.WatermarkText = "کلمه ی مورد نظر برای جست جو*";
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.Gray;
            this.xuiSuperButton1.ButtonImage = null;
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "اعمال تغییر";
            this.xuiSuperButton1.CornerRadius = 20;
            this.xuiSuperButton1.Font = new System.Drawing.Font("Kalameh Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(990, 122);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.Gray;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(78, 26);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 15;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // TxtDateOperation
            // 
            this.TxtDateOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtDateOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtDateOperation.Location = new System.Drawing.Point(493, 70);
            this.TxtDateOperation.Mask = "00/00/0000";
            this.TxtDateOperation.Name = "TxtDateOperation";
            this.TxtDateOperation.Size = new System.Drawing.Size(170, 43);
            this.TxtDateOperation.TabIndex = 13;
            this.TxtDateOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDateOperation.ValidatingType = typeof(System.DateTime);
            this.TxtDateOperation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDateOperation_KeyDown);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ButtonImage")));
            this.BtnAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnAdd.ButtonText = "اضافه کردن نوبت عمل";
            this.BtnAdd.CornerRadius = 20;
            this.BtnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnAdd.HoverTextColor = System.Drawing.Color.White;
            this.BtnAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnAdd.Location = new System.Drawing.Point(167, 62);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnAdd.SelectedTextColor = System.Drawing.Color.White;
            this.BtnAdd.Size = new System.Drawing.Size(292, 54);
            this.BtnAdd.SuperSelected = false;
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "تاریخ عمل:";
            // 
            // GrdShowDateOperation
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GrdShowDateOperation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdShowDateOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdShowDateOperation.BackgroundColor = System.Drawing.Color.White;
            this.GrdShowDateOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdShowDateOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowDateOperation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdShowDateOperation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrdShowDateOperation.ColumnHeadersHeight = 49;
            this.GrdShowDateOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customerid,
            this.customername,
            this.dateopertion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdShowDateOperation.DefaultCellStyle = dataGridViewCellStyle3;
            this.GrdShowDateOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdShowDateOperation.EnableHeadersVisualStyles = false;
            this.GrdShowDateOperation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowDateOperation.Location = new System.Drawing.Point(0, 221);
            this.GrdShowDateOperation.Name = "GrdShowDateOperation";
            this.GrdShowDateOperation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdShowDateOperation.RowHeadersVisible = false;
            this.GrdShowDateOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdShowDateOperation.Size = new System.Drawing.Size(1080, 546);
            this.GrdShowDateOperation.TabIndex = 2;
            this.GrdShowDateOperation.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GrdShowDateOperation.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowDateOperation.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GrdShowDateOperation.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GrdShowDateOperation.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GrdShowDateOperation.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GrdShowDateOperation.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowDateOperation.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowDateOperation.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GrdShowDateOperation.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdShowDateOperation.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.GrdShowDateOperation.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GrdShowDateOperation.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GrdShowDateOperation.ThemeStyle.HeaderStyle.Height = 49;
            this.GrdShowDateOperation.ThemeStyle.ReadOnly = false;
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.Height = 22;
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowDateOperation.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowDateOperation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdShowDateOperation_CellClick);
            this.GrdShowDateOperation.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdShowDateOperation_CellMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "شماره";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // customerid
            // 
            this.customerid.DataPropertyName = "CustomerID";
            this.customerid.HeaderText = "شماره ی بیمار";
            this.customerid.Name = "customerid";
            // 
            // customername
            // 
            this.customername.DataPropertyName = "Name";
            this.customername.HeaderText = "نام بیمار";
            this.customername.Name = "customername";
            // 
            // dateopertion
            // 
            this.dateopertion.DataPropertyName = "DateOfOprepation";
            this.dateopertion.HeaderText = "تاریخ عمل";
            this.dateopertion.Name = "dateopertion";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editdate,
            this.deletedate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 48);
            // 
            // editdate
            // 
            this.editdate.Image = global::Matab3.Properties.Resources.icons8_edit_property_100;
            this.editdate.Name = "editdate";
            this.editdate.Size = new System.Drawing.Size(161, 22);
            this.editdate.Text = "تصحیح نوبت عمل";
            this.editdate.Click += new System.EventHandler(this.editdate_Click);
            // 
            // deletedate
            // 
            this.deletedate.Image = global::Matab3.Properties.Resources.icons8_remove_480;
            this.deletedate.Name = "deletedate";
            this.deletedate.Size = new System.Drawing.Size(161, 22);
            this.deletedate.Text = "حذف نوبت عمل";
            this.deletedate.Click += new System.EventHandler(this.deletedate_Click);
            // 
            // FrmDateOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdShowDateOperation);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "FrmDateOperation";
            this.Size = new System.Drawing.Size(1080, 767);
            this.Load += new System.EventHandler(this.FrmDateOperation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowDateOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUISuperButton BtnAdd;
        private System.Windows.Forms.MaskedTextBox TxtDateOperation;
        private Guna.UI.WinForms.GunaDataGridView GrdShowDateOperation;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private XanderUI.XUISuperButton BtnSerch;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSerch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editdate;
        private System.Windows.Forms.ToolStripMenuItem deletedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateopertion;
        private Bunifu.UI.WinForms.BunifuTextBox TxtName;
    }
}
