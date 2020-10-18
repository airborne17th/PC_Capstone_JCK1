using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassyChess1.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; } = 1;
        public bool Newsletter { get; set; } = false;
    }
}