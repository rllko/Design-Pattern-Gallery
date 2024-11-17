namespace FactoryPattern.Models
{
    /// <summary>
    /// Bundle of items, has a custom price by design
    /// </summary>
    class ConcreteBundle : MenuItem, IBundle
    {
        public List<MenuItem> Items { get; init; }

        public ConcreteBundle(List<MenuItem> items, int IdItem, string nome, decimal preco, string? descricao, bool disponivel, string? foto, bool itemsozinho, bool personalizacoesativas, int idCategoria, int idEstabelecimento) : base(IdItem, nome, preco, descricao, disponivel, foto, personalizacoesativas, idCategoria, idEstabelecimento)
        {
            Type = ItemType.ItemBundle;
            this.Items = items;
        }

        public List<MenuItem> getItems()
        {
            return Items;
        }
    }
}
