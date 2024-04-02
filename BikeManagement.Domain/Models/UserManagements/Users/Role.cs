using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.UserManagements.Users
{
    public class Role
    {
        public int Role_Id { get; set; }

        public string RoleName
        {
            get
            {
                switch (Role_Id)
                {
                    case 0:
                        return "Admin";
                    case 1:
                        return "Khách hàng";
                    default:
                        return "";
                }
            }
        }
        public IEnumerable<Account> Accounts { get; private set; }

    }
}
