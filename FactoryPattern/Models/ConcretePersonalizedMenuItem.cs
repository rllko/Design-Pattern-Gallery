namespace FactoryPattern.Models
{
    /// <summary>
    /// Single item but can have multiple ingredients.
    /// </summary>
    public class ConcretePersonalizedMenuItem : MenuItem, IPersonalizationsActive
    {
        List<ItemOption> ItemOptions;

        public ConcretePersonalizedMenuItem(
            List<ItemOption> itemOptions, string name,
            decimal price, string? description,
            bool available, string? photo,
            bool customizationsActive,
            int categoryId, int establishmentId, int itemId = 0) : base(itemId, name, price, description, available, photo, customizationsActive, categoryId, establishmentId)
        {
            Type = ItemType.SingleItemPersonalized;
            ItemOptions = itemOptions;
        }

        public decimal getPriceOfExtras()
        {
            decimal cost = Price;
            foreach(decimal optionPrice in ItemOptions.Select(option => option.Price).ToList())
            {
                cost += Price;
            }
            return cost;
        }
    }
}
