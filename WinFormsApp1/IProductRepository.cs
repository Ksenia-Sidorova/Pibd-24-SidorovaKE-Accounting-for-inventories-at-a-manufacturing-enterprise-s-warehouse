using System.Collections.Generic;

namespace WinFormsApp1
{
    public interface IProductRepository
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Update(Product product);
        void Delete(int id);
    }
}