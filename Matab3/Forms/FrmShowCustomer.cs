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
#endregion

namespace Matab3
{
    public partial class FrmShowCustomer : Form
    {
        public int idd,vaz;
        Customer_BLL bll = new Customer_BLL();
        //public Form frmm = new Form();
        public FrmShowCustomer()
        {
            InitializeComponent();
        }

        #region رویداد کلیک بر روی بیمار ها در جدول
        private void GrdShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idd = Convert.ToInt32(GrdShowCustomer.Rows[GrdShowCustomer.CurrentRow.Index].Cells["id"].Value);
            if (vaz == 1)
            {
                //((FrmTurn)Application.OpenForms["FrmTurn"]).TxtName.Text = GrdShowCustomer.CurrentRow.Cells["name"].Value.ToString();
                FrmTurn.customernam = GrdShowCustomer.CurrentRow.Cells["name"].Value.ToString();
                FrmTurn.idcus = idd;
            }
            else
            {
                FrmDateOperation.customernam = GrdShowCustomer.CurrentRow.Cells["name"].Value.ToString();
                FrmDateOperation.idcus = idd;
            }
            this.Close();
        }
        #endregion

        #region دکمهی خوروج
        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region دکمه ی جست جو
        private void BtnSerch_Click(object sender, EventArgs e)
        {
            GrdShowCustomer.DataSource = bll.Serch(TxtSerch.Text);
        }
        #endregion
    }
}
