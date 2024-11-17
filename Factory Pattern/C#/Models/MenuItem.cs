namespace FactoryPattern.Models
{
    public abstract class MenuItem : Item, ItemComponent
    {
        public MenuItem(int ItemId, string name, decimal rice, string? description, bool available, string? photoUrl, bool personalizacoesativas, int idCategoria, int idEstabelecimento)
            : base(ItemId, personalizacoesativas, idEstabelecimento)
        {
            Name = name;
            Price = rice;
            Description = description;
            Available = available;
            PhotoURL = photoUrl;
            this.CategoryId = idCategoria;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public bool Available { get; set; }
        public string? PhotoURL { get; set; }
        public int CategoryId { get; set; }
    }
}
