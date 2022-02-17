
namespace Matab3
{
    partial class FrmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.GrdShowCustomer = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codemely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastsick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSerch = new XanderUI.XUISuperButton();
            this.TxtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.StiCustomer = new Stimulsoft.Report.StiReport();
            this.StiAllCustomer = new Stimulsoft.Report.StiReport();
            this.BtnPrint = new XanderUI.XUISuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdShowCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GrdShowCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdShowCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdShowCustomer.BackgroundColor = System.Drawing.Color.White;
            this.GrdShowCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdShowCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdShowCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GrdShowCustomer.ColumnHeadersHeight = 49;
            this.GrdShowCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.codemely,
            this.age,
            this.phonnumber,
            this.sick,
            this.lastsick,
            this.description});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdShowCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.GrdShowCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdShowCustomer.EnableHeadersVisualStyles = false;
            this.GrdShowCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowCustomer.Location = new System.Drawing.Point(0, 74);
            this.GrdShowCustomer.Name = "GrdShowCustomer";
            this.GrdShowCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdShowCustomer.RowHeadersVisible = false;
            this.GrdShowCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdShowCustomer.Size = new System.Drawing.Size(1080, 693);
            this.GrdShowCustomer.TabIndex = 8;
            this.GrdShowCustomer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.GrdShowCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GrdShowCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GrdShowCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GrdShowCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GrdShowCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GrdShowCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GrdShowCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.GrdShowCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GrdShowCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GrdShowCustomer.ThemeStyle.HeaderStyle.Height = 49;
            this.GrdShowCustomer.ThemeStyle.ReadOnly = false;
            this.GrdShowCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GrdShowCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GrdShowCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.GrdShowCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowCustomer.ThemeStyle.RowsStyle.Height = 22;
            this.GrdShowCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GrdShowCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GrdShowCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdShowCustomer_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "شماره";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "نام بیمار";
            this.name.Name = "name";
            // 
            // codemely
            // 
            this.codemely.DataPropertyName = "Codemely";
            this.codemely.HeaderText = "کد ملی";
            this.codemely.Name = "codemely";
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "سن";
            this.age.Name = "age";
            // 
            // phonnumber
            // 
            this.phonnumber.DataPropertyName = "PhoneNumber";
            this.phonnumber.HeaderText = "شماره تلفن";
            this.phonnumber.Name = "phonnumber";
            // 
            // sick
            // 
            this.sick.DataPropertyName = "Sick";
            this.sick.HeaderText = "نوع بیماری";
            this.sick.Name = "sick";
            // 
            // lastsick
            // 
            this.lastsick.DataPropertyName = "LastSick";
            this.lastsick.HeaderText = "بیماری های زمینه ای";
            this.lastsick.Name = "lastsick";
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "توضیحات اضافی";
            this.description.Name = "description";
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
            this.BtnSerch.Location = new System.Drawing.Point(816, 36);
            this.BtnSerch.Name = "BtnSerch";
            this.BtnSerch.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(58)))));
            this.BtnSerch.SelectedTextColor = System.Drawing.Color.White;
            this.BtnSerch.Size = new System.Drawing.Size(34, 32);
            this.BtnSerch.SuperSelected = false;
            this.BtnSerch.TabIndex = 18;
            this.BtnSerch.TextColor = System.Drawing.Color.White;
            this.BtnSerch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnSerch.Click += new System.EventHandler(this.BtnSerch_Click);
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
            this.TxtSerch.Location = new System.Drawing.Point(856, 25);
            this.TxtSerch.Name = "TxtSerch";
            this.TxtSerch.PreventEnterBeep = true;
            this.TxtSerch.Size = new System.Drawing.Size(221, 39);
            this.TxtSerch.TabIndex = 17;
            this.TxtSerch.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtSerch.WatermarkText = "کلمه ی مورد نظر برای جست جو*";
            // 
            // StiCustomer
            // 
            this.StiCustomer.CookieContainer = null;
            this.StiCustomer.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.StiCustomer.Key = "3de296d6a3494de9bf39327c0a655c0a";
            this.StiCustomer.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.StiCustomer.ReportAlias = "Report";
            this.StiCustomer.ReportGuid = "0d147ccc9518486bb053caaa15b225c9";
            this.StiCustomer.ReportName = "Report";
            this.StiCustomer.ReportSource = resources.GetString("StiCustomer.ReportSource");
            this.StiCustomer.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.StiCustomer.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.StiCustomer.StoreImagesInResources = true;
            this.StiCustomer.UseProgressInThread = false;
            // 
            // StiAllCustomer
            // 
            this.StiAllCustomer.CookieContainer = null;
            this.StiAllCustomer.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.StiAllCustomer.Key = "660fbc741a4d48fcbfa6c662061e950f";
            this.StiAllCustomer.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.StiAllCustomer.ReportAlias = "Report";
            this.StiAllCustomer.ReportGuid = "ab77328217454016a76af9525385704c";
            this.StiAllCustomer.ReportName = "Report";
            this.StiAllCustomer.ReportSource = resources.GetString("StiAllCustomer.ReportSource");
            this.StiAllCustomer.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.StiAllCustomer.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.StiAllCustomer.StoreImagesInResources = true;
            this.StiAllCustomer.UseProgressInThread = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnPrint.ButtonImage = global::Matab3.Properties.Resources.icons8_edit_property_100;
            this.BtnPrint.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnPrint.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnPrint.ButtonText = "چاپ لیست بیمار ها";
            this.BtnPrint.CornerRadius = 20;
            this.BtnPrint.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnPrint.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(216)))), ((int)(((byte)(103)))));
            this.BtnPrint.HoverTextColor = System.Drawing.Color.White;
            this.BtnPrint.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnPrint.Location = new System.Drawing.Point(6, 14);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.SelectedBackColor = System.Drawing.Color.Gray;
            this.BtnPrint.SelectedTextColor = System.Drawing.Color.White;
            this.BtnPrint.Size = new System.Drawing.Size(309, 54);
            this.BtnPrint.SuperSelected = false;
            this.BtnPrint.TabIndex = 19;
            this.BtnPrint.TextColor = System.Drawing.Color.White;
            this.BtnPrint.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnSerch);
            this.Controls.Add(this.TxtSerch);
            this.Controls.Add(this.GrdShowCustomer);
            this.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.Name = "FrmReport";
            this.Size = new System.Drawing.Size(1080, 767);
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView GrdShowCustomer;
        private XanderUI.XUISuperButton BtnSerch;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSerch;
        private Stimulsoft.Report.StiReport StiCustomer;
        private Stimulsoft.Report.StiReport StiAllCustomer;
        public XanderUI.XUISuperButton BtnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemely;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sick;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastsick;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}
