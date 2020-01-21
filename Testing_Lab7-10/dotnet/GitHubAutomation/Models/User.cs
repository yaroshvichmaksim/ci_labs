using Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
    class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User()
        {
            Login = GetUser("Login");
            Password = GetUser("Password");
        }
        string GetUser(string key)
        {
<<<<<<< HEAD
            return TestDataReader.GetData(key);
=======
            return TestDataReader.GetData(key).Value;
>>>>>>> 897c223367cf0778ac7ea5d135c80743374718b9
        }

    }
}
