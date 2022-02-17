using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region رفرنس های مورد نیاز

using System.Windows.Forms;
using BE;
using BLL;
#endregion

namespace Matab3
{
    public partial class FrmCustomer : UserControl
    {
        Customer_BLL bll = new Customer_BLL();
        Customer cos = new Customer(); 
        int idd; 
        bool flat = true;
        public FrmCustomer()
        {
            InitializeComponent();
        }

        #region متد خالی کردن تکست باکس ها
        
        public void clear()
        {
            TxtName.Text = "";
            TxtCodeMely.Text = "";
            TxtAge.Text = "";
            TxtPhonNumber.Text = "";
            TxtSick.Text = "";
            TxtLastSick.Text = "";
            TxtDescription.Text = "";
        }
        #endregion

        private void BtnLook_Click(object sender, EventArgs e)
        {

        }

        #region عمل تصحیح و ثبت بیمار

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(TxtName.Text)) && (!string.IsNullOrWhiteSpace(TxtCodeMely.Text)) && (!string.IsNullOrWhiteSpace(TxtAge.Text)) && (!string.IsNullOrWhiteSpace(TxtPhonNumber.Text)))
            {
                cos.Name = TxtName.Text;
                cos.Codemely = TxtCodeMely.Text;
                cos.Age = Convert.ToByte(TxtAge.Text);
                cos.PhoneNumber = TxtPhonNumber.Text;
                cos.Sick = TxtSick.Text;
                cos.LastSick = TxtLastSick.Text;
                cos.Description = TxtDescription.Text;
                if (flat == true)
                {
                    MessageBox.Show(bll.Create(cos));
                }
                else
                {
                    MessageBox.Show(bll.Update(idd, cos));
                    flat = true;
                    BtnAdd.ButtonText = "اضافه کردن بیمار";
                }

                GrdShowCustomer.DataSource = bll.Read();
                clear();
            }
            else
            {
                errorProvider1.SetError(TxtPhonNumber, "لطفا کادر های ستاره دار را پر کنید");
            }
        }
        #endregion

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
        }

        #region تشخیص بیمار برای تصحیح

        

        private void editcustomer_Click(object sender, EventArgs e)
        {
            Customer c = bll.Read(idd);
            TxtName.Text = c.Name;
            TxtCodeMely.Text = c.Codemely;
            TxtAge.Text = c.Age.ToString();
            TxtPhonNumber.Text = c.PhoneNumber;
            TxtSick.Text = c.Sick;
            TxtLastSick.Text = c.LastSick;
            TxtDescription.Text = c.Description;
            flat = false;
            BtnAdd.ButtonText = "ویرایش اطلاعات";
        }
        #endregion

        #region حذف بیمار

        

        private void deletecustomer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئین هستید که می خواهید اطلاعات این بیمار حذف گردد؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Delete(idd));
                GrdShowCustomer.DataSource = bll.Read();
            }
        }
        #endregion

        #region گرفتن شماره ی بیمار برای حذف یا تصحیح

        

        private void GrdShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(GrdShowCustomer.Rows[GrdShowCustomer.CurrentRow.Index].Cells["id"].Value);
        }
        #endregion

        #region نمایش لیست عملیات

        

        private void GrdShowCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        #endregion

        #region عملیات هنگام لود صفحه

        

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            TxtName.Focus();
            GrdShowCustomer.DataSource = null;
            GrdShowCustomer.DataSource = bll.Read();
        }
        #endregion

        private void BtnSerch_Click(object sender, EventArgs e)
        {
            
        }

        #region جست و جوی بیمار

        

        private void BtnSerch_Click_1(object sender, EventArgs e)
        {
            GrdShowCustomer.DataSource = bll.Serch(TxtSerch.Text);
        }
        #endregion

        private void TxtSerch_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtCodeMely_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtAge_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtPhonNumber_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtCodeMely.Focus();
            }
        }

        private void TxtCodeMely_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtAge_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPhonNumber.Focus();
            }
            if (e.KeyCode == Keys.A)
            {
                BtnAdd_Click(null, null);
            }
        }

        private void TxtPhonNumber_KeyDown_1(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtSick_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtLastSick_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtName.Focus();
            }
        }

        private void TxtCodeMely_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtAge.Focus();
            }
        }

        private void TxtAge_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPhonNumber.Focus();
            }
        }

        private void TxtPhonNumber_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtSick.Focus();
            }
        }

        private void TxtSick_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtLastSick.Focus();
            }
        }

        private void TxtLastSick_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtDescription.Focus();
            }
        }
    }
}
