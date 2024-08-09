namespace RepositoryPattern.Model
{
    public class Person
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nAge:{Age}\n";
        }
    }


}
