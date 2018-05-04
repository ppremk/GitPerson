using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNs
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
        }

        public Person(string firstname, string lastname)
        {
            _firstName = firstname;
            _lastName = lastname;
        }


        public string GetFullName(string firstName, string lastName)
        {
            return string.Concat(_firstName, _lastName);
        }
    }
}
