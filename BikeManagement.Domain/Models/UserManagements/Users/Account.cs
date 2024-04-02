using BikeManagement.Domain.Models.Notifications;
using BikeManagement.Domain.Models.StatusManagements;
using BikeManagement.Domain.Models.UserManagements.Complains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.UserManagements.Users
{
    public class Account
    {
        private Account()
        {
            
        }

        public int Account_Id { get; private set; }
        public string UserName { get; private set; } = string.Empty;
        public string Password { get; private set; } = string.Empty;
        public User User { get; private set; }
        public DateTime LastAccess { get; private set; }
        public int Role_Id { get; private set; }
        public int Status_Id { get; private set; }
        public Status Status { get; set; } // Thêm trường Status để tham chiếu đến Status liên quan
        public Role Role { get; set; } // Thêm trường Role để tham chiếu đến Role liên quan
        public IEnumerable<Complain> ReceiverComplains { get; private set; }

        public IEnumerable<Complain_Reply> Replys { get; private set; }

        // Danh sách các Account đã nhận notification từ Account này
        public IEnumerable<Notification> ReceivedNotifications { get; set; }


        //Factory method
        public static Account CreateAccountInfo(string userName, string password, User user, int role_Id, int status_Id)
        {
            //TODO: implement validation, error handling stratgies, error notification stratgies
            return new Account
            {
                UserName = userName,
                Password = password,
                User = user,
                LastAccess = DateTime.UtcNow,
                Role_Id = role_Id,
                Status_Id = status_Id
            };
        }

        //Public method
        public void UpdateUserInfo(User newinfo)
        {
            User = newinfo;
        }
    }
}
