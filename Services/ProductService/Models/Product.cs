namespace ProductService.Models
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
