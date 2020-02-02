using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HitechClass.Business;
using HitechClass.DataAccess;
using HitechClass.Validation;

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ButtonList_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOption_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            string input = "";
            Employee emp = new Employee();
            input = textBoxEmp.Text.Trim();
            if (!Validator.IsValidId(input, 4))
            {
                textBoxEmp.Clear();
                textBoxEmp.Focus();
                return;

            }

            int tempId = Convert.ToInt32(textBoxEmp.Text.Trim());
            if (!(emp.IsUniqueEmployeeId(tempId)))
            {
                MessageBox.Show("This Employee ID already exists!", "Duplicate Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEmp.Clear();
                textBoxEmp.Focus();
                return;
            }

            input = textBoxFN.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxFN.Clear();
                textBoxFN.Focus();
                return;

            }

            input = textBoxLN.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxLN.Clear();
                textBoxLN.Focus();
                return;
            }

            input = textBoxJT.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxJT.Clear();
                textBoxJT.Focus();
                return;
            }


            emp.EmployeeId = Convert.ToInt32(textBoxEmp.Text.Trim());
            emp.FirstName = textBoxFN.Text.Trim();
            emp.LastName = textBoxLN.Text.Trim();
            emp.JobTitle = textBoxJT.Text.Trim();
            emp.SaveEmployee(emp);
            MessageBox.Show("Employee record has been saved .", "Employee Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListViewEmployee_Click(sender, e);

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Do you really want to delete this emplyee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Employee emp = new Employee();
                    emp.DeleteEmployee(Convert.ToInt32(textBoxEmp.Text));
                    MessageBox.Show("Employee Record has been deleted !", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListViewEmployee_Click(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter some data", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(textBoxEmp.Text.Trim());
                emp.FirstName = textBoxFN.Text.Trim();
                emp.LastName = textBoxLN.Text.Trim();
                emp.JobTitle = textBoxJT.Text.Trim();

                emp.UpdateEmployee(emp);

                MessageBox.Show("Employee Record updated !", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListViewEmployee_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter some data", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ListViewEmployee_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Employee emp = new Employee();
            List<Employee> listEmp = emp.GetEmployeeList();
            if (listEmp != null)
            {
                foreach (Employee empItem in listEmp)
                {
                    ListViewItem item = new ListViewItem(empItem.EmployeeId.ToString());
                    item.SubItems.Add(empItem.FirstName);
                    item.SubItems.Add(empItem.LastName);
                    item.SubItems.Add(empItem.JobTitle);
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No Employee Data in the database.", "No Employee Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void ComboBoxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBoxOption.SelectedIndex;
            switch (indexSelected)
            {
                case 1:
                    labelMessage.Text = " enter Employee Id";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 2:
                    labelMessage.Text = " enter First Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 3:
                    labelMessage.Text = " enter Last Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                default:
                    labelMessage.Text = " select the search option";
                    break;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            try

            {
                int selectedIndex = comboBoxOption.SelectedIndex;
                switch (selectedIndex)
                {
                    
                    case 1:
                        
                        if (!(Validator.IsValidId(textBoxSearch.Text.Trim())))
                        {
                            textBoxSearch.Clear();
                            textBoxSearch.Focus();
                            return;
                        }
                        Employee emp = new Employee();
                        emp = emp.SearchEmployee(Convert.ToInt32(textBoxSearch.Text.Trim()));
                        if (emp != null)
                        {
                            textBoxEmp.Text = emp.EmployeeId.ToString();
                            textBoxFN.Text = emp.FirstName;
                            textBoxLN.Text = emp.LastName;
                            textBoxJT.Text = emp.JobTitle;
                        }
                        else
                        {
                            textBoxSearch.Clear();
                            textBoxSearch.Focus();
                            string error = "Record not found !" + "\n" + "Please enter Employee Id again.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case 2:
                    case 3:
                    case 4:
                        if (!(Validator.IsValidName(textBoxSearch.Text.Trim())))
                        {
                            textBoxSearch.Clear();
                            textBoxSearch.Focus();
                            return;
                        }
                        Employee tempEmp = new Employee();
                        List<Employee> listTemp = tempEmp.SearchEmployee(textBoxSearch.Text.Trim());
                        listView1.Items.Clear();
                        if (listTemp != null)
                        {
                       
                            foreach (Employee anEmp in listTemp)
                            {

                                ListViewItem item = new ListViewItem(anEmp.EmployeeId.ToString());
                                item.SubItems.Add(anEmp.FirstName);
                                item.SubItems.Add(anEmp.LastName);
                                item.SubItems.Add(anEmp.JobTitle);
                                listView1.Items.Add(item);
                            }

                        }
                        else
                        {
                            textBoxSearch.Clear();
                            textBoxSearch.Focus();
                            string error = "Record not found !" + "\n" + "Please enter name again.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
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

        private void buttonExit_Click_1(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOption_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void comboBoxOption_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            int indexSelected = comboBoxOption.SelectedIndex;
            switch (indexSelected)
            {
                case 1:
                    labelMessage.Text = " enter Employee Id";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 2:
                    labelMessage.Text = " enter First Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 3:
                    labelMessage.Text = " enter Last Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 4:
                    labelMessage.Text = " enter Job Title";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;

                default:
                    labelMessage.Text = " select the search option";
                    break;

            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMessage_Click_1(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string input = "";
            User usr = new User();
            input = id.Text.Trim();
            if (!Validator.IsValidId(input, 4))
            {
                id.Clear();
                id.Focus();
                return;

            }

            int usrId = Convert.ToInt32(id.Text.Trim());
            if (!(usr.IsUniqueUserId(usrId)))
            {
                MessageBox.Show("This User ID already exists!", "Duplicate User ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id.Clear();
                id.Focus();
                return;
            }

            input = textBoxfirst.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxfirst.Clear();
                textBoxfirst.Focus();
                return;

            }

            input = textBoxlast.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxlast.Clear();
                textBoxlast.Focus();
                return;
            }

            input = textBoxjob.Text.Trim();
            if (!(Validator.IsValidName(input)))
            {
                textBoxjob.Clear();
                textBoxjob.Focus();
                return;
            }


            usr.UserId = Convert.ToInt32(id.Text.Trim());
            usr.FirstName = textBoxfirst.Text.Trim();
            usr.LastName = textBoxlast.Text.Trim();
            usr.JobTitle = textBoxjob.Text.Trim();
            usr.SaveUser(usr);
            MessageBox.Show("User record has been saved .", "User Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                User usr = new User();
                usr.UserId = Convert.ToInt32(id.Text.Trim());
                usr.FirstName = textBoxfirst.Text.Trim();
                usr.LastName = textBoxlast.Text.Trim();
                usr.JobTitle = textBoxjob.Text.Trim();

                usr.UpdateUser(usr);

                MessageBox.Show("User Record updated successfully!", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show(" enter some data!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void deleleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Do you really want to delete this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    User usr = new User();
                    usr.DeleteUser(Convert.ToInt32(id.Text));
                    MessageBox.Show("User Record has been deleted !", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" enter some data!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
          
            try
            {


                listView4.Items.Clear();
                int selectedIndex = cmbSearchUser.SelectedIndex;

                switch (selectedIndex)
                {

                    case 1:
                        if (!(Validator.IsValidId(txtSearchUser.Text.Trim())))
                        {

                            txtSearchUser.Clear();
                            txtSearchUser.Focus();
                            return;
                        }
                        User usr = new User();
                        usr = usr.SearchUser(Convert.ToInt32(txtSearchUser.Text.Trim()));
                        if (usr != null)
                        {
                            id.Text = usr.UserId.ToString();
                            textBoxfirst.Text = usr.FirstName;
                            textBoxlast.Text = usr.LastName;
                            textBoxjob.Text = usr.JobTitle;
                        }
                        else
                        {
                            txtSearchUser.Clear();
                            txtSearchUser.Focus();
                            string error = "Record not found !" + "\n" + "Please enter User Id again.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case 2:
                    case 3:
                        if (!(Validator.IsValidName(txtSearchUser.Text.Trim())))
                        {
                            txtSearchUser.Clear();
                            txtSearchUser.Focus();
                            return;
                        }
                        User tempEmp2 = new User();
                        List<User> listTemp2 = tempEmp2.SearchUser(txtSearchUser.Text.Trim());
                        listView1.Items.Clear();
                        if (listTemp2 != null)
                        {
                            foreach (User anUsr in listTemp2)
                            {
                                ListViewItem item = new ListViewItem(anUsr.UserId.ToString());
                                item.SubItems.Add(anUsr.FirstName);
                                item.SubItems.Add(anUsr.LastName);
                                item.SubItems.Add(anUsr.JobTitle);
                                listView4.Items.Add(item);
                            }

                        }
                        else
                        {

                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" enter some data!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ListUser_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            User usr = new User();
            List<User> listUsr = usr.GetUserList();
            if (listUsr != null)
            {
                foreach (User usrItem in listUsr)
                {
                    ListViewItem item = new ListViewItem(usrItem.UserId.ToString());
                    item.SubItems.Add(usrItem.FirstName);
                    item.SubItems.Add(usrItem.LastName);
                    item.SubItems.Add(usrItem.JobTitle);
                    listView4.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No User Data in the database.", "No User Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "you want to exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                ManagerForm managerform = new ManagerForm();
                managerform.ShowDialog();
            }
            else
            {
                return;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indexSelected = comboBoxOption.SelectedIndex;
            switch (indexSelected)
            {
                case 1:
                    labelMessage.Text = " enter User Id";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 2:
                    labelMessage.Text = " enter First Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                case 3:
                    labelMessage.Text = " enter Last Name";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                default:
                    labelMessage.Text = " select the search option";
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

