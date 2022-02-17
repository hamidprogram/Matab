using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز
//در بخش رفرنس فضای نام باید رفرنس اس تی مو ال سافت را اضافه کنید
using System.Windows.Forms;
using BLL;
#endregion

namespace Matab3
{
    public partial class FrmReport : UserControl
    {
        Customer_BLL bll = new Customer_BLL();
        byte ager;
        string namer, codemelyr, phonenumberr, sickr, lastsickr, descriptionr;
        bool a = true;

        #region دکمه ی چاپ
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (a == true)
            {
                StiAllCustomer.RegBusinessObject("Customer",GrdShowCustomer.DataSource);
                StiAllCustomer.Render();
                StiAllCustomer.Show();
            }
            else
            {
                StiCustomer.Dictionary.Variables["Name"].Value = namer;
                StiCustomer.Dictionary.Variables["Codemely"].Value = codemelyr;
                StiCustomer.Dictionary.Variables["Age"].Value = ager.ToString();
                StiCustomer.Dictionary.Variables["PhoneNumber"].Value = phonenumberr;
                StiCustomer.Dictionary.Variables["Sick"].Value = sickr;
                StiCustomer.Dictionary.Variables["LastSick"].Value = lastsickr;
                StiCustomer.Dictionary.Variables["Description"].Value = descriptionr;
                StiCustomer.Render();
                StiCustomer.Show();
                BtnPrint.ButtonText = "چاپ لیست بیمار ها";
                a = true;
            }
        }
        #endregion

        public FrmReport()
        {
            InitializeComponent();
        }

        #region جست و جو
        private void BtnSerch_Click(object sender, EventArgs e)
        {
            GrdShowCustomer.DataSource = bll.Serch(TxtSerch.Text);
        }
        #endregion

        #region لود فرم
        private void FrmReport_Load(object sender, EventArgs e)
        {
            GrdShowCustomer.DataSource = null;
            GrdShowCustomer.DataSource = bll.Read();
        }
        #endregion

        #region رویداد کلیک بر روی بیمار ها در جدول
        private void GrdShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            namer = GrdShowCustomer.CurrentRow.Cells["name"].Value.ToString();
            codemelyr = GrdShowCustomer.CurrentRow.Cells["codemely"].Value.ToString();
            ager = (byte)GrdShowCustomer.CurrentRow.Cells["age"].Value;
            phonenumberr = GrdShowCustomer.CurrentRow.Cells["phonnumber"].Value.ToString();
            sickr = GrdShowCustomer.CurrentRow.Cells["sick"].Value.ToString();
            lastsickr = GrdShowCustomer.CurrentRow.Cells["lastsick"].Value.ToString();
            descriptionr = GrdShowCustomer.CurrentRow.Cells["description"].Value.ToString();
            a = false;
            BtnPrint.ButtonText = "چاپ مشخصات بیمار";
        }
        #endregion
    }
}
