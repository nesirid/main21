using System;
using System.Collections.Generic;

namespace People.Filtering.System.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Salary { get; internal set; }
    }
}
