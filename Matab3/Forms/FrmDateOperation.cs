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
using DAL;
#endregion

namespace Matab3
{
    public partial class FrmDateOperation : UserControl
    {
        public static int idcus, iddd;
        bool vaz = true;
        public static string customernam, nas;
        DateOprepation dat = new DateOprepation();
        DateOprepation_BLL bll = new DateOprepation_BLL();
        DB db = new DB();
        public FrmDateOperation()
        {
            InitializeComponent();
        }

        #region خالی کردن تکست باکس ها

        

        void clear()
        {
            TxtName.Text = "";
            TxtDateOperation.Text = "";
        }
        #endregion

        private void BtnSerch_Click(object sender, EventArgs e)
        {

        }

        #region لود فرم

        

        private void FrmDateOperation_Load(object sender, EventArgs e)
        {
            GrdShowDateOperation.DataSource = null;
            GrdShowDateOperation.DataSource = bll.Read();
        }
        #endregion

        #region نمایش نام انتخاب شده برای نوبت

        

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            TxtName.Text = customernam;
        }
        #endregion

        private void TxtName_Click(object sender, EventArgs e)
        {
            
        }

        #region حذف

        

        private void deletedate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئین هستید می خواهید این نوبت عمل پاک شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Delete(iddd));
                GrdShowDateOperation.DataSource = bll.Read();
            }
        }
        #endregion

        #region تصحیح

        

        private void editdate_Click(object sender, EventArgs e)
        {
            DateOprepation ds = bll.Read(iddd);
            //string customername = db.Customers.Single(i => i.ID == iddd).Name.ToString();
            TxtName.Text = nas;
            TxtDateOperation.Text = ds.DateOfOprepation;
            vaz = false;
            BtnAdd.ButtonText = "تصحیح نوبت عمل";
            idcus = Convert.ToInt32(GrdShowDateOperation.Rows[GrdShowDateOperation.CurrentRow.Index].Cells["customerid"].Value);
        }
        #endregion

        #region گرفتن شماره

        

        private void GrdShowDateOperation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iddd = Convert.ToInt32(GrdShowDateOperation.Rows[GrdShowDateOperation.CurrentRow.Index].Cells["id"].Value);
            nas = GrdShowDateOperation.CurrentRow.Cells["customername"].Value.ToString();
        }
        #endregion

        #region جست و جو

        

        private void BtnSerch_Click_1(object sender, EventArgs e)
        {
            GrdShowDateOperation.DataSource = bll.SerchByName(TxtSerch.Text);
        }
        #endregion

        private void TxtDateOperation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(null, null);
            }
        }

        #region انتخواب بیمار

        

        private void TxtName_Click_1(object sender, EventArgs e)
        {
            FrmShowCustomer frm = new FrmShowCustomer();
            frm.vaz = 2;
            frm.Show();
        }
        #endregion

        #region نمایش لیست عملیات

        

        private void GrdShowDateOperation_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        #endregion

        #region ایجاد و تصحیح

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TxtName.Text)) || (string.IsNullOrWhiteSpace(TxtDateOperation.Text)))
            {
                //Customer das = db.Customers.Where(i => i.ID == idcus).Single();
                dat.CustomerID = idcus;
                dat.DateOfOprepation = TxtDateOperation.Text;
                if (vaz == true)
                {
                    MessageBox.Show(bll.Create(dat));
                    clear();
                }
                else
                {
                    MessageBox.Show(bll.Update(iddd, dat));
                    clear();
                    vaz = true;
                    BtnAdd.ButtonText = "اضافه کردن نوبت عمل";
                }
                GrdShowDateOperation.DataSource = bll.Read();
            }
            else
            {
                errorProvider1.SetError(BtnAdd, "لطفا کادر های ستاره دار را پر کنید");
            }
        }
        #endregion
    }
}
