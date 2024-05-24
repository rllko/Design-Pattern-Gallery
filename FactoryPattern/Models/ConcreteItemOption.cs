namespace FactoryPattern.Models
{
    internal class ConcreteSimpleItemOption : ItemOption
    {
        public ConcreteSimpleItemOption(string name, int maxQuantity, double price, int itemId) : base(name, maxQuantity, price, itemId)
        {
        }
    }
}
