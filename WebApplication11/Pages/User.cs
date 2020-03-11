using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Pages
{
    public class User
    {
        public string Login { get; set; }
        public string Pass { get; set; }
        public User(string Login, string Pass)
        {
            this.Login = Login;
            this.Pass = Pass;
        }
    }
}
