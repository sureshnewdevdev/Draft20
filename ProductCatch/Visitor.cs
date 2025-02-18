using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch
{
    public class Visitor : IProfile
    {
        public string GetPersonalInformation(string name, string address, string email, string phone)
        {
            return $"Name: {name}, Address: {address}, Email: {email}, Phone: {phone}";
        }
    }

    public class Customer : IProfile
    {
        public string GetPersonalInformation(string name, string address, string email, string phone)
        {
            return $"Name: {name}, Address: {address}, Email: {email}, Phone: {phone}";
        }
    }
}
