using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinetUser
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string PhoneNumber { get; set; }
        public int UserGroupId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
