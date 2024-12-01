using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEnrollifyCS
{

    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {

            frmLogin f = new frmLogin();
            tmrSplash.Stop ();
            f.Show();
            this.Hide();
     
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
