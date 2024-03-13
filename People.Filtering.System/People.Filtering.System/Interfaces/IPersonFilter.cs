using System.Collections.Generic;
using People.Filtering.System.Models;
 

namespace People.Filtering.System.Interfaces
{
    public interface IPersonFilter
    {
        List<Person> FilterPeople(List<Person> people);
    }
}
