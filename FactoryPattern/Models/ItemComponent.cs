namespace FactoryPattern.Models
{

    /// <summary>
    /// Each Item has Attributes that are implemented in
    /// a separate interface in order to extend the program ease of maintenance
    /// </summary>
    public interface ItemComponent
    {

        public string Name { get; set; }
        public decimal Price { get; set; }

        public string? Description { get; set; }

        public bool Available { get; set; }

        public string? PhotoURL { get; set; }
        public int CategoryId { get; set; }
    }
}
