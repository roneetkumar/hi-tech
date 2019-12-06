using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DataAccess;

namespace Hi_Tech_Order_Management_System.Business
{
    class Employee
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

        internal bool IsUniqueEmployeeId(int tempId)
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
}
