using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.Data
{
    public static class DataHelper
    {
        public static List<Address> GetDummyData()
        {
            var countries = new List<Country>
            {
              new Country { Id = 1, Name = "USA", Stats = new PopulationStats { CitizensCount = 100 } },
                new Country { Id = 2, Name = "Germany", Stats = new PopulationStats { CitizensCount = 200 } },
                new Country { Id = 3, Name = "Sweden", Stats = new PopulationStats { CitizensCount = 300 } },
                new Country { Id = 4, Name = "Poland", Stats = new PopulationStats { CitizensCount = 400 } }
            };

            var persons = new List<Person>
            {
                new Person { Id = 1, Firstname = "FirstnamePerson1", Lastname = "LastnamePerson1" },
                new Person { Id = 2, Firstname = "FirstnamePerson2", Lastname = "LastnamePerson2" },
                new Person { Id = 3, Firstname = "FirstnamePerson3", Lastname = "LastnamePerson3" },
                new Person { Id = 4, Firstname = "FirstnamePerson4", Lastname = "LastnamePerson4" },
                new Person { Id = 5, Firstname = "FirstnamePerson5", Lastname = "LastnamePerson5" },
                new Person { Id = 6, Firstname = "FirstnamePerson6", Lastname = "LastnamePerson6" },
                new Person { Id = 7, Firstname = "FirstnamePerson7", Lastname = "LastnamePerson7" },
                new Person { Id = 8, Firstname = "FirstnamePerson8", Lastname = "LastnamePerson8" }
            };

            return new List<Address>
            {
                new Address { Number = 1, Name = "Address1" , Country = countries[0], Persons = new List<Person> { persons[0], persons[1] } },
                new Address { Number = 2, Name = "Address2" , Country = countries[1], Persons = new List<Person> { persons[2], persons[3] } },
                new Address { Number = 3, Name = "Address3" , Country = countries[2], Persons = new List<Person> { persons[4], persons[5] } },
                new Address { Number = 4, Name = "Address4" , Country = countries[3], Persons = new List<Person> { persons[6], persons[7] } }
            };
        }
    }
}
