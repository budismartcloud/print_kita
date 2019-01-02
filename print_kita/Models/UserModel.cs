using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace print_kita.Models
{
    public class UserModel
    {
        public string userId { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public string roleId { get; set; }
    }
}