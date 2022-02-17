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
#endregion

namespace Matab3
{
    public partial class FrmLogin : Form
    {
        User use = new User();
        User_BLL bll = new User_BLL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region ورود به برنامه

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            if (bll.Regester(TxtUseName.Text, TxtPassword.Text) == 1)
            {
                Mine m = new Mine();
                m.Show();
                this.Hide();
            }
            else if (bll.Regester(TxtUseName.Text, TxtPassword.Text) == 2)
            {
                MessageBox.Show("نام کاربری یا رمز عبور اتباه است");
            }
            else
            {
                use.UserName = TxtUseName.Text;
                use.Password = TxtPassword.Text;
                bll.Create(use);
                Mine m = new Mine();
                m.Show();
            }
        }
        #endregion

        #region خروج از برنامه
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region لود برنامه
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FrmLogo frm = new FrmLogo();
            frm.ShowDialog();
            if (bll.CheckNull() == 1)
            {
                MessageBox.Show("شما برای بار اول است که وارد میشوید نام کار بری و رمز عبور که وارد میکنید ثبت خواهد شد");
            }
            TxtUseName.Focus();
        }
        #endregion

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtUseName_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BtnExit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }

        #region لینک اینستا
        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/Hamid_Programer_Pro/");
        }
        #endregion

        #region لینک تلگرام
        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://telegram.me/Hamid_Reza_Master");
        }
        #endregion

        private void TxtUseName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bll.Regester(TxtUseName.Text, TxtPassword.Text) == 1)
                {
                    Mine m = new Mine();
                    m.Show();
                    this.Hide();
                }
                else if (bll.Regester(TxtUseName.Text, TxtPassword.Text) == 2)
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اتباه است");
                }
                else
                {
                    use.UserName = TxtUseName.Text;
                    use.Password = TxtPassword.Text;
                    bll.Create(use);
                    Mine m = new Mine();
                    m.Show();
                }
            }
        }
    }
}
