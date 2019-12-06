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
    class EmployeeDB
    {
        public static void SaveRecord(Employee emp)
        {
          
            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Employee(EmployeeId,FirstName,LastName,JobTitle)" +
                                " VALUES (@EmployeeId,@FirstName,@LastName,@JobTitle)";

            cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
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
            cmd.CommandText = "SELECT * FROM Employee " +
                             " WHERE EmployeeId =" + tempId;
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            if (id != 0)
            {
                connDB.Close();
                return false;
            }
            connDB.Close();
            return true;
        }
        public static void UpdateRecord(Employee emp)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update Employee " +
                "SET FirstName = @FirstName," +
                " LastName = @LastName," +
                " JobTitle = @JobTitle " +
                " WHERE EmployeeId = @EmployeeId ";
            cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
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
            cmd.CommandText = "delete from Employee where EmployeeId=@EmployeeId";
            cmd.Parameters.AddWithValue("@EmployeeId", id);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }
        public static List<Employee> GetRecordList()
        {
            List<Employee> listEmp = new List<Employee>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", connDB);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
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
       
        public static List<Employee> SearchRecord(string input)
        {
            List<Employee> listEmp = new List<Employee>();
            List<Employee> listTemp = new List<Employee>();
            Employee emp = new Employee();
            listEmp = emp.GetEmployeeList();
            Employee emp2;
            if (listEmp != null)
            {
                foreach (Employee anEmp in listEmp)
                {
                    if ((input.ToUpper() == anEmp.FirstName.ToUpper()) || (input.ToUpper() == anEmp.LastName.ToUpper()))
                    {
                        emp2 = new Employee();
                        emp2.EmployeeId = Convert.ToInt32(anEmp.EmployeeId);
                        emp2.FirstName = anEmp.FirstName;
                        emp2.LastName = anEmp.LastName;
                        emp2.JobTitle = anEmp.JobTitle;
                        listTemp.Add(emp2);
                    }
                }

            }

            return listTemp;


        }
        public static Employee SearchRecord(int searchId)
        {
            Employee emp = new Employee();
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT * from Employee " +
                                "WHERE EmployeeId = @EmployeeId ";
            cmd.Parameters.AddWithValue("@EmployeeId", searchId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
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
