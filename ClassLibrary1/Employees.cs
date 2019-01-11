using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Customer : Shop //Overloaded Constructor. 
    {
        public string FullName
        {
            get
            {
                return GetFullName();
            }
        }
        public Customer(string firstName, string lastName)
        : base(firstName, lastName)
        {
        }

    }

    public class Employees : Shop // Inheritance so that it´s less code. DRY.
    {
        

        public Employees employee1 = new Employees()
        {
            Name = "Göran",
            LastName = "Sahlberg",
            Age = 36

        };

        public Employees employee2 = new Employees()
        {
            Name = "Greta",
            LastName = "Hansson",
            Age = 23
        };

        public Employees employee3 = new Employees()
        {
            Name = "Maria",
            LastName = "Gren",
            Age = 44
        };

    }

}
