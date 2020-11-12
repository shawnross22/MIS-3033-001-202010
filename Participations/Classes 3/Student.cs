using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            FirstName = "";
            LastName = "";
            Major = "";
            GPA = 0;
        }

        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
        }

        public string CalculateDistinction()
        {
            string distinction = "";
            if (GPA >= 3.8)
            {
                distinction = "summa cum laude";
            }
            else if (GPA >= 3.6)
            {
                distinction = "magna cum laude";
            }
            else if (GPA >= 3.4)
            {
                distinction = "cum laude";
            }

            return distinction;
        }

        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipcode)
        {
            Address address = new Address();
            address.StreetNumber = streetNumber;
            address.StreetName = streetName;
            address.State = state;
            address.City = city;
            address.Zipcode = zipcode;

            Address = address;
        }

        public string ToString()
        {
            string importantInformation = $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
            return importantInformation;
        }
    }
}
