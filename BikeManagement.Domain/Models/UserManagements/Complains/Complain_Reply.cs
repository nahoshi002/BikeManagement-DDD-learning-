using BikeManagement.Domain.Models.UserManagements.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.UserManagements.Complains
{
    public class Complain_Reply
    {
        private Complain_Reply()
        {
            
        }

        public int Complain_Reply_Id { get; private set; }
        public string Content { get; private set; } = string.Empty;
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }
        public int Complain_Id { get; private set; }
        public int Account_Id { get; private set; }
        public Complain Complain { get; private set; }
        public Account Account { get; private set; }

        //factory
        //Tạo mới câu trả lời
        public static Complain_Reply CreateReply(string content, int complain_Id, int account_Id)
        {
            return new Complain_Reply
            {
                Content = content,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow,
                Complain_Id = complain_Id,
                Account_Id = account_Id
            };
        }

        //public method
        //Chỉnh sửa reply
        public void UpdateReplyContent(string updateContent)
        {
            Content = updateContent;
            LastModified = DateTime.UtcNow;
        }
    }
}
