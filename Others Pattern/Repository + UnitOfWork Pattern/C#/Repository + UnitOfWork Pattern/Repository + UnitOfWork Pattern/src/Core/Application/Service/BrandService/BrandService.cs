using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using Repository_UnitOfWork_Pattern.src.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.Service.BrandService
{
    public class BrandService : CommonService<Brand>, IBrandService
    {
        protected readonly IBrandRepository _brandRepository;
        public BrandService()
        {
        }

        public Brand GetBrandWithProducts(int id)
        {
            return _brandRepository.GetBrandWithProducts(id);
        }
    }
}
