using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matab3
{
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.03;
            }

            if (this.Opacity == 1)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void FrmLogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
