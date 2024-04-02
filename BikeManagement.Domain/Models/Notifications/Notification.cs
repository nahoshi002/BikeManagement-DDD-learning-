using BikeManagement.Domain.Models.UserManagements.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.Notifications
{
    public class Notification
    {
        private Notification()
        {
            
        }
        public int Notification_Id { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string Image { get; private set; } = string.Empty;
        public string Content { get; private set; } = string.Empty;
        public int Sender_Id { get; private set; }

        public Account AccountSender { get; private set; }


        //factory
        //Tạo thông báo mới
        public static Notification CreateNotification(string title, string image, string content, int sender_Id)
        {
            //TODO: implement validation, error handling stratgies, error notification stratgies
            return new Notification()
            {
                Title = title,
                Image = image,
                Content = content,
                Sender_Id = sender_Id,
            };
        }
    }
}
