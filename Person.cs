using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagQuiz
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        //doesn't account for all ages needs work
        public int CaluculateAge(DateTime birthday)
        {
            int age;
            DateTime today = DateTime.Today;

            if (today.Month > birthday.Month)
            {
                age = today.Year - birthday.Year;
            }
            else
            {
                age = today.Year - birthday.Year - 1;
            }
            return age;
        }

        //need method to display object properties
        public string DisplayObjProp()
        {
            return FirstName + " " + LastName + " " + Birthday; 
        }
    }
}
