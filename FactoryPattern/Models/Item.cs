using System.ComponentModel.DataAnnotations;

namespace FactoryPattern.Models
{
    /// <summary>
    /// Item is the base interface to be implemented
    /// Defines the basic Attributes of a Item, has its type as a composition
    /// </summary>
    public abstract class Item
    {
        public ItemType Type { get; init; }
        protected Item(int itemId, bool customizationsEnabled, int establishmentId)
        {
            ItemId = itemId;
            CustomizationsEnabled = customizationsEnabled;
            EstablishmentId = establishmentId;
        }

        [Key]
        public int ItemId { get; set; }
        public bool ItemSolo { get; set; }
        public bool CustomizationsEnabled { get; set; }
        public int EstablishmentId { get; set; }

    }
}
