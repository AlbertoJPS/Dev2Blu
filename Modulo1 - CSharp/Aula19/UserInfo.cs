using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19
{
    internal class UserInfo
    {
        public static List<UserInfo> _AllUsers { get; set; } = new List<UserInfo>()
        {
            new UserInfo()
            {
                Name = "Arthur",
                Email = "Arth@Excalibur.com",
                User = "arthur",
                Password = "espadinha"
            }
        };
        public string Name { get; set; }
        public string Email { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        
    }
}
