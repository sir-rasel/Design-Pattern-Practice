using Microsoft.EntityFrameworkCore;
using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using Repository_UnitOfWork_Pattern.src.Core.Domain;
using Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Context;
using System.Linq;

namespace Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Repository
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ECommerceContext context) : base(context)
        {
        }

        public Brand GetBrandWithProducts(int id)
        {
            return ECommerceContext.Brands.Include(a => a.Products).SingleOrDefault(a => a.Id == id);
        }

        public ECommerceContext ECommerceContext
        {
            get { return Context as ECommerceContext; }
        }
    }
}
