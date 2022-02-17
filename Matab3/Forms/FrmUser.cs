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
    public partial class FrmUser : UserControl
    {
        bool vaz = true;
        int idd;
        User use = new User();
        User_BLL bll = new User_BLL();
        public FrmUser()
        {
            InitializeComponent();
        }

        #region متد خالی کردن تکست باکس ها



        void clear()
        {
            TxtPassword.Text = "";
            TxtRePassword.Text = "";
            TxtUserName.Text = "";
        }
        #endregion

        #region اضافه و تصحیح کاربر



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(TxtUserName.Text)) || (string.IsNullOrWhiteSpace(TxtPassword.Text)) || (string.IsNullOrWhiteSpace(TxtRePassword.Text)))
            {
                if (TxtPassword.Text == TxtRePassword.Text)
                {
                    use.UserName = TxtUserName.Text;
                    use.Password = TxtPassword.Text;
                    if (vaz == true)
                    {
                        MessageBox.Show(bll.Create(use));
                        clear();
                    }
                    else
                    {
                        MessageBox.Show(bll.Update(idd, use));
                        clear();
                        vaz = true;
                        BtnAdd.ButtonText = "اضافه کردن کاربر";
                    }
                    GrdShowUser.DataSource = bll.Read();
                }
                else
                {
                    errorProvider1.SetError(BtnAdd, "تکرار رمز با رمز یکی نیست لطفا در وارد کردن رمز خود دقت کنید");
                }
            }
            else
            {
                errorProvider1.SetError(BtnAdd, "لطفا کادر های ستاره دار را پر کنید");
            }

        }
        #endregion

        #region تصحیح کاربر

        

        private void edituser_Click(object sender, EventArgs e)
        {
            User fg = bll.Read(idd);
            TxtUserName.Text = fg.UserName;
            TxtPassword.Text = fg.Password;
            vaz = false;
            BtnAdd.ButtonText = "تصحیح کاربر";
        }
        #endregion

        #region حذف کاربر

        

        private void deleteuser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا مطمئین هستید می خواهید این کاربر پاک شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(bll.Delete(idd));
                GrdShowUser.DataSource = bll.Read();
            }
        }
        #endregion

        #region ریختن شماره در متغییر برای تصحیح و حذف کاربر

        

        private void GrdShowUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(GrdShowUser.Rows[GrdShowUser.CurrentRow.Index].Cells["id"].Value);
        }
        #endregion

        #region نمایش لیست عملیات ها

        
        private void GrdShowUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        #endregion

        #region فرم لود

        

        private void FrmUser_Load(object sender, EventArgs e)
        {
            GrdShowUser.DataSource = null;
            GrdShowUser.DataSource = bll.Read();
            TxtUserName.Focus();
        }
        #endregion
        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtRePassword.Focus();
            }
        }

        private void TxtRePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd_Click(null, null);
            }
        }
    }
}
