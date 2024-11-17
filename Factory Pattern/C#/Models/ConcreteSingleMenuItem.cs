namespace FactoryPattern.Models
{
    /// <summary>
    /// Represents a single item thtat doesnt have any personalization
    /// </summary>
    public class ConcreteSingleMenuItem : MenuItem
    {
        public ConcreteSingleMenuItem(int itemId, string name, decimal price, string? description, bool available, string? photoUrl, bool customizationsEnabled, int categoryId, int establishmentId) : base(itemId, name, price, description, available, photoUrl, customizationsEnabled, categoryId, establishmentId)
        {
            Type = ItemType.SingleItem;
        }
    }
}
