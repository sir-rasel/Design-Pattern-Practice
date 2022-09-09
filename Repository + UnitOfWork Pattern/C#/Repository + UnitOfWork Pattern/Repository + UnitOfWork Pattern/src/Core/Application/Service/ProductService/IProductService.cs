using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_UnitOfWork_Pattern.src.Core.Application.Service.ProductService
{
    interface IProductService : ICommonService<Domain.Product>
    {
        IEnumerable<Domain.Product> GetTopSellingProducts(int count);
        IEnumerable<Domain.Product> GetProductsWithBrands(int pageIndex, int pageSize);
    }
}
