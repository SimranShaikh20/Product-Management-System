namespace ProductManagmentSystem.Models
{
    public class Product
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
    }
}
