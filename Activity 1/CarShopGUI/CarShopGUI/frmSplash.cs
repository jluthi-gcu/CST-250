using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            //Stop timer.
            tmrMain.Stop();

            //Hide current form.
            this.Hide();

            //Open main form.
            Form frm = new frmMain();
            frm.ShowDialog();
        }
    }
}
