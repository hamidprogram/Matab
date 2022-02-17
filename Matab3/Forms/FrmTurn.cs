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
using BLL;
using BE;
using DAL;
#endregion

namespace Matab3
{
    public partial class FrmTurn : UserControl
    {
        public static int idcus,iddd;
        bool vaz = true;
        public static string customernam,nas;
        VisitTurn_BLL bll = new VisitTurn_BLL();
        VisitTurn vis = new VisitTurn();
        DB db = new DB();
        public FrmTurn()
        {
            InitializeComponent();
        }

        #region متد خالی کردن تکست باکس ها

        

        void clear()
        {
            TxtName.Text = "";
            TxtDate.Text = "";
            TxtTime.Text = "";
        }
        #endregion

        private void BtnSerch_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtName_Click(object sender, EventArgs e)
        {
            
        }

        #region اضافه کردن و تصحیح نوبت

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TxtName.Text))||(string.IsNullOrWhiteSpace(TxtDate.Text))||(string.IsNullOrWhiteSpace(TxtTime.Text)))
            {
                //Customer cos = db.Customers.Where(i => i.ID == idcus).Single();
                vis.CustomerID = idcus;
                vis.DeteTurn = TxtDate.Text;
                vis.TimeTurn = TxtTime.Text;
                if (vaz == true)
                {
                    MessageBox.Show(bll.Create(vis));
                    clear();
                }
                else
                {
                    MessageBox.Show(bll.Update(iddd,vis));
                    clear();
                    vaz = true;
                    BtnAdd.ButtonText = "اضافه کردن نوبت";
                }
                GrdShowTurn.DataSource = bll.Read();
            }
            else
            {
                errorProvider1.SetError(BtnSerch,"لطفا کادر های ستاره دار را پر کنید");
            }
        }
        #endregion

        #region لود فرم

        

        private void FrmTurn_Load(object sender, EventArgs e)
        {
            GrdShowTurn.DataSource = null;
            GrdShowTurn.DataSource = bll.Read();
        }
        #endregion

        #region ریختن شماره برای حذف و تصحیح

        

        private void GrdShowTurn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iddd = Convert.ToInt32(GrdShowTurn.Rows[GrdShowTurn.CurrentRow.Index].Cells["id"].Value);
            nas = GrdShowTurn.CurrentRow.Cells["customername"].Value.ToString();
        }
        #endregion

        #region نمایش لیست عملیات

        

        private void GrdShowTurn_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        #endregion

        #region پاک کردن توبت

        

        private void deletevisit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئین هستید می خواهید این نوبت پاک شود؟","اخطار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Delete(iddd));
                GrdShowTurn.DataSource = bll.Read();
            }
        }
        #endregion

        #region نمایش نام بیمار در تکست باکس

        

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            TxtName.Text = customernam;
        }
        #endregion

        private void TxtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtTime.Focus();
            }
        }

        private void TxtTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(null, null);
            }
        }

        #region نمایش فرم انتخاب بیمار

        

        private void TxtName_Click_1(object sender, EventArgs e)
        {
            FrmShowCustomer frm = new FrmShowCustomer();
            frm.vaz = 1;
            frm.Show();
        }
        #endregion

        #region جست و جو



        private void BtnSerch_Click_1(object sender, EventArgs e)
        {
            GrdShowTurn.DataSource = bll.SerchByName(TxtSerch.Text);
        }
        #endregion

        #region تصحیح نوبت

        

        private void editvisit_Click(object sender, EventArgs e)
        {
            VisitTurn fg = bll.Read(iddd);
            //string customername = db.Customers.Single(i => i.ID == iddd).Name.ToString();
            TxtName.Text = nas;
            TxtDate.Text = fg.DeteTurn;
            TxtTime.Text = fg.TimeTurn;
            vaz = false;
            BtnAdd.ButtonText = "تصحیح نوبت";
            idcus = Convert.ToInt32(GrdShowTurn.Rows[GrdShowTurn.CurrentRow.Index].Cells["customerid"].Value);
        }
        #endregion
    }
}
