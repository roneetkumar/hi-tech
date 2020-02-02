using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitechClass.DataAccess;
using HitechClass.Business;
using HitechClass.Validation;
using System.Data.SqlClient;




namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class CustomerForm : Form
    {
        SqlDataAdapter da;
        DataTable dtcustomer;
        SqlCommandBuilder sqlBuilder;
        DataSet dsHitechDB;



        Customer aCustomers = new Customer();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            dsHitechDB = new DataSet("HitechDB");
            SqlCommandBuilder cmdBldr = new SqlCommandBuilder(da);
            dtcustomer = new DataTable("Customers");





            DataColumn dcName = new DataColumn("Name", typeof(String));
            DataColumn dcCustomerId = new DataColumn("CustomerId", typeof(Int32));
            DataColumn dcCity = new DataColumn("City", typeof(String));
            DataColumn dcPostalCode = new DataColumn("PostalCode", typeof(String));
            DataColumn dcPhoneNumber = new DataColumn("PhoneNumber", typeof(String));
            DataColumn dcFaxNumber = new DataColumn("FaxNumber", typeof(String));


            DataColumn dcCreditLimit = new DataColumn("CreditLimit", typeof(Int32));

            DataColumn dcStreet = new DataColumn("Street", typeof(String));

            dtcustomer.Columns.Add(dcName);
            dtcustomer.Columns.Add(dcCustomerId);
            dtcustomer.Columns.Add(dcCity);
            dtcustomer.Columns.Add(dcPhoneNumber);
            dtcustomer.Columns.Add(dcPostalCode);


            dtcustomer.Columns.Add(dcFaxNumber);

            dtcustomer.Columns.Add(dcCreditLimit);

            dtcustomer.Columns.Add(dcStreet);
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dtcustomer.Columns["CustomerId"];
            dtcustomer.PrimaryKey = PrimaryKeyColumns;

            dsHitechDB.Tables.Add(dtcustomer);




            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=DESKTOP-NOC7ELQ;database=HitechDB;user=sa;password=qwerty";
            string queryString = "SELECT * from Customers";
            da = new SqlDataAdapter(queryString, conn);


            da.Fill(dsHitechDB, "Customers");
            conn.Close();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            string input = "";
            input = name.Text.Trim();
            Customer cs = new Customer();
            if (!Validator.IsValidFullName(input))
            {

                label_name.Text = "eg:-Nitin or Roneet";
                name.Clear();
                name.Focus();
                return;
            }
            input = id.Text.Trim();

            if (!Validator.IsValidId(input, 4))
            {
                label_customer.Text = "eg:-1234";
                id.Clear();
                id.Focus();
                return;

            }
            int csId = Convert.ToInt32(id.Text.Trim());
            if (!(cs.IsUniqueId(csId)))
            {
                MessageBox.Show("This  ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label_customer.Text = "Try different ID";
                id.Clear();
                id.Focus();
                return;
            }

            input = city.Text.Trim();
            if (!Validator.IsValidCity(input))
            {
                label_city.Text = "For eg:- Montreal or New York";
                city.Clear();
                city.Focus();
                return;
            }

            input = phoneno.Text.Trim();
            if (!Validator.IsValidPhone(input))
            {
                label_phone.Text = "For eg:- 111-111-1111";
                phoneno.Clear();
                phoneno.Focus();
                return;
            }
            input = postal.Text.Trim();
            if (!Validator.IsValidPostal(input))
            {
                label_postal.Text = "For eg:- h3h2b7 or H3H2B7";

                postal.Clear();
                postal.Focus();
                return;
            }

            input = fax.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                label_fax.Text = "for eg:- 1234 or 1254";

                fax.Clear();
                fax.Focus();
                return;
            }
            input = credit.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                label_credit.Text = "for eg:- from 1000 to 9999";

                credit.Clear();
                credit.Focus();
                return;
            }
            input = street.Text.Trim();
            if (!Validator.IsValidCity(input))
            {
                label_street.Text = "for eg:- Fort Street";

                street.Clear();
                street.Focus();
                return;
            }

            aCustomers.Name = name.Text.Trim();
            aCustomers.CustomerId = Convert.ToInt32(id.Text.Trim());
            aCustomers.City = city.Text.Trim();
            aCustomers.PhoneNumber = phoneno.Text.Trim();
            aCustomers.PostalCode = postal.Text.Trim();
            aCustomers.FaxNumber = fax.Text.Trim();
            aCustomers.CreditLimit = Convert.ToInt32(credit.Text.Trim());
            aCustomers.Street = street.Text.Trim();
            dtcustomer.Rows.Add(aCustomers.Name, aCustomers.CustomerId, aCustomers.City, aCustomers.PhoneNumber, aCustomers.PostalCode, aCustomers.FaxNumber, aCustomers.CreditLimit, aCustomers.Street);
            dsHitechDB.EnforceConstraints = false;
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT into Customers(Name,CustomerId,City,PostalCode,PhoneNumber,FaxNumber,CreditLimit,Street)" +
                               " VALUES (@name,@id,@city,@postal,@phone,@fax,@credit,@street)";

            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@city", city.Text);
            cmd.Parameters.AddWithValue("@postal", postal.Text);
            cmd.Parameters.AddWithValue("@phone", phoneno.Text);
            cmd.Parameters.AddWithValue("@fax", fax.Text);
            cmd.Parameters.AddWithValue("@credit", credit.Text);
            cmd.Parameters.AddWithValue("@street", street.Text);
            cmd.ExecuteNonQuery();


            sqlBuilder = new SqlCommandBuilder(da);
            da.Fill(dsHitechDB, "Customers");

            MessageBox.Show("Record added successfully");
            connDB.Close();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();

           
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Customers", connDB);

            dtcustomer = new DataTable();

            adapt.Fill(dtcustomer);
           
            dataGridView.DataSource = dtcustomer;
            connDB.Close();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string input = "";
            input = name.Text.Trim();
            Customer cs = new Customer();
            if (!Validator.IsValidFullName(input))
            {

                label_name.Text = "eg:-Roneet or Nitin";
                name.Clear();
                name.Focus();
                return;
            }
            input = id.Text.Trim();

            if (!Validator.IsValidId(input, 4))
            {
                label_customer.Text = "eg:-1234";
                id.Clear();
                id.Focus();
                return;

            }


            input = city.Text.Trim();
            if (!Validator.IsValidCity(input))
            {
                label_city.Text = "For eg:- Montreal or New York";
                city.Clear();
                city.Focus();
                return;
            }

            input = phoneno.Text.Trim();
            if (!Validator.IsValidPhone(input))
            {
                label_phone.Text = "For eg:- 111-111-1111";
                phoneno.Clear();
                phoneno.Focus();
                return;
            }
            input = postal.Text.Trim();
            if (!Validator.IsValidPostal(input))
            {
                label_postal.Text = "For eg:- h3h2b7 or H3H2B7";

                postal.Clear();
                postal.Focus();
                return;
            }

            input = fax.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                label_fax.Text = "for eg:- 1234 or 1254";

                fax.Clear();
                fax.Focus();
                return;
            }
            input = credit.Text.Trim();
            if (!Validator.IsValidId(input))
            {
                label_credit.Text = "for eg:- from 1000 to 9999";

                credit.Clear();
                credit.Focus();
                return;
            }
            input = street.Text.Trim();
            if (!Validator.IsValidCity(input))
            {
                label_street.Text = "for eg:- Fort Street";

                street.Clear();
                street.Focus();
                return;
            }

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd = new SqlCommand("update [Customers] set Name=@name,City=@city,PostalCode=@postal,PhoneNumber=@phone,FaxNumber=@fax,CreditLimit=@credit,Street =@street where CustomerId=@id", connDB);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@city", city.Text);
            cmd.Parameters.AddWithValue("@postal", postal.Text);
            cmd.Parameters.AddWithValue("@phone", phoneno.Text);
            cmd.Parameters.AddWithValue("@fax", fax.Text);
            cmd.Parameters.AddWithValue("@credit", credit.Text);
            cmd.Parameters.AddWithValue("@street", street.Text);

            cmd.ExecuteNonQuery();


            sqlBuilder = new SqlCommandBuilder(da);
            da.Fill(dsHitechDB, "Customers");
            MessageBox.Show("Database has been updated .", "Confirmation");
            connDB.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                ManagerForm managerform = new ManagerForm();
                managerform.Show();
            }
            else
            {
                return;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Do you  want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {

                    SqlConnection connDB = UtilityDB.ConnectDB();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connDB;
                    cmd = new SqlCommand("delete [Customers] where CustomerId=@id", connDB);
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Record Deleted Successfully!");

                    da.Fill(dsHitechDB, "Customers");
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" enter valid data", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try

            {
                int selectedIndex = comboBox2.SelectedIndex;
                switch (selectedIndex)
                {

                    case 1:
                        SqlConnection connDB = UtilityDB.ConnectDB();



                        SqlDataAdapter adapt = new SqlDataAdapter("select * from Customers where CustomerId = " + textBox12.Text , connDB);
                        dtcustomer = new DataTable();
                        adapt.Fill(dtcustomer);
                        dataGridView.DataSource = dtcustomer;
                        connDB.Close();
                        break;
                    case 2:
                        if (!(Validator.IsValidName(textBox12.Text.Trim())))
                        {
                            textBox12.Clear();
                            textBox12.Focus();
                            return;
                        }



                        connDB = UtilityDB.ConnectDB();

                        adapt = new SqlDataAdapter("select * from Customers where Name like'" + textBox12.Text + "%'", connDB);
                        dtcustomer = new DataTable();
                        adapt.Fill(dtcustomer);
                        dataGridView.DataSource = dtcustomer;
                        connDB.Close();
                        break;

                    default:
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(" enter some data", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBox2.SelectedIndex;
            switch (indexSelected)
            {
                case 1:
                    labelMessage.Text = " enter Id";
                    textBox12.Clear();
                    textBox12.Focus();
                    break;
                case 2:
                    labelMessage.Text = " enter First Name";
                    textBox12.Clear();
                    textBox12.Focus();
                    break;
               
                default:
                    labelMessage.Text = " select the search option";
                    break;

            }
        }
    }
}

        