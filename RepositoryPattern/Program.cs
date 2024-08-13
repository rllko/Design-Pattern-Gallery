// This is a design pattern used often in web applications
// so i'm not so sure how well its gonna work in this made up scenario

// Advantage: minimizes duplicate query logic
// Decouples your application from persistence frameworks -> Entity Framework
using RepositoryPattern;
using System;
using System.Linq;

// The original idea envolved using DTOs but got removed to avoid complexity
var personRepository = new PersonRepository();

Console.WriteLine("List Of People\n");
personRepository.GetAll().ToList().ForEach(Console.WriteLine);

var youngestPerson =  personRepository.GetYoungestPerson();
Console.WriteLine("\nYoungest:\n");
Console.WriteLine(youngestPerson);

if(youngestPerson != null)
{
    personRepository.Remove(youngestPerson);
}

var Top5Youngest = personRepository.GetTopYoungest(5).ToList();
Console.WriteLine("\nTop 5 Youngest:\n");
Top5Youngest.ForEach(Console.WriteLine);


Console.WriteLine("\nPerson with Id 2:\n");
var Person2 = personRepository.GetById(2);
Console.WriteLine(Person2 is null ? "No one with id 2" : Person2);

