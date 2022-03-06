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
    
    public partial class frmShopNow : Form
    {
        //global list variables
        public static List<string> customerItems = new List<string>();
        public static List<int> customerQuantity = new List<int>();
        public static List<double> customerItemPrice = new List<double>();
        public static List<double> customerLineTotal = new List<double>();
        public static List<int> gameMaxQuantity = new List<int>();
        public static List<string> gameUpc = new List<string>();
        //global variables
        public static string itemUpc;
        public static int itemQuantity;
        public static string itemName;
        public static double price;
        public static int maxQuantity = 0;
        public frmShopNow()
        {
            InitializeComponent();
        }

        private void frmShopNow_Load(object sender, EventArgs e)
        {
            //loads tables into data grid viewer
            ProgOps.DatabaseCommandVideoGames(dgvGameViewer);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            //closes current form
            this.Close();
            
        }

        private void frmShopNow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        //populates combo box
        void populateControlbox(int quantity)
        {
            cbxQunatity.Items.Clear();
            for (int x = 0; x < quantity + 1; x++)
            {
                cbxQunatity.Items.Add(x);
            }
        }
        private void dgvGameViewer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //variables
            string imageId = "";
            DataGridViewRow row;
            //clears items in combo box
            cbxQunatity.Items.Clear();
            //checks if row is valid
            if (e.RowIndex >= 0)
            {
                row = dgvGameViewer.Rows[e.RowIndex];
                imageId = row.Cells[5].Value.ToString();
                maxQuantity = Convert.ToInt32(row.Cells[4].Value);
                itemUpc = row.Cells[0].Value.ToString();
                itemName = row.Cells[1].Value.ToString();
                price = Convert.ToDouble(row.Cells[3].Value);
            }
            //if structure checks if image id matches to displays matching image
            if (imageId== "1")
            {
                //displays image in picture box
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.Skyrim;
                //fills comb box with appropriate quantity on hand
                populateControlbox(maxQuantity);
            }
            if (imageId == "2")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.SFV;
                //fills combo box with appropriate quantity on hand
                populateControlbox(maxQuantity);
            }
            if (imageId == "3")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.Darksouls3;
                populateControlbox(maxQuantity);
            }
            if (imageId == "4")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.Overwatch;
                populateControlbox(maxQuantity);
            }
            if (imageId == "5")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.GtaV_;
                populateControlbox(maxQuantity);
            }
            if (imageId == "6")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.ModernWarfarejpg;
                populateControlbox(maxQuantity);
            }
            if (imageId == "7")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.MasterChief;
                populateControlbox(maxQuantity);
            }
            if (imageId == "8")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.YakuzaKiwami;
                populateControlbox(maxQuantity);
            }
            if (imageId == "9")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.MarioKart;
                populateControlbox(maxQuantity);
            }
            if (imageId == "10")
            {
                pbxGameDisplay.Image = BrandonGarciaFinalProject.Properties.Resources.MonsterHunter;
                populateControlbox(maxQuantity);
            }
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            
            // directs client to new form
            frmShoppingCart frmShoppingCart = new frmShoppingCart();
            //displays form
            if (!customerItems.Any())
            {
                MessageBox.Show("Can not proceed with an empty cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmShoppingCart.ShowDialog();
            }
            
        }

        private void btnAddToCart_Click(object sender, EventArgs e )
        {
            //checks if combo box is empty
            if (cbxQunatity.Text == string.Empty)
            {
                //displays appropriate error message
                MessageBox.Show("You must select a quantity for the selected game", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbxQunatity.Text == "0")
            {
                MessageBox.Show("Can not add 0 as a quantity for " + itemName, "Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (customerItems.Contains(itemName))
            {
                MessageBox.Show("Item is already in the cart\n\n(To update quantity remove item from cart and enter correct amount)", "Cart Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                //stores text into integer variable
                itemQuantity = Convert.ToInt32(cbxQunatity.SelectedItem);
                //add item and its info to their respective lists
                customerItems.Add(itemName);
                customerItemPrice.Add(price);
                customerQuantity.Add(itemQuantity);
                gameMaxQuantity.Add(maxQuantity);
                gameUpc.Add(itemUpc);
                customerLineTotal.Add(price * itemQuantity);
                //removes quantity
                int newQuantity = 0;
                newQuantity = maxQuantity - itemQuantity;
                //calls update
                ProgOps.UpdateQuantity(itemName, newQuantity);
                //message box
                MessageBox.Show(itemName + " has been added to the cart", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //reestablishes data grid viewer
                ProgOps.DatabaseCommandVideoGames(dgvGameViewer);
            }
            
        }

        private void frmShopNow_Activated(object sender, EventArgs e)
        {
            ProgOps.DatabaseCommandVideoGames(dgvGameViewer);
        }
    }
}
