using FactoryPattern.Models;

namespace FactoryPattern.Factories
{
    /// <summary>
    /// This is the factory, the core of the Creational pattern.
    /// </summary>
    internal class ItemFactory
    {
        public static MenuItem createItem(

            string name, decimal price,
            string? description, bool available,
            string? photoUrl, bool singleItem, bool CustomizationsEnabled,
            int categoryId, int establishmentId,
            List<ItemOption> options = null!, List<MenuItem> items = null!, int idItem = 0)
        {


            if(singleItem == true && CustomizationsEnabled == true)
            {
                return new ConcretePersonalizedMenuItem(options, name, price, description, available, photoUrl, CustomizationsEnabled, categoryId, establishmentId);
            }

            if(singleItem)
            {
                return new ConcreteSingleMenuItem(idItem, name, price, description, available, photoUrl, CustomizationsEnabled, categoryId, establishmentId);
            }
            else
            {
                return new ConcreteBundle(items, idItem, name, price, description, available, photoUrl, singleItem, CustomizationsEnabled, categoryId, establishmentId);
            }

        }
    }
}
