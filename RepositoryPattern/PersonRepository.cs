using RepositoryPattern.Model;

namespace RepositoryPattern
{
    public class PersonRepository : IRepository<Person>, IPeopleRepository
    {
        private readonly List<Person> _people;

        public PersonRepository()
        {
            _people = [];
        }

        public void Add(Person person)
        {
            _people.Add(new Person()
            {
                Name = person.Name,
                Age = person.Age,
                Id = _people.Count() > 0 ? _people.Last().Id + 1 : 1,
            });
        }

        public Person? GetById(int id) => _people.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Person> GetAll() => _people;

        public void AddRange(IEnumerable<Person> entities) => entities.ToList().ForEach(person => Add(person));

        public void Remove(Person obj) => _people.Remove(obj);

        public Person GetYoungestPerson()
        {
            return _people.OrderBy(person => person.Age).First();
        }

        public IEnumerable<Person> GetTopYoungest(int limit)
        {
            return _people.OrderBy(person => person.Age).Take(limit);
        }
    }
}
