using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_Tech_Order_Management_System.DataAccess;

namespace Hi_Tech_Order_Management_System.Business
{
    class User
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

        internal bool IsUniqueUserId(int tempId)
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
