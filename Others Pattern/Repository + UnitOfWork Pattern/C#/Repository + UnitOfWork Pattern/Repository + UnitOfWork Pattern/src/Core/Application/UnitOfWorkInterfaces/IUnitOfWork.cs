using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using System;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.UnitOfWorkInterfaces
{
    interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IBrandRepository Brands { get; }
        int Complete();
    }
}
