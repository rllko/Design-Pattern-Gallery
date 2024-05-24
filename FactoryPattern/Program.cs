using FactoryPattern.Factories;
using FactoryPattern.Models;


//the factory method pattern is a creational pattern that uses factory methods to deal with the
//problem of creating objects without having to specify their exact class.
//Rather than by calling a constructor, this is done by calling a factory method to create an object.

MenuItem item = ItemFactory.createItem(
    name:"Hamburger",
    price:2.99m,
    description: "just a burger",
    available:true,
    photoUrl:"url",
    singleItem:false,
    CustomizationsEnabled:false,
    categoryId:3,
    establishmentId:2,
    idItem: 0);

Console.WriteLine($"Type: {item.Type}\nName: {item.Name}\nPrice: {item.Price}\nAvailable: {item.Available}");