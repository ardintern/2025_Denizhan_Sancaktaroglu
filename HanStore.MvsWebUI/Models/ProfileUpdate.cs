using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Models
{
    public class ProfileUpdate
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ReNewPassword { get; set; }
        public bool IsAdmin { get; set; }
    }
}