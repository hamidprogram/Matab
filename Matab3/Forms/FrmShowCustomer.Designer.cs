
namespace Matab3
{
    partial class FrmShowCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowCustomer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSerch = new XanderUI.XUISuperButton();
            this.TxtSerch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GrdShowCustomer = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codmely = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastsick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowCustomer)).BeginInit();
            this.SuspendLayout();
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
            this.BtnSerch.Location = new System.Drawing.Point(240, 12);
            this.BtnSerch.Name = "BtnSerch";
            this.BtnSerch.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(125)))), ((int)(((byte)(58)))));
            this.BtnSerch.SelectedTextColor = System.Drawing.Color.White;
            this.BtnSerch.Size = new System.Drawing.Size(41, 43);
            this.BtnSerch.SuperSelected = false;
            this.BtnSerch.TabIndex = 16;
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
            this.TxtSerch.Location = new System.Drawing.Point(12, 12);
            this.TxtSerch.Name = "TxtSerch";
            this.TxtSerch.PreventEnterBeep = true;
            this.TxtSerch.Size = new System.Drawing.Size(222, 39);
            this.TxtSerch.TabIndex = 15;
            this.TxtSerch.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.TxtSerch.WatermarkText = "کلمه ی مورد نظر برای جست جو*";
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
            this.codmely,
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
            this.GrdShowCustomer.Location = new System.Drawing.Point(0, 61);
            this.GrdShowCustomer.Name = "GrdShowCustomer";
            this.GrdShowCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GrdShowCustomer.RowHeadersVisible = false;
            this.GrdShowCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdShowCustomer.Size = new System.Drawing.Size(961, 408);
            this.GrdShowCustomer.TabIndex = 17;
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
            // codmely
            // 
            this.codmely.DataPropertyName = "Codemely";
            this.codmely.HeaderText = "کد ملی";
            this.codmely.Name = "codmely";
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
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "بستن";
            this.xuiSuperButton1.CornerRadius = 20;
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.Red;
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(848, 3);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(101, 30);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 18;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmShowCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(961, 469);
            this.Controls.Add(this.xuiSuperButton1);
            this.Controls.Add(this.GrdShowCustomer);
            this.Controls.Add(this.BtnSerch);
            this.Controls.Add(this.TxtSerch);
            this.Font = new System.Drawing.Font("Kalameh Black", 24F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmShowCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انتخاب بیمار";
            ((System.ComponentModel.ISupportInitialize)(this.GrdShowCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUISuperButton BtnSerch;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSerch;
        private Guna.UI.WinForms.GunaDataGridView GrdShowCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmely;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sick;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastsick;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}