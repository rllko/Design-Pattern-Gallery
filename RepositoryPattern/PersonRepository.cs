using RepositoryPattern.Model;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPattern
{
    public class PersonRepository : IRepository<Person>, IPeopleRepository
    {
        private readonly ORM dbContext;

        public PersonRepository()
        {
            dbContext = new ORM();
        }

        public void Add(Person person)
        {
            dbContext.People.Add(new Person()
            {
                Name = person.Name,
                Age = person.Age,
                Id = dbContext.People.Count > 0 ? dbContext.People.Last().Id + 1 : 1,
            });
        }

        public Person? GetById(int id) => dbContext.People.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Person> GetAll() => dbContext.People;

        public void AddRange(IEnumerable<Person> entities) => entities.ToList().ForEach(person => Add(person));

        public void Remove(Person obj) => dbContext.People.Remove(obj);

        public Person? GetYoungestPerson()
        {
            var peopleQuery = dbContext.People.AsQueryable();

            if(peopleQuery == null)
            {
                return null;
            }

            return peopleQuery.MinBy(person => person.Age);
        }

        public IEnumerable<Person> GetTopYoungest(int limit)
        {
            return dbContext.People.OrderBy(person => person.Age).Take(limit);
        }

        IEnumerable<Person> IRepository<Person>.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
