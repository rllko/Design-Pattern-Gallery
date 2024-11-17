namespace RepositoryPattern.Model
{
    public class Person
    {
        public required int Id { get; init; }
        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nAge:{Age}\n";
        }
    }
}
