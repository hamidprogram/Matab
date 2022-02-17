
namespace Matab3
{
    partial class FrmTurn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurn));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnSerch = new XanderUI.XUISuperButton();
            this.TxtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new XanderUI.XUISuperButton();
            this.TxtDate = new System.Windows.Forms.MaskedTextBox();
            this.GrdShowTurn = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editvisit = new System.Windows.Forms.ToolStripMenuItem();
            this.deletevisit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowTurn)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.TxtDate);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1074, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوبت دهی";
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
            this.TxtName.Location = new System.Drawing.Point(847, 58);
            this.TxtName.MaxLength = 32767;
            this.TxtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TxtName.Modified = false;
            this.TxtName.Multiline = false;
            this.TxtName.Name = "TxtName";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TxtName.OnIdleState = stateProperties8;
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
            this.TxtName.Size = new System.Drawing.Size(221, 52);
            this.TxtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TxtName.TabIndex = 17;
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
            this.BtnSerch.Location = new System.Drawing.Point(847, 170);
            this.BtnSerch.Name = "BtnSerch";
            this.BtnSerch.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(58)))));
            this.BtnSerch.SelectedTextColor = System.Drawing.Color.White;
            this.BtnSerch.Size = new System.Drawing.Size(34, 32);
            this.BtnSerch.SuperSelected = false;
            this.BtnSerch.TabIndex = 16;
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
            this.TxtSerch.Location = new System.Drawing.Point(888, 162);
            this.TxtSerch.Name = "TxtSerch";
            this.TxtSerch.PreventEnterBeep = true;
            this.TxtSerch.Size = new System.Drawing.Size(180, 39);
            this.TxtSerch.TabIndex = 15;
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
            this.xuiSuperButton1.Location = new System.Drawing.Point(990, 117);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.Gray;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(78, 26);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 14;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "ساعت حضور:";
            // 
            // TxtTime
            // 
            this.TxtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtTime.ForeColor = System.Drawing.Color.Black;
            this.TxtTime.Location = new System.Drawing.Point(286, 70);
            this.TxtTime.Mask = "00:00";
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(79, 40);
            this.TxtTime.TabIndex = 3;
            this.TxtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTime.ValidatingType = typeof(System.DateTime);
            this.TxtTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTime_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(751, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnAdd.ButtonImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ButtonImage")));
            this.BtnAdd.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnAdd.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnAdd.ButtonText = "اضافه کردن نوبت";
            this.BtnAdd.CornerRadius = 20;
            this.BtnAdd.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAdd.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnAdd.HoverTextColor = System.Drawing.Color.White;
            this.BtnAdd.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnAdd.Location = new System.Drawing.Point(9, 64);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnAdd.SelectedTextColor = System.Drawing.Color.White;
            this.BtnAdd.Size = new System.Drawing.Size(228, 54);
            this.BtnAdd.SuperSelected = false;
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtDate
            // 
            this.TxtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(236)))), ((int)(((byte)(120)))));
            this.TxtDate.ForeColor = System.Drawing.Color.Black;
            this.TxtDate.Location = new System.Drawing.Point(555, 70);
            this.TxtDate.Mask = "00/00/0000";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDate.Size = new System.Drawing.Size(170, 40);
            this.TxtDate.TabIndex = 0;
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDate.ValidatingType = typeof(System.DateTime);
            this.TxtDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDate_KeyDown);
            // 
            // GrdShowTurn
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GrdShowTurn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GrdShowTurn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdShowTurn.BackgroundColor = System.Drawing.Color.White;
            this.GrdShowTurn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdShowTurn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowTurn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdShowTurn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GrdShowTurn.ColumnHeadersHeight = 49;
            this.GrdShowTurn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customerid,
            this.customername,
            this.date,
            this.time});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdShowTurn.DefaultCellStyle = dataGridViewCellStyle6;
            this.GrdShowTurn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdShowTurn.EnableHeadersVisualStyles = false;
            this.GrdShowTurn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowTurn.Location = new System.Drawing.Point(0, 217);
            this.GrdShowTurn.Name = "GrdShowTurn";
            this.GrdShowTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdShowTurn.RowHeadersVisible = false;
            this.GrdShowTurn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdShowTurn.Size = new System.Drawing.Size(1080, 550);
            this.GrdShowTurn.TabIndex = 1;
            this.GrdShowTurn.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GrdShowTurn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowTurn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GrdShowTurn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GrdShowTurn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GrdShowTurn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GrdShowTurn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowTurn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowTurn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GrdShowTurn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdShowTurn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.GrdShowTurn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GrdShowTurn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GrdShowTurn.ThemeStyle.HeaderStyle.Height = 49;
            this.GrdShowTurn.ThemeStyle.ReadOnly = false;
            this.GrdShowTurn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowTurn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowTurn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.GrdShowTurn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowTurn.ThemeStyle.RowsStyle.Height = 22;
            this.GrdShowTurn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowTurn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowTurn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdShowTurn_CellClick);
            this.GrdShowTurn.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdShowTurn_CellMouseClick);
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
            // date
            // 
            this.date.DataPropertyName = "DeteTurn";
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            // 
            // time
            // 
            this.time.DataPropertyName = "TimeTurn";
            this.time.HeaderText = "ساعت حضور";
            this.time.Name = "time";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editvisit,
            this.deletevisit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // editvisit
            // 
            this.editvisit.Image = global::Matab3.Properties.Resources.icons8_edit_property_100;
            this.editvisit.Name = "editvisit";
            this.editvisit.Size = new System.Drawing.Size(138, 22);
            this.editvisit.Text = "ویرایش نوبت";
            this.editvisit.Click += new System.EventHandler(this.editvisit_Click);
            // 
            // deletevisit
            // 
            this.deletevisit.Image = global::Matab3.Properties.Resources.icons8_remove_480;
            this.deletevisit.Name = "deletevisit";
            this.deletevisit.Size = new System.Drawing.Size(138, 22);
            this.deletevisit.Text = "حذف نوبت";
            this.deletevisit.Click += new System.EventHandler(this.deletevisit_Click);
            // 
            // FrmTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrdShowTurn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Kalameh Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(7, 11, 7, 11);
            this.Name = "FrmTurn";
            this.Size = new System.Drawing.Size(1080, 767);
            this.Load += new System.EventHandler(this.FrmTurn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowTurn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TxtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtTime;
        private XanderUI.XUISuperButton BtnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editvisit;
        private System.Windows.Forms.ToolStripMenuItem deletevisit;
        public Guna.UI.WinForms.GunaDataGridView GrdShowTurn;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private XanderUI.XUISuperButton BtnSerch;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSerch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customername;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private Bunifu.UI.WinForms.BunifuTextBox TxtName;
    }
}
