using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using HitechClass.Business;
using HitechClass.DataAccess;
using HitechClass.Validation;
using System.Text.RegularExpressions;

namespace HitechClass.Business
{

    public class Login
    {
        private int userId;
        private string password;
        private int loginId;

        public int UserId { get => userId; set => userId = value; }
        public string Password { get => password; set => password = value;
        }
        public int LoginId { get => loginId; set => loginId = value; }

        public void UpdateLogin(Login log)
        {
            LoginDB.UpdateRecord(log);
        }

    }
    public class Books
    {
        private int iSBN;
        private string title;
        private int unitPrice;
        private int yearPublished;
        private int qOH;
        private int authorID;

        public int ISBN { get => iSBN; set => iSBN = value; }
        public string Title { get => title; set => title = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }
        public int QOH { get => qOH; set => qOH = value; }
        public int AuthorID { get => authorID; set => authorID = value; }
        public void SaveBooks(Books bks)
        {
            BooksDB.SaveRecord(bks);
        }
        public void UpdateBooks(Books bks)
        {
            BooksDB.UpdateRecord(bks);
        }
        public void DeleteBook(int ISBN)
        {
            BooksDB.DeleteBook(ISBN);
        }
        public List<Books> GetBookList()
        {
            return (BooksDB.GetBookList());
        }
        public Books SearchBook(int id)
        {
            return (BooksDB.SearchBook(id));
        }
        public List<Books> SearchBook(string input)
        {
            return (BooksDB.SearchBook(input));
        }
    }
    public class Customer
    {
        private string phoneNumber;
        private string name;
        private string street;
        private string city;
        private string postalCode;
        private int creditLimit;
        private string faxNumber;
        private int customerId;


        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public int CreditLimit { get => creditLimit; set => creditLimit = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }

        public List<Customer> ListCustomer()
        {
            return (CustomerDb.ListRecord());
        }
        public bool IsUniqueId(int tempId)
        {
            return (CustomerDb.IsUniqueId(tempId));
        }
    }
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public void SaveEmployee(Employee emp)
        {
            EmployeeDB.SaveRecord(emp);
        }

        public bool IsUniqueEmployeeId(int tempId)
        {
            return (EmployeeDB.IsUniqueId(tempId));
        }
        public void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateRecord(emp);
        }
        public void DeleteEmployee(int empId)
        {
            EmployeeDB.DeleteRecord(empId);
        }
        public List<Employee> GetEmployeeList()
        {
            return (EmployeeDB.GetRecordList());
        }
        public Employee SearchEmployee(int id)
        {
            return (EmployeeDB.SearchRecord(id));
        }
        public List<Employee> SearchEmployee(string input)
        {
            return (EmployeeDB.SearchRecord(input));
        }
    }

    public class User
    {
        private int userId;
        private string firstName;
        private string lastName;
        private string jobTitle;

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        public void SaveUser(User usr)
        {
            UserDb.SaveRecord(usr);
        }

        public bool IsUniqueUserId(int tempId)
        {
            return (UserDb.IsUniqueId(tempId));
        }
        public void UpdateUser(User usr)
        {
            UserDb.UpdateRecord(usr);
        }
        public void DeleteUser(int userId)
        {
            UserDb.DeleteRecord(userId);
        }
        public List<User> GetUserList()
        {
            return (UserDb.GetRecordList());
        }
        public User SearchUser(int id)
        {
            return (UserDb.SearchRecord(id));
        }
        public List<User> SearchUser(string input)
        {
            return (UserDb.SearchRecord(input));
        }
    }



}


namespace HitechClass.DataAccess
{
    public class EmployeeDB
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
                    System.Console.WriteLine(anEmp);
                    // if (anEmp.FirstName.ToUpper() == input.ToUpper())
                    if ((input.ToUpper().Trim() == anEmp.FirstName.ToUpper().Trim()) || (input.ToUpper() == anEmp.LastName.ToUpper().Trim()) || (input.ToUpper() == anEmp.JobTitle.ToUpper().Trim()))
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

    public class CustomerDb
    {


        public static List<Customer> ListRecord()
        {

            List<Customer> listS = new List<Customer>();
            Customer aCustomer;
            SqlConnection connDb = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", connDb);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {



                    aCustomer = new Customer();
                    aCustomer.Name = reader["Name"].ToString();
                    aCustomer.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                    aCustomer.City = reader["City"].ToString();
                    aCustomer.PostalCode = reader["PostalCode"].ToString();

                    aCustomer.PhoneNumber = reader["PhoneNumber"].ToString();

                    aCustomer.CreditLimit = Convert.ToInt32(reader["CreditLimit"]);
                    aCustomer.FaxNumber = reader["FaxNumber"].ToString();
                    aCustomer.Street = reader["Street"].ToString();
                    listS.Add(aCustomer);
                }

            }
            else
            {

                listS = null;
            }
            connDb.Close();
            return listS;
        }
        public static bool IsUniqueId(int tempId)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "SELECT * FROM [Customers]" +
                             " WHERE [CustomerId] =" + tempId;
            SqlDataReader reader = cmd.ExecuteReader();
          
            if (reader.HasRows)
            {
                connDB.Close();
                return false;
            }
           
                connDB.Close();
                return true;
            }

       
        }

    }

    public class BooksDB
    {
        public static void SaveRecord(Books bks)

        {

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO Books(ISBN,Title,UnitPrice,YearPublished,QOH)" +
                                " VALUES (@ISBN,@Title,@UnitPrice,@YearPublished,@QOH)";

            cmd.Parameters.AddWithValue("@ISBN", bks.ISBN);
            cmd.Parameters.AddWithValue("@Title", bks.Title);
            cmd.Parameters.AddWithValue("@UnitPrice", bks.UnitPrice);
            cmd.Parameters.AddWithValue("@YearPublished", bks.YearPublished);
            cmd.Parameters.AddWithValue("@QOH", bks.QOH);
            cmd.ExecuteNonQuery();

            connDB.Close();
        }
        public static void UpdateRecord(Books bks)
        {
           
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
          
            cmd.CommandText = "Update [Books]" +
                "SET Title = @Title," +
                " UnitPrice = @UnitPrice," +
                " YearPublished = @YearPublished," +
                " QOH = @QOH" +
                " WHERE ISBN = @ISBN";
            cmd.Parameters.AddWithValue("@ISBN", bks.ISBN);
            cmd.Parameters.AddWithValue("@Title", bks.Title);
            cmd.Parameters.AddWithValue("@UnitPrice", bks.UnitPrice);
            cmd.Parameters.AddWithValue("@YearPublished", bks.YearPublished);
            cmd.Parameters.AddWithValue("@QOH", bks.QOH);
            cmd.ExecuteNonQuery();
            connDB.Close();



        }
        public static void DeleteBook(int bks)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "delete from [Books] where ISBN=@ISBN";


            cmd.Parameters.AddWithValue("@ISBN", bks);
            cmd.ExecuteNonQuery();
            connDB.Close();
        }
        public static List<Books> GetBookList()
        {
            List<Books> listbook = new List<Books>();
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Books ", connDB);
            SqlDataReader reader = cmd.ExecuteReader();
            Books bks;

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    bks = new Books();
                    bks.ISBN = Convert.ToInt32(reader["ISBN"]);
                    bks.Title = reader["Title"].ToString();
                    bks.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                    bks.YearPublished = Convert.ToInt32(reader["YearPublished"]);
                    bks.QOH = Convert.ToInt32(reader["QOH"]);

                    listbook.Add(bks);

                }
            }
            else
            {
                listbook = null;
            }

            return listbook;
        }
        public static List<Books> SearchBook(string input)
        {
            List<Books> listbook= new List<Books>();
            List<Books> listTemp = new List<Books>();
            Books bks = new Books();
            listbook = bks.GetBookList();
            Books bks2;
            if (listbook != null)
            {
            
                foreach (Books abook in listbook)
                {
               if (input.ToLower().Trim() == abook.Title.ToLower().Trim())
                    {
                   
                        bks2 = new Books();
                        bks2.ISBN= Convert.ToInt32(abook.ISBN);
                        bks2.Title = abook.Title;
                        bks2.UnitPrice = Convert.ToInt32(abook.UnitPrice);
                        bks2.YearPublished = Convert.ToInt32(abook.YearPublished);
                        bks2.QOH = Convert.ToInt32(abook.QOH);
                        listTemp.Add(bks2);
                    }
                }

            }

            return listTemp;


        }
        public static Books SearchBook(int id)
        {
            Books bks = new Books();
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT * from [Books] " +
                                "WHERE ISBN = @ISBN ";
            cmd.Parameters.AddWithValue("@ISBN", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               
                bks.ISBN = Convert.ToInt32(reader["ISBN"]);
                bks.Title = reader["Title"].ToString();
                bks.UnitPrice = Convert.ToInt32(reader["UnitPrice"]);
                bks.YearPublished = Convert.ToInt32(reader["YearPublished"]);
                bks.QOH = Convert.ToInt32(reader["QOH"]);

            }
            else
            {
                bks = null;
            }

            return bks;
        }

    }
   
    public class UserDb
    {
        public static void SaveRecord(User us)
        {

            SqlConnection connDB = UtilityDB.ConnectDB();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "INSERT INTO [User](UserId,FirstName,LastName,JobTitle)" +
                                " VALUES (@UserId,@FirstName,@LastName,@JobTitle)";

            cmd.Parameters.AddWithValue("@UserId", us.UserId);
            cmd.Parameters.AddWithValue("@FirstName", us.FirstName);
            cmd.Parameters.AddWithValue("@LastName", us.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", us.JobTitle);
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
        public static void UpdateRecord(User us)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update [User] " +
                "SET FirstName = @FirstName," +
                " LastName = @LastName," +
                " JobTitle = @JobTitle " +
                " WHERE UserId = @UserId ";

            cmd.Parameters.AddWithValue("@UserId", us.UserId);
            cmd.Parameters.AddWithValue("@FirstName", us.FirstName);
            cmd.Parameters.AddWithValue("@LastName", us.LastName);
            cmd.Parameters.AddWithValue("@JobTitle", us.JobTitle);
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
            List<User> listUs = new List<User>();
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
                    listUs.Add(emp);

                }
            }
            else
            {
                listUs = null;
            }

            return listUs;
        }

        public static List<User> SearchRecord(string input)
        {
            List<User> listUs = new List<User>();
            List<User> listTemp = new List<User>();
            User emp = new User();
            listUs = emp.GetUserList();
            User us2;
            if (listUs != null)
            {
                foreach (User anEmp in listUs)
                {
                    if ((input.ToUpper().Trim() == anEmp.FirstName.ToUpper().Trim()) || (input.ToUpper().Trim() == anEmp.LastName.ToUpper().Trim()))
                    {
                        us2 = new User();
                        us2.UserId = Convert.ToInt32(anEmp.UserId);
                        us2.FirstName = anEmp.FirstName;
                        us2.LastName = anEmp.LastName;
                        us2.JobTitle = anEmp.JobTitle;
                        listTemp.Add(us2);
                    }
                }

            }

            return listTemp;


        }
        public static User SearchRecord(int searchId)
        {


            User us = new User();
            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT * from [User] " +
                                "WHERE UserId = @UserId ";
            cmd.Parameters.AddWithValue("@UserId", searchId);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                us.UserId = Convert.ToInt32(reader["UserId"]);
                us.FirstName = reader["FirstName"].ToString();
                us.LastName = reader["LastName"].ToString();
                us.JobTitle = reader["JobTitle"].ToString();

            }
            else
            {
                us = null;
            }

            return us;
        }
    }

    public class LoginDB
    {
        
        public static void UpdateRecord(Login log)
        {
            SqlConnection connDB = UtilityDB.ConnectDB();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB;
            cmd.CommandText = "Update Login " +
                "SET Password = @Password" +
                " WHERE UserId = @UserId ";
            cmd.Parameters.AddWithValue("@UserId", log.UserId);
            cmd.Parameters.AddWithValue("@Password", log.Password);
            cmd.ExecuteNonQuery();
            connDB.Close();

        }
    }
    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = @"server=DESKTOP-NOC7ELQ; database=HitechDB;user=sa;password=qwerty";
            connDB.Open();
            return connDB;
        }
    }






namespace HitechClass.Validation 
{
    public static class Validator
    {
        public static bool IsValidId(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{4}$"))
            {
                MessageBox.Show(" Invalid ", "Invalid Input ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;



        }
        public static bool IsValidPhone(string input)
        {
            if (!Regex.IsMatch(input, @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"))
            {
                MessageBox.Show(" Invalid PhoneNumber", "Invalid Input try this format 000-0000-0000", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;

        }
        public static bool IsValidCity(string input)
        {
            if (!Regex.IsMatch(input, @"^[a-zA-Z]+(?:[\s-][a-zA-Z]+)*$"))
            {
                MessageBox.Show(" Invalid", "Invalid format ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;

        }
        public static bool IsValidFullName(string input)
        {
            if (!Regex.IsMatch(input, @"^([a-zA-Z0-9]+|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{1,}|[a-zA-Z0-9]+\s{1}[a-zA-Z0-9]{3,})$"))
            {
                MessageBox.Show(" Invalid Name", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;

        }
        public static bool IsValidPostal(string input)
        {
            if (!Regex.IsMatch(input, @"^([A-Za-z]\d[A-Za-z][-]?\d[A-Za-z]\d)"))
            {
                MessageBox.Show(" Invalid Postal Code Try this format h3h-3b3 or H3H2B7", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            return true;

        }



        public static bool IsValidId(string input, int length)
        {
            if (!Regex.IsMatch(input, @"^\d{" + length + "}$"))
            {
                string error = "ID must be " + length + "-digit number.";
                MessageBox.Show(error, "Invalid Input for id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        public static bool IsValidName(string input)
        {
            string error = "First name must contain only letters or space(s)";
            if (input.Length == 0)
            {

                MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            for (int i = 0; i < input.Length; i++)
            {
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {
                    MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

    }
}
