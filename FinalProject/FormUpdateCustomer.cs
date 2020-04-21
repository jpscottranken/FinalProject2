using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormUpdateCustomer : Form
    {
        //  Global variables
        string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ranken\Desktop\FinalProject\FinalProject\SalesOrdersDB.mdf;Integrated Security=True";

        string firstName    = "";
        string lastName     = "";
        string address      = "";
        string city         = "";
        string state        = "";
        string zip          = "";
        int    areaCode     = 0;
        string phone        = "";
        string fullName = "";

        public FormUpdateCustomer()
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
            FormCategoryOptions categoryForm = new FormCategoryOptions();

            //  Show Customer Options form
            categoryForm.ShowDialog();
        }

        private void comboBoxFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str      = Convert.ToString(comboBoxFullName.SelectedItem);
            string[] vals   = str.Split(',');
            string lName    = vals[0];
            string fName    = vals[1];

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

                while(dataReader.Read())
                {
                    int    id    = Convert.ToInt32(dataReader["customerID"].ToString());
                    string first = dataReader["customerFirstName"].ToString();
                    string last  = dataReader["customerLastName"].ToString();
                    string addr  = dataReader["customerStreetAddress"].ToString();
                    string city  = dataReader["customerCity"].ToString();
                    string state = dataReader["customerState"].ToString();
                    string zip   = dataReader["customerZipCode"].ToString();
                    int    area  = Convert.ToInt32(dataReader["customerAreaCode"].ToString());
                    string phone = dataReader["customerPhoneNumber"].ToString();
                    textBoxFirstName.Text   = first;
                    textBoxLastName.Text    = last;
                    textBoxAddress.Text     = addr;
                    textBoxCity.Text        = city;
                    textBoxState.Text       = state;
                    textBoxZip.Text         = zip;
                    textBoxAreaCode.Text    = area.ToString();
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

        private void buttonUpdateRecord_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;
            keepGoing = validateFirstName();

            if (keepGoing)
            {
                firstName = textBoxFirstName.Text;
                keepGoing = validateLastName();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                lastName = textBoxLastName.Text;
                keepGoing = validateAddress();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                address = textBoxAddress.Text;
                keepGoing = validateCity();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                city = textBoxCity.Text;
                keepGoing = validateState();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                state = textBoxState.Text;
                keepGoing = validateZip();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                zip = textBoxZip.Text;
                keepGoing = validateAreaCode();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                areaCode = Convert.ToInt32(textBoxAreaCode.Text);
                keepGoing = validatePhone();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                phone = textBoxPhoneNumber.Text;
                MessageBox.Show("ALL FIELDS VALID!!!", "PASSED");
                writeRecordToDataBase();
            }
        }

        private bool validateFirstName()
        {
            if (textBoxFirstName.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("First Name Cannot Be Empty!",
                                      "FIRST NAME EMPTY");
                textBoxFirstName.Focus();
                return false;
            }

            return true;
        }

        private bool validateLastName()
        {
            if (textBoxLastName.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("Last Name Cannot Be Empty!",
                                      "LAST NAME EMPTY");
                textBoxLastName.Focus();
                return false;
            }

            return true;
        }

        private bool validateAddress()
        {
            if (textBoxAddress.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("Address Cannot Be Empty!",
                                      "ADDRESS NAME EMPTY");
                textBoxAddress.Focus();
                return false;
            }

            return true;
        }

        private bool validateCity()
        {
            if (textBoxCity.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("City Cannot Be Empty!",
                                      "CITY NAME EMPTY");
                textBoxCity.Focus();
                return false;
            }

            return true;
        }

        private bool validateState()
        {
            string[] states = new string[]
            {
                    "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL",
                    "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME",
                    "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
                    "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI",
                    "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI",
                    "WY"
            };

            if (textBoxState.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("State Cannot Be Empty!",
                                      "STATE NAME EMPTY");
                textBoxState.Focus();
                return false;
            }

            foreach (string st in states)
            {
                if (textBoxState.Text.ToUpper() == st)
                {
                    return true;
                }
            }

            Helper.showMessageBox("State Abbreviation Entered Was Invalid!",
                                  "INVALID START ABBREVIATION");
            textBoxState.Text = "";
            textBoxState.Focus();
            return false;
        }

        private bool validateZip()
        {
            if (textBoxZip.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("Zip Cannot Be Empty!",
                                      "ZIPCODE FIELD EMPTY");
                textBoxZip.Focus();
                return false;
            }

            if (!Regex.Match(textBoxZip.Text, @"\d{5}-?(\d{4})?$").Success)
            {
                Helper.showMessageBox("Zip Must Be nnnnn or nnnnn-nnnn!",
                                      "ZIPCODE INVALID PATTERN");
                textBoxZip.Text = "";
                textBoxZip.Focus();
                return false;
            }

            return true;
        }

        private bool validateAreaCode()
        {
            if (textBoxAreaCode.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("Area Code Cannot Be Empty!",
                                      "AREA CODE FIELD EMPTY");
                textBoxAreaCode.Focus();
                return false;
            }

            if (!Regex.Match(textBoxAreaCode.Text, @"\d{3}").Success)
            {
                Helper.showMessageBox("Area Code Must Be nnn!",
                                      "AREA CODE INVALID PATTERN");
                textBoxAreaCode.Text = "";
                textBoxAreaCode.Focus();
            }

            return true;
        }

        private bool validatePhone()
        {
            if (textBoxPhoneNumber.Text == string.Empty.Trim())
            {
                Helper.showMessageBox("Phone Number Cannot Be Empty!",
                                      "PHONE NUMBER FIELD EMPTY");
                textBoxPhoneNumber.Focus();
                return false;
            }

            if (!Regex.Match(textBoxPhoneNumber.Text, @"\d{3}-\d{4}").Success)
            {
                Helper.showMessageBox("Phone Number Be nnn-nnnn!",
                                      "PHONE NUMBER INVALID PATTERN");
                textBoxPhoneNumber.Text = "";
                textBoxPhoneNumber.Focus();
            }

            return true;
        }

        private void writeRecordToDataBase()
        {
            MessageBox.Show("In method writeRecordToDataBase()");
            try
            {
                //  This will be the actual database connection
                SqlConnection conn = new SqlConnection(connectionString);

                //  Open database connection
                conn.Open();

                //  This will hold the string 
                //  representing the actual SQL command
                string sql = "UPDATE customers SET customerFirstName = '" + firstName + "', customerLastName = '" + lastName + "', customerStreetAddress = '" + address + "', customerCity = '" + city + "', customerState = '" + state + "', customerZipCode = '" + zip + "', customerAreaCode = '" + areaCode + "',  customerPhoneNumber = '" + phone + "';";

                //  This will hold the actual command
                //  and connection string
                SqlCommand command = new SqlCommand(sql, conn);

                //  Database adapter
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                //  Perform the insert
                dataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Record Has Been Successfully Updated",
                               "SUCCESSFUL RECORD INSERT",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                command.Dispose();
                conn.Close();

                clearCustomerForm();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Record Update Failed" + ex.Message,
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
