using System.Collections.Generic;
using System.Linq;

namespace WinFormsApp1
{
    public class ProductRepositoryStub : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public IEnumerable<Product> GetAll() => _products;

        public Product GetById(int id) => _products.FirstOrDefault(p => p.ID == id);

        public void Update(Product product)
        {
            var existing = GetById(product.ID);
            if (existing != null)
            {
                existing.UpdateInfo(product.Name, product.UnitIzmereniya);
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null) _products.Remove(product);
        }
    }
}