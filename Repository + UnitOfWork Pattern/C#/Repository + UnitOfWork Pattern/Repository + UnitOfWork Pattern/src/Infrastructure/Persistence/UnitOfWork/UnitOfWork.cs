using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using Repository_UnitOfWork_Pattern.src.Core.Application.UnitOfWorkInterfaces;
using Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Context;
using Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.Repository;

namespace Repository_UnitOfWork_Pattern.src.Infrastructure.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerceContext _context;

        public UnitOfWork(ECommerceContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
            Brands = new BrandRepository(_context);
        }

        public IProductRepository Products { get; private set; }
        public IBrandRepository Brands { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
