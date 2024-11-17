using RepositoryPattern.Model;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern
{
    internal class ORM
    {
        public List<Person> People;

        public ORM()
        {
            People = [
                new() { Name = "Joe", Age = 10, Id = 1},
                new() { Name = "Mike", Age = 15, Id = 2 },
                new() { Name = "John", Age = 18, Id = 3 },
                new() { Name = "Monique", Age = 12, Id = 4 },
                new() { Name = "Pedro", Age = 20, Id = 5 }
            ];
        }

        public IQueryable GetPeopleAsQueryable()
        {
            return People.AsQueryable();
        }

        public IEnumerable<Person> GetPeopleAsEnumerable()
        {
            return People.AsEnumerable();
        }
    }
}
