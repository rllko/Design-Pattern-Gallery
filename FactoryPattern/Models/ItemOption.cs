namespace FactoryPattern.Models
{
    /// <summary>
    /// Item Extra, used to 
    /// </summary>
    public abstract class ItemOption
    {
        public string Name { get; set; }
        public int MaxQuantity { get; set; }
        public double Price { get; set; }
        public int ItemId { get; set; }
        public ItemOption(string name, int maxQuantity, double price, int itemId)
        {
            Name = name;
            MaxQuantity = maxQuantity;
            Price = price;
            ItemId = itemId;
        }
    }
}
