using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HitechClass.DataAccess;
using HitechClass.Business;




namespace Hi_Tech_Order_Management_System.GUI
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
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

        private void Change_Click(object sender, EventArgs e)
        {

            if (UsId.Text == "")
            {
                Hintuser.Text = "Please enter user id";
            }
            else if (ePassword.Text == "")
            {
                hintpassword.Text = "Please enter existing password";
                    ;
            }
            else if (nPassword.Text == "")
            {
                hintnew.Text = "Please enter new password";
            }
            else if (confirm.Text == "")
            {
                hint.Text = "Please enter new password";
            }

            else if (nPassword.Text == confirm.Text)
            {
                try
                {
                    SqlConnection connDB = UtilityDB.ConnectDB();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connDB;
                    cmd.CommandText = "Select * from Login where UserId=@UserId and Password=@password";
                    cmd.Parameters.AddWithValue("@UserId", UsId.Text);
                    cmd.Parameters.AddWithValue("@password", ePassword.Text);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    connDB.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show select form
                    if (count == 1)
                    {

                        Login log = new Login();
                        log.UserId = Convert.ToInt32(UsId.Text.Trim());

                        log.Password = nPassword.Text.Trim();

                        log.UpdateLogin(log);

                        MessageBox.Show("Password updated successfully!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password Change Failed! Wrong Credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

               
            }
            else
            {
                hint.Text = "New Password and Confirm Password should be same";
            }
        }


        }
    }

