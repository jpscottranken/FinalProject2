using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormSODBMainScreen : Form
    {
        public FormSODBMainScreen()
        {
            InitializeComponent();
        }

        /*
         * 
         *  We will first set the connectionString equal to the
         *  path/name of the database.  We get this from the
         *  following:
         *  
         *  Right mouse-click on the database name in the Server
         *  Explorer window and we will choose Properties.  We
         *  will then go to the Properties window and copy the
         *  entire ConnectionString property that is there.  It
         *  will start with a "@" and everything else in this
         *  connection string will go between "".
         *  
         *  Here are the components of the ConnectionString:
         *  
         *  The first thing will look like: 
         *  
         *  Data Source=(LocalDB)\MSSQLLocalDB   This is the
         *  data source, i.e. where on the machine the database
         *  resides.  For us, it's our local machine.
         *  
         *  AttachOnFilename="C:\Users\Ranken\Desktop\SalesOrdersDB\SalesOrdersDB\SalesOrdersDB.mdf";
         *  This is the actual path to the database itself.
         *  
         *  Integrated Security=True;
         *  This specifies Windows authenticaion will be used.  In
         *  other words, we will NOT require users to enter a user
         *  name and password.
         *  
         */

        // Create global variables

        //  Set SQL connection string
        string connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ranken\Desktop\FinalProject\FinalProject\SalesOrdersDB.mdf;Integrated Security=True";

        //  This will be the actual database connection
        SqlConnection conn = null;

        //  This will hold the acutal command and connection string
        SqlCommand command = null;

        //  This will hold the read-only dataReader
        SqlDataReader dataReader = null;

        //  This will hold a string representing the actual SQL command
        string sql = "";

        //  This will hold the command output.  For
        //  now, we will just print out the contents
        //  using a MessageBox.
        string output = "";

        //  This is the code that executes when
        //  the Customers button is clicked.
        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            //  Clear output variable
            output = "";

            //  try/catch block
            try
            {
                //  Set the connection string
                conn = new SqlConnection(connectionString);

                //  Open the database connection
                conn.Open();

                //  Put in SQL Command
                //  NOTE: Equivalent to SELECT * FROM customers;
                sql = "SELECT TOP 10 customerFirstName, customerLastName, customerStreetAddress, customerCity, customerState, customerZipCode, customerAreaCode, customerPhoneNumber FROM Customers Order By customerID DESC";
                
                //  A SqlCommand object lets you query and send commands
                //  to a database.  It has methods that are specialized
                //  for different commands.
                command = new SqlCommand(sql, conn);

                //  The ExecuteReader method returns a SqlDataReader object
                //  for viewing the results of our SELECT query
                dataReader = command.ExecuteReader();

                //  Loop through the database and add the fields from
                //  each record to our global output variable
                while (dataReader.Read())
                {
                    output += dataReader.GetValue(0) + " "  +
                              dataReader.GetValue(1) + "\n" +
                              dataReader.GetValue(2) + "\n" +
                              dataReader.GetValue(3) + ", " +
                              dataReader.GetValue(4) + " "  +
                              dataReader.GetValue(5) + "\n" +
                              dataReader.GetValue(6) + "-"  +
                              dataReader.GetValue(7) + "\n\n";
                }

                //  Output record info in a MessageBox
                MessageBox.Show(output,
                                "Customer Records",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //  Close database connection
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  This is the code that executes when
        //  the Orders button is clicked.
        private void buttonOrders_Click(object sender, EventArgs e)
        {
            //  Clear output variable
            output = "";

            //  try/catch block
            try
            {
                //  Set the connection string
                conn = new SqlConnection(connectionString);

                //  Open the database connection
                conn.Open();

                //  Put in SQL Command
                //  NOTE: Equivalent to SELECT * FROM orders;
                sql = "SELECT TOP 10 orderDate, orderShipDate, customerID FROM Orders";	

                //  A SqlCommand object lets you query and send commands
                //  to a database.  It has methods that are specialized
                //  for different commands.
                command = new SqlCommand(sql, conn);

                //  The ExecuteReader method returns a SqlDataReader object
                //  for viewing the results of our SELECT query
                dataReader = command.ExecuteReader();

                //  Loop through the database and add the fields from
                //  each record to our global output variable
                while (dataReader.Read())
                {
                    output += "Order Date: " + dataReader.GetValue(0) + "\n" +
                              "Ship  Date: " + dataReader.GetValue(1) + "\n" +
                              "Cust  ID:   " + dataReader.GetValue(2) + "\n\n";
                 }

                //  Output record info in a MessageBox
                MessageBox.Show(output,
                                "Order Records",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //  Close database connection
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  This is the code that executes when
        //  the OrderDetails button is clicked.
        private void buttonOrderDetails_Click(object sender, EventArgs e)
        {
            //  Clear output variable
            output = "";

            //  try/catch block
            try
            {
                //  Set the connection string
                conn = new SqlConnection(connectionString);

                //  Open the database connection
                conn.Open();

                //  Put in SQL Command
                //  NOTE: Equivalent to SELECT * FROM orderDetails;
                sql = "SELECT TOP 10 orderID, productID, orderDetailQuotedPrice, orderDetailQuantityOrdered FROM OrderDetails";

                //  A SqlCommand object lets you query and send commands
                //  to a database.  It has methods that are specialized
                //  for different commands.
                command = new SqlCommand(sql, conn);

                //  The ExecuteReader method returns a SqlDataReader object
                //  for viewing the results of our SELECT query
                dataReader = command.ExecuteReader();

                //  Loop through the database and add the fields from
                //  each record to our global output variable
                while (dataReader.Read())
                {
                    output += "Order    ID: " + dataReader.GetValue(0) + "\n" +
                              "Product  ID: " + dataReader.GetValue(1) + "\n" +
                              "Quote Price: " + dataReader.GetValue(2) + "\n" +
                              "Qty Ordered: " + dataReader.GetValue(3) + "\n\n";
                }

                //  Output record info in a MessageBox
                MessageBox.Show(output,
                                "OrderDetail Records",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //  Close database connection
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  This is the code that executes when
        //  the Categories button is clicked.
        private void buttonCategories_Click(object sender, EventArgs e)
        {
            //  Clear output variable
            output = "";

            //  try/catch block
            try
            {
                //  Set the connection string
                conn = new SqlConnection(connectionString);

                //  Open the database connection
                conn.Open();

                //  Put in SQL Command
                //  NOTE: Equivalent to SELECT * FROM categories;
                sql = "SELECT categoryDescription FROM categories";

                //  A SqlCommand object lets you query and send commands
                //  to a database.  It has methods that are specialized
                //  for different commands.
                command = new SqlCommand(sql, conn);

                //  The ExecuteReader method returns a SqlDataReader object
                //  for viewing the results of our SELECT query
                dataReader = command.ExecuteReader();

                //  Loop through the database and add the fields from
                //  each record to our global output variable
                while (dataReader.Read())
                {
                    output += "Category Description: " + dataReader.GetValue(0) + "\n\n";
                }

                //  Output record info in a MessageBox
                MessageBox.Show(output,
                                "Categories Records",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //  Close database connection
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  This is the code that executes when
        //  the Products button is clicked.
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            //  Clear output variable
            output = "";

            //  try/catch block
            try
            {
                //  Set the connection string
                conn = new SqlConnection(connectionString);

                //  Open the database connection
                conn.Open();

                //  Put in SQL Command
                //  NOTE: Equivalent to SELECT * FROM products;
                sql = "SELECT TOP 7 productName, productDescShort, productDescLong, productImage, productPrice, productQty, categoryID FROM Products";

                //  A SqlCommand object lets you query and send commands
                //  to a database.  It has methods that are specialized
                //  for different commands.
                command = new SqlCommand(sql, conn);

                //  The ExecuteReader method returns a SqlDataReader object
                //  for viewing the results of our SELECT query
                dataReader = command.ExecuteReader();

                //  Loop through the database and add the fields from
                //  each record to our global output variable
                while (dataReader.Read())
                {
                    output += "Product Name:  " + dataReader.GetValue(0) + "\n" +
                              "Product Desc:  " + dataReader.GetValue(1) + " " +
                                                  dataReader.GetValue(2) + "\n" +
                                                  dataReader.GetValue(3) + "\n" +
                              "Product Price: " + dataReader.GetValue(4) + "\n" +
                              "Product Qty:   " + dataReader.GetValue(5) + "\n" +
                              "Category ID:    " + dataReader.GetValue(6) + "\n\n";
                }

                //  Output record info in a MessageBox
                MessageBox.Show(output,
                                "Product Records",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                //  Close database connection
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  This is the code that executes when
        //  the Exit button is clicked.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit the program now?",
                                "EXIT APPLICATION???",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonCustomerOptions_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Customer Options form
            FormCustomerOptions customerOptions = new FormCustomerOptions();

            //  Show Customer Options form
            customerOptions.ShowDialog();
        }

        private void buttonOrderOptions_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Order Options form
            FormOrderOptions orderOptions = new FormOrderOptions();

            //  Show Customer Options form
            orderOptions.ShowDialog();
        }

        private void buttonOrderDetailOptions_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of OrderDetail Options form
            FormOrderDetailOptions orderDetailOptions = new FormOrderDetailOptions();

            //  Show Customer Options form
            orderDetailOptions.ShowDialog();
        }

        private void buttonCategoryOptions_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Category Options form
            FormCategoryOptions categoryOptions = new FormCategoryOptions();

            //  Show Customer Options form
            categoryOptions.ShowDialog();
        }

        private void buttonProductOptions_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Product Options form
            FormProductOptions productOptions = new FormProductOptions();

            //  Show Customer Options form
            productOptions.ShowDialog();
        }
    }
}
