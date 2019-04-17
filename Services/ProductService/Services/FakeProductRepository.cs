using ProductService.Models;
using System.Collections.Generic;

namespace ProductService.Services
{
    public class FakeProductRepository
    {
        public readonly List<Product> FakeSource = new List<Product>();

        public FakeProductRepository()
        {
            for (var i = 1; i <= 10; i++)
            {
                FakeSource.Add(new Product(i, $"product -- {i}"));
            }
        }
    }
}
