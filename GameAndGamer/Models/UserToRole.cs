using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameAndGamer.Models
{
    public class UserToRole
    {
        public string Email { get; set; }
        public string SelectedRole { get; set; }
        public List<string> Rolls { get; set; }

        public UserToRole()
        {
            Rolls = new List<string>();
        }
    }
}