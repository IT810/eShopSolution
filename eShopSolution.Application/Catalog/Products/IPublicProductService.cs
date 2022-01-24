using eShopSolution.Application.Catalog.DTOS;
using eShopSolution.Application.Catalog.Products.DTOS;
using eShopSolution.Application.Catalog.Products.DTOS.Public;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> getAllProducByCategory(GetProductPagingRequest request);
    }
}
