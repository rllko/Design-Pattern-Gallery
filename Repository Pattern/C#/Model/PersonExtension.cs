namespace RepositoryPattern.Model;

public static class PersonExtension
{
    public static Person ToDto(this Person person)
    {
        var personDTO = new Person()
        {
            Name = person.Name,
            Age = person.Age,
            Id = person.Id
        };

        return personDTO;
    }
}