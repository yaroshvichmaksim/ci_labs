using Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
    class Customer
    {
        public string surname { get; set; }

        public string lastname { get; set; }
        public string name { get; set; }
        public string passport { get; set; }
        public string bthday { get; set; }

        public string gender { get; set; }
        public string numberPhone { get; set; }

        public Customer()
        {
            surname = GetCustomer("Surname");
            name = GetCustomer("Name");
            passport = GetCustomer("PassportNum");
            lastname = GetCustomer("LastName");
            bthday = GetCustomer("Birthday");
            gender = GetCustomer("Gender");
            numberPhone = GetCustomer("NumberOfPhone");
        }

        string GetCustomer(string key)
        {
<<<<<<< HEAD
            return CustomerInfoReader.GetData(key);
=======
            return CustomerInfoReader.GetData(key).Value;
>>>>>>> 897c223367cf0778ac7ea5d135c80743374718b9
        }

    }
}
