using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersMarkt.Data
{
    internal class User
    {
        public static User? CurrentUser { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }

        public double CreditBalance { get; set; }
    }
}
