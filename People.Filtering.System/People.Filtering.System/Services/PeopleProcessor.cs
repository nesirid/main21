using People.Filtering.System.Models;
using System.Collections.Generic;


namespace People.Filtering.System.Services
{
    public static class PeopleProcessor
    {
        // Personlari Filter etmek ucun Delegat
        public delegate bool FilterDelegate(Person person);

        // Filter metodu Ve cansola cixarish
        public static void FilterAndDisplay(List<Person> people, FilterDelegate filterDelegate)
        {
            Console.WriteLine("Maashi 1000man cox olan:");
            foreach (var person in people)
            {
                if (filterDelegate(person))
                {
                    Console.WriteLine($"Adi: {person.FirstName}, Soyadi: {person.LastName}, Unvani: {person.Address}, Maasi: {person.Salary}");
                }
            }
        }
    }
}