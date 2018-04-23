using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1 {
    public class Country {
        public int Id { get; set; }
        public string Name { get; set; }
        public PopulationStats Stats { get; set; }
    }

    public class Person {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }


    public class Address {
        public int Number { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public List<Person> Persons { get; set; }

    }

    public class PopulationStats {
        public int Id { get; set; }
        public int CitizensCount { get; set; }
    }
}
