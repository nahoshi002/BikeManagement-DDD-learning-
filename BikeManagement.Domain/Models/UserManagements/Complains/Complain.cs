using BikeManagement.Domain.Models.UserManagements.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.UserManagements.Complains
{
    public class Complain
    {
        private readonly List<Complain_Reply> _replys = new List<Complain_Reply>();
        private Complain()
        {
        }

        public int Complain_Id { get; private set; }
        public string Content { get; private set; } = string.Empty;
        public string? Image { get; private set; } =string.Empty;
        public DateTime CreatedDate { get; private set; }
        public int Account_Id { get; private set; }
        public Account ComplainSender { get; private set; }
        public IEnumerable<Complain_Reply> Replys { get { return _replys; } }


        //Factory method:
        //Tạo mới đơn khiếu nại
        public static Complain CreateComplain(string content, string image, int account_Id)
        {
            return new Complain
            {
                Content = content,
                Image = image,
                CreatedDate = DateTime.UtcNow,
                Account_Id = account_Id
            };
        }

        //public method
        //Thêm mới reply
        public void AddeReply(Complain_Reply newReply)
        {
            _replys.Add(newReply);
        }
        //Xóa bỏ reply
        public void RemoveReply (Complain_Reply removeReply)
        {
            _replys.Remove(removeReply);
        }
    }
}
