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

namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           
            Books bks = new Books();
          

            bks.ISBN = Convert.ToInt32(TextboxISBN.Text.Trim());
            bks.Title = textBoxtitle.Text.Trim();
            bks.UnitPrice = Convert.ToInt32(textBoxunit.Text.Trim());
            bks.YearPublished = Convert.ToInt32(textBoxyear.Text.Trim());
            bks.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
            bks.SaveBooks(bks);

        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                Books bks = new Books();
                bks.ISBN = Convert.ToInt32(TextboxISBN.Text.Trim());
                bks.Title = textBoxtitle.Text.Trim();
                bks.UnitPrice = Convert.ToInt32(textBoxunit.Text.Trim());
                bks.YearPublished = Convert.ToInt32(textBoxyear.Text.Trim());
                bks.QOH = Convert.ToInt32(textBoxQOH.Text.Trim());
                bks.UpdateBooks(bks);


                MessageBox.Show("User Record updated !", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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
                DialogResult answer = MessageBox.Show("Do you  want to delete this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Books bks = new Books();
                    bks.DeleteBook(Convert.ToInt32(TextboxISBN.Text));
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

        private void ListUser_Click(object sender, EventArgs e)
        {

            listView4.Items.Clear();
            Books bks = new Books();
            List<Books> listbook = bks.GetBookList();
            if (listbook != null)
            {
                foreach (Books bookItem in listbook)
                {
                    ListViewItem item = new ListViewItem(bookItem.ISBN.ToString());
                    item.SubItems.Add(bookItem.Title);
                    item.SubItems.Add(bookItem.UnitPrice.ToString());
                    item.SubItems.Add(bookItem.YearPublished.ToString());
                    item.SubItems.Add(bookItem.QOH.ToString());
                    listView4.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No User Data in the database.", "No User Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try

            {
                int selectedIndex = comboBox1.SelectedIndex;

                switch (selectedIndex)
                {
                    case 1:
                      
                        Books bks = new Books();
                        bks = bks.SearchBook(Convert.ToInt32(textBoxSearch.Text.Trim()));
                        if (bks != null)
                        {
                            TextboxISBN.Text = bks.ISBN.ToString();
                            textBoxtitle.Text = bks.Title;
                            textBoxunit.Text = bks.UnitPrice.ToString();
                            textBoxyear.Text = bks.YearPublished.ToString();
                            textBoxQOH.Text = bks.QOH.ToString();
                        }
                        else
                        {
                            textBoxSearch.Clear();
                            textBoxSearch.Focus();
                            string error = "Record not found !" + "\n" + " enter ISBN Id again.";
                            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    case 2:
                        Books tempbook = new Books();
                        List<Books> listTemp = tempbook.SearchBook(textBoxSearch.Text.Trim());
                        listView4.Items.Clear();
                        if (listTemp != null)
                        {
                           
                       
                            foreach (Books bookItem in listTemp)
                            {
                               
                            
                                ListViewItem item = new ListViewItem(bookItem.ISBN.ToString());

                                item.SubItems.Add(bookItem.Title);
                                item.SubItems.Add(bookItem.UnitPrice.ToString());
                                item.SubItems.Add(bookItem.YearPublished.ToString());
                                item.SubItems.Add(bookItem.QOH.ToString());
                                listView4.Items.Add(item);
                            }

                        }
                        else
                        {
                            textBoxSearch.Clear();
                            textBoxSearch.Focus();
                            string error = "Record not found !" + "\n" + " enter Title again.";
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
                MessageBox.Show("Data is empty or not in correct format", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indexSelected = comboBox1.SelectedIndex;
            switch (indexSelected)
            {
                case 1:
                    LabelMessage.Text = "Please enter Title";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;
                 
                case 0:
                    LabelMessage.Text = "Please enter ISBN code";
                    textBoxSearch.Clear();
                    textBoxSearch.Focus();
                    break;

                default:
                    LabelMessage.Text = "Please select the search option";
                    break;

            }
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
    }
}
