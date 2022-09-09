using Repository_UnitOfWork_Pattern.src.Core.Domain;
using System.Collections.Generic;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IEnumerable<Product> GetTopSellingProducts(int count);
        IEnumerable<Product> GetProductsWithBrands(int pageIndex, int pageSize);
    }
}