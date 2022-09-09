using Repository_UnitOfWork_Pattern.src.Core.Domain;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces
{
    public interface IBrandRepository : IGenericRepository<Brand>
    {
        Brand GetBrandWithProducts(int id);
    }
}