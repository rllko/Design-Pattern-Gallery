namespace RepositoryPattern
{
    internal class PersonRepository : IRepository<Person>, IPeopleRepository
    {
        private readonly List<Person> _people;

        public PersonRepository()
        {
            _people = [];
        }

        public void Add(Person person) => _people.Add(person);

        public Person? GetById(int id) => _people.FirstOrDefault(p => p.Id == id);

        IEnumerable<Person> IRepository<Person>.GetAll() => _people;

        public bool Find(Person obj) => _people.Contains(obj);

        public void AddRange(IEnumerable<Person> entities)
        {
            _people.AddRange(entities);
        }
        void IRepository<Person>.Remove(Person obj) => _people.Remove(obj);

        public Person GetYoungestPerson()
        {
            return _people.OrderByDescending(person => person.Age).First();
        }

        public IEnumerable<Person> GetTopYoungest(int limit)
        {
            return _people.OrderByDescending(person => person.Age).Take(limit);
        }
    }
}
