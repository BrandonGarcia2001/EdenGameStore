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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuMainItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMainItmAbout_Click(object sender, EventArgs e)
        {
            //displays form
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void mnuMainItmShopVideoGames_Click(object sender, EventArgs e)
        {
            //displays form
            frmShopNow frmShopNow = new frmShopNow();
            frmShopNow.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes form
            ProgOps.CloseDatabase();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //point to the help file
            hlpHelp.HelpNamespace = Application.StartupPath + "\\Help.chm";

            //opens database
            ProgOps.OpenDatabase();
        }

        private void mnuMainItmHelp_Click(object sender, EventArgs e)
        {
            //points to help form
            Help.ShowHelp(this, hlpHelp.HelpNamespace);
        }
    }
}
