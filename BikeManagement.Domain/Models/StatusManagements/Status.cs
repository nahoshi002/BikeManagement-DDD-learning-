using BikeManagement.Domain.Models.UserManagements.Complains;
using BikeManagement.Domain.Models.UserManagements.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeManagement.Domain.Models.StatusManagements
{
    public class Status
    {
        public int Status_Id { get; set; }
        public string StatusName { get; set; } = string.Empty;

        public IEnumerable<Account> Accounts { get; private set; }

    }
}
