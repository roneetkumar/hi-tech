using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitechClass.Validation;
using Hi_Tech_Order_Management_System.Data_Model;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class OrderForm : Form
    {
        HitechDBEntities5 dbEntities = new HitechDBEntities5();


        public OrderForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
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

        private void OrderForm_Load(object sender, EventArgs e)
        {
            var listCust = from cus in dbEntities.Customers
                           select cus;

            foreach (Customer item in listCust)
            {
                comboBoxCustomer.Items.Add(item.CustomerId);
            }

            var listEmp = from emp in dbEntities.Employees
                          select emp;

            foreach (Employee item in listEmp)
            {
                comboBoxPublisher.Items.Add(item.EmployeeId);
            }

            var listOrder = from emp in dbEntities.Orders
                            select emp;

            foreach (Order item in listOrder)
            {
                comboBoxsearch.Items.Add(item.OrderID);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Order odr = new Order();
            var value = Convert.ToInt32(TextboxOrderId.Text);


            odr.OrderID = Convert.ToInt32(TextboxOrderId.Text);
            odr.PlacedDate = Convert.ToDateTime(maskedTextBoxPlacedDate.Text);
            odr.ArrivingDate = Convert.ToDateTime(maskedTextBoxArrivalDate.Text);
            odr.EmployeeId = Convert.ToInt32(comboBoxPublisher.Text);
            odr.CustomerId = Convert.ToInt32(comboBoxCustomer.Text);

            dbEntities.Orders.Add(odr);
            dbEntities.SaveChanges();
            MessageBox.Show("Record has been saved .", "Confirmation");

        }


        private void updateButton_Click(object sender, EventArgs e)
        {

            Order odr = new Order();
            var value = Convert.ToInt32(TextboxOrderId.Text);
            odr = dbEntities.Orders.Find(value);
            if (odr != null)
            {
                odr.OrderID = Convert.ToInt32(TextboxOrderId.Text);
                odr.PlacedDate = Convert.ToDateTime(maskedTextBoxPlacedDate.Text);
                odr.ArrivingDate = Convert.ToDateTime(maskedTextBoxArrivalDate.Text);
                odr.EmployeeId = Convert.ToInt32(comboBoxPublisher.Text);
                odr.CustomerId = Convert.ToInt32(comboBoxCustomer.Text);


                dbEntities.SaveChanges();
                MessageBox.Show("Record has been updated .", "Confirmation");
            }


        }

        private void ListUser_Click(object sender, EventArgs e)
        {



            //LINQ query
            var listProject = (from pa in dbEntities.Orders

                               select new
                               {
                                   OrderId = pa.OrderID,
                                   Arrivaldate = pa.ArrivingDate,
                                   placedate = pa.PlacedDate,
                                   customerid = pa.CustomerId,
                                   emmployeeId = pa.EmployeeId


                               });

            

            listViewDisplay.Items.Clear();
            foreach (var item in listProject)
            {
                ListViewItem _item = new ListViewItem(item.OrderId.ToString());
                _item.SubItems.Add((item.Arrivaldate).ToString());
                _item.SubItems.Add(item.placedate.ToString());
                _item.SubItems.Add(item.customerid.ToString());
                _item.SubItems.Add(item.emmployeeId.ToString());
                listViewDisplay.Items.Add(_item);
            }
        }

        private void deleleBtn_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Order odr = new Order();

                    var value = Convert.ToInt32(TextboxOrderId.Text);
                    odr = dbEntities.Orders.Find(value);
                    dbEntities.Orders.Remove(odr);
                    dbEntities.SaveChanges();
                    MessageBox.Show("Employee record has been deleted .", "Confirmation");
                }
                else
                {
                    return;
                }

            }
            
    
      


        private void searchButton_Click(object sender, EventArgs e)
        {
            Order emp = new Order();

            int searchId = Convert.ToInt32(comboBoxsearch.Text);
            emp = dbEntities.Orders.Where(x => x.OrderID == searchId).FirstOrDefault();
           
           
         
            if (emp != null)
            {
               
                TextboxOrderId.Text = emp.OrderID.ToString();
              
                comboBoxPublisher.Text = emp.EmployeeId.ToString();
                comboBoxCustomer.Text = emp.CustomerId.ToString();

                
            }
          
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxPlacedDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}