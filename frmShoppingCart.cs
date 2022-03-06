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
    public partial class frmShoppingCart : Form
    {
        //customer info
        public static string customerFName;
        public static string customerLName;
        public static string customerAddress;
        //pricing
        public static double subTotal = 0.00;
        public static double Tax = 0.00;
        public static double netTotal = 0.00;
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void btnRemoveItm_Click(object sender, EventArgs e)
        {
            if (frmShopNow.customerItems.Any())
            {

                //removes specified item
                for (int i = 0; i < lbxTitle.Items.Count; i++)
                {
                    if (lbxTitle.SelectedIndex.Equals(i))
                    {
                        //removes item from list boxes
                        lbxTitle.Items.RemoveAt(i);
                        lbxPrice.Items.RemoveAt(i);
                        lbxQuantity.Items.RemoveAt(i);
                        lbxTotal.Items.RemoveAt(i);
                        //add back quantity
                        int itemQuantity = frmShopNow.customerQuantity[i];
                        string itemName = frmShopNow.customerItems[i];
                        int maxQuantity = frmShopNow.gameMaxQuantity[i];
                        int newQuantity = maxQuantity;
                        //updates quantity
                        ProgOps.UpdateQuantity(itemName, newQuantity);
                        //removes item from lists
                        frmShopNow.customerItems.RemoveAt(i);
                        frmShopNow.customerItemPrice.RemoveAt(i);
                        frmShopNow.customerLineTotal.RemoveAt(i);
                        frmShopNow.customerQuantity.RemoveAt(i);
                        frmShopNow.gameMaxQuantity.RemoveAt(i);
                        frmShopNow.gameUpc.RemoveAt(i);
                    }
                }
                Pricing();
            }
            else
            {
                MessageBox.Show("There are no items in the cart to remove", "Cart Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnContinueShopping_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            //asks user if they would like to clear cart
            var result=MessageBox.Show("Are you sure you want to clear all the items in the cart", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result==DialogResult.Yes)
            {
                for (int i = 0; i < lbxTitle.Items.Count; i++)
                {
                    //add back quantity
                    int itemQuantity = frmShopNow.customerQuantity[i];
                    string itemName = frmShopNow.customerItems[i];
                    int maxQuantity = frmShopNow.gameMaxQuantity[i];
                    int newQuantity = maxQuantity;
                    //updates quantity
                    ProgOps.UpdateQuantity(itemName, newQuantity);
                }
                //clears list
                frmShopNow.customerItems.Clear();
                frmShopNow.customerItemPrice.Clear();
                frmShopNow.customerLineTotal.Clear();
                frmShopNow.customerQuantity.Clear();
                frmShopNow.gameMaxQuantity.Clear();
                frmShopNow.gameUpc.Clear();
                //clears list box
                lbxTitle.Items.Clear();
                lbxPrice.Items.Clear();
                lbxQuantity.Items.Clear();
                lbxTotal.Items.Clear();
                //displays values
                lblSubTotal.Text = string.Empty;
                lblTaxAmt.Text = string.Empty;
                lblNetTotal.Text = string.Empty;
            }
            
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            //adds info to list boxes
            for(int x = 0; x < frmShopNow.customerItems.Count;x++)
            {
                lbxTitle.Items.Add(frmShopNow.customerItems[x]);
                lbxPrice.Items.Add(frmShopNow.customerItemPrice[x]);
                lbxQuantity.Items.Add(frmShopNow.customerQuantity[x]);
                lbxTotal.Items.Add(frmShopNow.customerLineTotal[x]);
            }
            //calculates pricing
            Pricing();
        }
        void Pricing()
        {
            subTotal = 0;
            Tax = 0;
            netTotal = 0;
            //Calculates subtotal
            for(int i = 0; i < frmShopNow.customerItems.Count; i++)
            {
                subTotal += frmShopNow.customerLineTotal[i];
            }
            //calculates tax
            Tax = subTotal * .0825;
            //calculates net total
            netTotal = subTotal + Tax;
            //display values;
            lblSubTotal.Text = subTotal.ToString("c");
            lblTaxAmt.Text = Tax.ToString("c");
            lblNetTotal.Text = netTotal.ToString("c");
        }
        bool isCustomerInfoValid()
        {
            bool isValid = true;
            //validation for textboxes
            if (tbxFirstName.Text == string.Empty)
            {
                MessageBox.Show("Can not leave the first name text box empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }else if (tbxLastName.Text == string.Empty)
            {
                MessageBox.Show("Can not leave the last name text box empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }else if (tbxAddress.Text == string.Empty)
            {
                MessageBox.Show("Can not leave the address text box empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }
            //saves customer info into variables
            customerFName = tbxFirstName.Text;
            customerLName = tbxLastName.Text;
            customerAddress = tbxAddress.Text;

            return isValid;
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (isCustomerInfoValid() == true)
            {
                if (frmShopNow.customerItems.Any())
                {
                    //asks user if they would like to clear cart
                    var result = MessageBox.Show("Are you sure you want to confirm your purchase", "Complete Purchase", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        //gets next customer ID
                        ProgOps.GetNextCustomerID();
                        //gets next order ID
                        ProgOps.GetNextOrderID();
                        //add to customers table
                        ProgOps.AddUserToCustomersTabel(customerFName, customerLName,customerAddress);
                        //add cart to orders table
                        for(int x = 0; x < frmShopNow.customerItems.Count(); x++)
                        {
                            ProgOps.AddUserToOrdersTable(frmShopNow.gameUpc[x], frmShopNow.customerQuantity[x], frmShopNow.customerLineTotal[x]);
                        }
                        ProgOps.AddUserToPurchaseTable(subTotal, Tax, netTotal);
                    }
                    //creates an object of the report
                    CrystalReports.crptCheckout customerInfo = new CrystalReports.crptCheckout();
                    //set the database logon for the report
                    customerInfo.SetDatabaseLogon("bgarciasu212353", "1847790");
                    //create an object of frmViewer
                    frmCheckout frmCheckeout = new frmCheckout();
                    //clear crvViewer viewer
                    frmCheckeout.crvViewer.ReportSource = null;
                    //set crvViewer to report Object
                    frmCheckeout.crvViewer.ReportSource = customerInfo;
                    //display frmViewer
                    frmCheckeout.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Can not proceed to checkout with an empty cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
