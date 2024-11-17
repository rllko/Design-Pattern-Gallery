namespace FactoryPattern.Models
{
    internal interface IBundle
    {
        List<MenuItem> Items { get; init; }
        List<MenuItem> getItems();
    }
}
