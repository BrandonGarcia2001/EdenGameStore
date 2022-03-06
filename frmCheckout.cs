using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrandonGarciaFinalProject
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void frmCheckout_FormClosing(object sender, FormClosingEventArgs e)
        {
            //displays message
            MessageBox.Show("Thank you for shopping at Eden Game Store", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
