using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.Lab3Ex4_Validation
{
    class Person
    {
        private string Firstname;
        private string Lastname;

        public Person ()
        {

        }

        public Person(string Firstname, string Lastname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
        }

        public override string ToString()
        {
            return "\nИмя: " + Firstname + "\nФамилия: " + Lastname;
        }
    }
}
