using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using FreeControls;
using XanderUI;

namespace Matab3
{
    public partial class Mine : Form
    {
        public Mine()
        {
            InitializeComponent();
        }

        private void xuiCustomPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mine_Load(object sender, EventArgs e)
        {
            FrmTurn frm = new FrmTurn();
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(frm);
        }

        private void xuiSuperButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer();
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(frm);
        }

        private void BtnTurn_Click(object sender, EventArgs e)
        {
            FrmTurn frm = new FrmTurn();
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(frm);
        }

        private void BtnDate_Click(object sender, EventArgs e)
        {
            FrmDateOperation frm = new FrmDateOperation();
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(frm);
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(frm);
        }

        private void BtnGozaresh_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            gunaPanel1.Controls.Clear();
            gunaPanel1.Controls.Add(frm);

        }

        private void BtnBalckUp_Click(object sender, EventArgs e)
        {
            BackUp frm = new BackUp();
            frm.BtnBackup_Click(null,null);
            //gunaPanel1.Controls.Clear();
            //gunaPanel1.Controls.Add(frm);
            //bunifuTransition1.HideSync(gunaElipsePanel1, false, Animation.VertBlind);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnTurn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnDate_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnBalckUp_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnGozaresh_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void BtnUser_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Mine_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void xuiCustomPictureBox2_Click(object sender, EventArgs e)
        {
            //show menu
        }

        private void xuiCustomPictureBox1_Click_1(object sender, EventArgs e)
        {
            //hide menu
        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            FrmAbout frm = new FrmAbout();
            frm.Show();
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            BackUp frm = new BackUp();
            frm.BtnRestore_Click(null, null);
        }

        private void xuiSwitch1_Click(object sender, EventArgs e)
        {
            if (xuiSwitch1.SwitchState == XUISwitch.State.On)
            {
                this.BackColor = this.BackColor = Color.FromArgb(54, 53, 55);
                gunaPanel1.BackColor = this.BackColor = Color.FromArgb(54, 53, 55);
            }
            else
            {
                this.BackColor = this.BackColor = Color.FromArgb(185, 186, 197);
                gunaPanel1.BackColor = this.BackColor = Color.FromArgb(185, 186, 197);
            }
        }
    }
}
