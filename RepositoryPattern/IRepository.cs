namespace RepositoryPattern
{
    internal interface IRepository<T> where T : class
    {
        public void Add(T obj);
        public void AddRange(IEnumerable<T> entities);
        public void Remove(T obj);
        // Using Ids to keep things simple
        public T? GetById(int id);
        public IEnumerable<T> GetAll();
        public bool Find(T obj);
        //Repositories should not have save update or save
        //as it shouldnt be related to the database structure
    }
}
