using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BrandonGarciaFinalProject
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= EdenGameStore_BG_2353SU21;User Id=bgarciasu212353;password=1847790";
        //build a connection to Movie store db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //est objects for VideoGames table
        private static SqlCommand _sqlVideoGamesCommand;
        private static SqlDataAdapter _daVideoGames = new SqlDataAdapter();
        private static DataTable _dtVideoGamesTable = new DataTable();
        //variables
        public static int custID;
        public static int orderID;
        public static void OpenDatabase()
        {
            //open the connection to gamestore db
            _cntDatabase.Open();
            
        }
        public static void CloseDatabase()
        {
            //method to close data and dispose of all objects
            //close connection
            _cntDatabase.Close();
            //dispose of db
            _cntDatabase.Dispose();
            
        }
        public static void DatabaseCommandVideoGames(DataGridView _dgvGameViewer)
        {
            //set cmd object to null
            _sqlVideoGamesCommand = null;
            //reset data adapter and data table to new
            _daVideoGames = new SqlDataAdapter();
            _dtVideoGamesTable = new DataTable();

            try
            {
                string query = "SELECT * FROM VideoGames;";
                //est cmd object
                _sqlVideoGamesCommand = new SqlCommand(query,_cntDatabase);
                //est data adapter
                _daVideoGames.SelectCommand = _sqlVideoGamesCommand;
                //fill data table
                _daVideoGames.Fill(_dtVideoGamesTable);
                //bind dgv to data table
                _dgvGameViewer.DataSource = _dtVideoGamesTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in filling VideoGames Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose of cmd, adapter, table obj
            _sqlVideoGamesCommand.Dispose();
            _daVideoGames.Dispose();
            _dtVideoGamesTable.Dispose();
        }
        public static void UpdateQuantity(string gName,int gQanity)
        {
            try
            {
                string query = "Update VideoGames Set Video_QuantityOnHand=" + gQanity + " Where Video_Title='" + gName + "'" + ";";
                //create update command
                _sqlVideoGamesCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlVideoGamesCommand.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Updating quantity in VideoGames Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show("Update quantity", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            _sqlVideoGamesCommand.Dispose();
            _daVideoGames.Dispose();
        }
        public static void GetNextCustomerID()
        {
            string query = "SELECT COUNT(DISTINCT CustomerID)From Customers;";
            //est sql command
            SqlCommand _getCustIDCommand;
            //sql command
            _getCustIDCommand = new SqlCommand(query, _cntDatabase);
            //returns value
            custID = 1+Convert.ToInt32(_getCustIDCommand.ExecuteScalar());
            //disposes command
            _getCustIDCommand.Dispose();
            
        }
        public static void GetNextOrderID()
        {

            string query = "SELECT COUNT(DISTINCT OrderID)From Orders;";
            //est sql command
            SqlCommand _getOrderIDCommand;
            //sql command
            _getOrderIDCommand = new SqlCommand(query, _cntDatabase);
            //returns value
            orderID = 1+Convert.ToInt32(_getOrderIDCommand.ExecuteScalar());
            //disposes command
            _getOrderIDCommand.Dispose();
        }
        public static void AddUserToOrdersTable(string upc,int quantity,double lineCost)
        {
            string query = "INSERT INTO Orders(OrderID,Video_Game_UPC,CustomerID,Order_Quantity,Total_Line_Cost)";
            query += " VALUES(@OrderID, @Video_Game_UPC, @CustomerID, @Order_Quantity, @Total_Line_Cost);";
            SqlCommand _sqlOrdersCommand;
            _sqlOrdersCommand = new SqlCommand(query, _cntDatabase);
            //parameters
            _sqlOrdersCommand.Parameters.AddWithValue("@OrderID", orderID);
            _sqlOrdersCommand.Parameters.AddWithValue("@Video_Game_UPC", upc);
            _sqlOrdersCommand.Parameters.AddWithValue("@CustomerID", custID);
            _sqlOrdersCommand.Parameters.AddWithValue("@Order_Quantity", quantity);
            _sqlOrdersCommand.Parameters.AddWithValue("@Total_Line_Cost", lineCost);
            // insert command
            _sqlOrdersCommand.ExecuteNonQuery();
            _sqlOrdersCommand.Dispose();
        }
        public static void AddUserToPurchaseTable(double subTotal,double taxAmt,double netTotal)
        {
            string query = "INSERT INTO Purchase(CustomerID,PurchaseID,SubTotal,TaxAmt,NetTotal)";
            query += " VALUES(@CustomerID,@PurchaseID,@SubTotal,@TaxAmt,@NetTotal);";
            SqlCommand _sqlPurchaseCommand;
            _sqlPurchaseCommand = new SqlCommand(query, _cntDatabase);
            //parameters
            _sqlPurchaseCommand.Parameters.AddWithValue("@PurchaseID", custID);
            _sqlPurchaseCommand.Parameters.AddWithValue("@SubTotal",subTotal);
            _sqlPurchaseCommand.Parameters.AddWithValue("@CustomerID", custID);
            _sqlPurchaseCommand.Parameters.AddWithValue("@TaxAmt",taxAmt);
            _sqlPurchaseCommand.Parameters.AddWithValue("@NetTotal",netTotal);
            // insert command
            _sqlPurchaseCommand.ExecuteNonQuery();
            _sqlPurchaseCommand.Dispose();
        }
        public static void AddUserToCustomersTabel(string firstName, string lastName,string address)
        {

            //inserts to customer tab;
            string query = "INSERT INTO Customers(CustomerID,Cust_FName,Cust_LName,Cust_Address)";
            query += " Values(@CustomerID,@Cust_FName,@Cust_LName,@Address);";
            //create insert command
            SqlCommand _sqlCustomersCommand;
            _sqlCustomersCommand = new SqlCommand(query, _cntDatabase);
            //parameters
            _sqlCustomersCommand.Parameters.AddWithValue("@CustomerID", custID);
            _sqlCustomersCommand.Parameters.AddWithValue("@Cust_FName", firstName);
            _sqlCustomersCommand.Parameters.AddWithValue("@Cust_LName", lastName);
            _sqlCustomersCommand.Parameters.AddWithValue("@Address", address);
            // insert command
            _sqlCustomersCommand.ExecuteNonQuery();
            _sqlCustomersCommand.Dispose();
        }
    }
}