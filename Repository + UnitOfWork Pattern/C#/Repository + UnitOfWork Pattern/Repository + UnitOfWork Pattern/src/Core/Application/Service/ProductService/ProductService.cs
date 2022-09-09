using Repository_UnitOfWork_Pattern.src.Core.Application.RepositoryInterfaces;
using Repository_UnitOfWork_Pattern.src.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.Service.ProductService
{
    public class BrandService : CommonService<Product>, IProductService
    {
        protected readonly IProductRepository _productRepository;
        public BrandService()
        {
        }

        public IEnumerable<Product> GetTopSellingProducts(int count)
        {
           return  _productRepository.GetTopSellingProducts(count);
        }

        public IEnumerable<Product> GetProductsWithBrands(int pageIndex, int pageSize = 10)
        {
            return _productRepository.GetProductsWithBrands(pageIndex, pageSize);
        }
    }
}
