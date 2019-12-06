using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DataAccess;
using Hi_Tech_Order_Management_System.Business;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hi_Tech_Order_Management_System.DataAccess
{
    class UserDb
    {
        public static void SaveRecord(User emp)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO [User](UserId,FirstName,LastName,JobTitle)" +
                                " VALUES (@UserId,@FirstName,@LastName,@JobTitle)";

            cmd.Parameters.AddWithValue("@UserId", emp.UserId);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmd.ExecuteNonQuery();

            connDB.Close();
        }
        public static bool IsUniqueId(int tempId)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM [User] " +
                             " WHERE UserId =" + tempId;
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id != 0)
            {
                connDB.Close();
                return false;
            }
            connDB.Close();
            return true;
        }
        public static void UpdateRecord(User emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update [User] " +
                "SET FirstName = @FirstName," +
                " LastName = @LastName," +
                " JobTitle = @JobTitle " +
                " WHERE UserId = @UserId ";
            cmd.Parameters.AddWithValue("@UserId", emp.UserId);
            cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
            cmd.Parameters.AddWithValue("@LastName", emp.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
            cmd.ExecuteNonQuery();
            connDB.Close();

        }
        public static void DeleteRecord(int id)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "delete from [User] where UserId=@UserId";
            cmd.Parameters.AddWithValue("@UserId", id);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }
        public static List<User> GetRecordList()
        {
            List<User> listEmp = new List<User>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] ", connDB);
            SqlDataReader reader = cmd.ExecuteReader();
            User emp;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emp = new User();
                    emp.UserId = Convert.ToInt32(reader["UserId"]);
                    emp.FirstName = reader["FirstName"].ToString();
                    emp.LastName = reader["LastName"].ToString();
                    emp.JobTitle = reader["JobTitle"].ToString();
                    listEmp.Add(emp);

                }
            }
            else
            {
                listEmp = null;
            }

            return listEmp;
        }

        public static List<User> SearchRecord(string input)
        {
            List<User> listEmp = new List<User>();
            List<User> listTemp = new List<User>();
            User emp = new User();
            listEmp = emp.GetUserList();
            User emp2;
            if (listEmp != null)
            {
                foreach (User anEmp in listEmp)
                {
                    if ((input.ToUpper() == anEmp.FirstName.ToUpper()) || (input.ToUpper() == anEmp.LastName.ToUpper()))
                    {
                        emp2 = new User();
                        emp2.UserId = Convert.ToInt32(anEmp.UserId);
                        emp2.FirstName = anEmp.FirstName;
                        emp2.LastName = anEmp.LastName;
                        emp2.JobTitle = anEmp.JobTitle;
                        listTemp.Add(emp2);
                    }
                }

            }

            return listTemp;


        }
        public static User SearchRecord(int searchId)
        {
           

            User emp = new User();
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT * from [User] " +
                                "WHERE UserId = @UserId ";
            cmd.Parameters.AddWithValue("@UserId", searchId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                emp.UserId = Convert.ToInt32(reader["UserId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();

            }
            else
            {
                emp = null;
            }

            return emp;
        }
    }
}


