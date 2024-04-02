using BikeManagement.Domain.Models.UserManagements.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.UserManagements.Users
{
    public class User
    {
        private User()
        {
            
        }

        public int User_Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public string Phone { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;
        public DateTime? DateOfBirth { get; private set; }
        public UserAuthentication? AuthenticationInfo { get; private set; }

        //factory
        //Thêm thông tin người dùng
        public static User AddUserInfo(string fullName, string phone, string email, string address, DateTime dateOfBirth)
        {
            //TODO: implement validation, error handling stratgies, error notification stratgies

            return new User()
            {
                FullName = fullName,
                Phone = phone,
                Email = email,
                Address = address,
                DateOfBirth = dateOfBirth
            };
        }

        //public
        //Cập nhật thông tin xác thực người dùng
        public void UpdateAuthenticationInfo(UserAuthentication authenticationInfo)
        {
            AuthenticationInfo = authenticationInfo;
        }
    }
}
