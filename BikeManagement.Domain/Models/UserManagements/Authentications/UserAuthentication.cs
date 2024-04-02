using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.UserManagements.Authentications
{
    public class UserAuthentication
    {

        private UserAuthentication()
        {
            
        }
        public int UserAuthentication_Id { get; private set; }
        public string? Card_Id { get; private set; }
        public DateTime? IssueDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string? FrontOfCard { get; private set; }
        public string? BackOfCard { get; private set; }
        public int? User_Id { get; private set; }

        public static UserAuthentication CreateAuthenticationInfo(string card_Id, DateTime issueDate, DateTime expityDate, string frontOfCard, string backOfCard, int user_Id)
        {
            return new UserAuthentication
            {
                Card_Id = card_Id,
                IssueDate = issueDate,
                ExpiryDate = expityDate,
                FrontOfCard = frontOfCard,
                BackOfCard = backOfCard,
                User_Id = user_Id
            };
        }
    }
}
