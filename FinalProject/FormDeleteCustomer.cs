using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormDeleteCustomer : Form
    {
        //  Global variables
        string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ranken\Desktop\FinalProject\FinalProject\SalesOrdersDB.mdf;Integrated Security=True";

        string firstName = "";
        string lastName  = "";
        string address   = "";
        string city      = "";
        string state     = "";
        string zip       = "";
        int    areaCode  = 0;
        string phone     = "";
        string fullName  = "";


        public FormDeleteCustomer()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            //  The database connection
            SqlConnection conn = new SqlConnection(connectionString);

            //  The actual query
            String sql = "SELECT * FROM customers";

            //  Open database connection
            conn.Open();

            //  The actual command and connection string
            SqlCommand command = new SqlCommand(sql, conn);

            //  Create a DataReader to hold the query results
            SqlDataReader dataReader;

            try
            {
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    fullName = dataReader["CustomerLastName"].ToString() + "," +
                               dataReader["CustomerFirstName"].ToString();
                    comboBoxFullName.Items.Add(fullName);
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "FillComboBox()");
            }

            //  Close database connection
            conn.Close();
        }

        private void buttonBackToCustomerMainForm_Click(object sender, EventArgs e)
        {
            //  Hide current form
            this.Hide();

            //  Create new instance of Customer Options form
            FormCustomerOptions customerForm = new FormCustomerOptions();

            //  Show Customer Options form
            customerForm.ShowDialog();
        }

        private void comboBoxFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = Convert.ToString(comboBoxFullName.SelectedItem);
            string[] vals = str.Split(',');
            string lName = vals[0];
            string fName = vals[1];

            //  Actual database connection
            SqlConnection conn = new SqlConnection(connectionString);

            //  The actual query
            string sql = "SELECT * FROM customers WHERE customerLastName = '" + lName + "' AND customerFirstName = '" + fName + "';";

            //  Open database connection
            conn.Open();

            // The command and connection string
            SqlCommand command = new SqlCommand(sql, conn);

            //  Create a DataReader to hold the query results
            SqlDataReader dataReader;

            try
            {
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id      = Convert.ToInt32(dataReader["customerID"].ToString());
                    firstName   = dataReader["customerFirstName"].ToString();
                    lastName    = dataReader["customerLastName"].ToString();
                    address     = dataReader["customerStreetAddress"].ToString();
                    city        = dataReader["customerCity"].ToString();
                    state       = dataReader["customerState"].ToString();
                    zip         = dataReader["customerZipCode"].ToString();
                    areaCode    = Convert.ToInt32(dataReader["customerAreaCode"].ToString());
                    phone       = dataReader["customerPhoneNumber"].ToString();
                    textBoxFirstName.Text   = firstName;
                    textBoxLastName.Text    = lastName;
                    textBoxAddress.Text     = address;
                    textBoxCity.Text        = city;
                    textBoxState.Text       = state;
                    textBoxZip.Text         = zip;
                    textBoxAreaCode.Text    = areaCode.ToString();
                    textBoxPhoneNumber.Text = phone;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ComboBoxSelectedIndexChanged()");
            }

            //  Close database connection
            conn.Close();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            removeRecordFromDatabase();
        }

        private void removeRecordFromDatabase()
        {
            try
            {
                //  This will be the actual database connection
                SqlConnection conn = new SqlConnection(connectionString);

                //  Open database connection
                conn.Open();

                if (MessageBox.Show("Are you sure you want to delete record:\n" +
                                     firstName + " " + lastName + " from the database?",
                                    "REMOVE CURRENT RECORD?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                {
                    clearCustomerForm();
                    return;
                }

                //  This will hold the string 
                //  representing the actual SQL command
                string sql = "DELETE FROM customers WHERE customerFirstName = '" + firstName + "'  AND  customerLastName = '" + lastName + "';";
                                    //  customerFirstName = '" + firstName + "'
                //  This will hold the actual command
                //  and connection string
                SqlCommand command = new SqlCommand(sql, conn);

                //  Database adapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                //  Perform the insert
                dataAdapter.DeleteCommand = new SqlCommand(sql, conn);
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Record Has Been Successfully Deleted",
                               "SUCCESSFUL RECORD INSERT",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                command.Dispose();
                conn.Close();

                clearCustomerForm();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Record Delete Failed\n" + ex.Message,
                               "ERROR OCCURRED",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void clearCustomerForm()
        {
            textBoxFirstName.Text   = "";
            textBoxLastName.Text    = "";
            textBoxAddress.Text     = "";
            textBoxCity.Text        = "";
            textBoxState.Text       = "";
            textBoxZip.Text         = "";
            textBoxAreaCode.Text    = "";
            textBoxPhoneNumber.Text = "";
            firstName               = "";
            lastName                = "";
            address                 = "";
            city                    = "";
            state                   = "";
            zip                     = "";
            areaCode                = 0;
            phone                   = "";
        }
    }
}
