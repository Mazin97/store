using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories;

public class FakeProductRepository : IProductRepository
{
    public IEnumerable<Product> Get(IEnumerable<Guid> ids)
    {
        IList<Product> products = new List<Product>();

        products.Add(new Product("Produto 1", 10, true));
        products.Add(new Product("Produto 2", 20, true));
        products.Add(new Product("Produto 3", 30, true));
        products.Add(new Product("Produto 4", 40, false));
        products.Add(new Product("Produto 5", 50, false));

        return products;
    }
}
