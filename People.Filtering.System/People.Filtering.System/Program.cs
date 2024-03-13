using System.Collections.Generic;
using People.Filtering.System.Models;
using People.Filtering.System.Services;

namespace People.Filtering.System
{
    class Program
    {
        static void Main(string[] args)//Data input ucun 
        {
            //Numune list 
            List<Person> people = new List<Person>
            {
                new Person { FirstName = "Kemale", LastName = "Vahidova", Address = "Goramboy", Salary = 1200 },
                new Person { FirstName = "Vasif", LastName = "Ehmedov", Address = "Nesimi", Salary = 800 },
                new Person { FirstName = "Neriman", LastName = "Agayev", Address = "Ecemi", Salary = 1500 },
                new Person { FirstName = "Aynur", LastName = "Hesenzade", Address = "28 May", Salary = 900 },
                new Person { FirstName = "Konul", LastName = "Hemidova", Address = "Lutfizade 54", Salary = 3000 },
                new Person { FirstName = "Naile", LastName = "Eliyeva", Address = "Ehmedli", Salary = 700 }
            };

            // Delegat
            PeopleProcessor.FilterDelegate filterDelegate = person => person.Salary > 1000;

            // Filter Metodu cagirib Consola 
            PeopleProcessor.FilterAndDisplay(people, filterDelegate);
        }
    }
}