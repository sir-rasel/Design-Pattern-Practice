using Microsoft.EntityFrameworkCore;
using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using Repository_UnitOfWork_Pattern.src.Core.Domain;
using Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Context;
using System.Collections.Generic;
using System.Linq;

namespace Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceContext context)
            : base(context)
        {
        }

        public IEnumerable<Product> GetTopSellingProducts(int count)
        {
            return ECommerceContext.Products.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Product> GetProductsWithBrands(int pageIndex, int pageSize = 10)
        {
            return ECommerceContext.Products
                .Include(c => c.Brand)
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public ECommerceContext ECommerceContext
        {
            get { return Context as ECommerceContext; }
        }
    }
}
