using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repository_UnitOfWork_Pattern.src.Core.Domain;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.Service.BrandService
{
    interface IBrandService : ICommonService<Domain.Brand>
    {
        Brand GetBrandWithProducts(int id);
    }
}
