using eShopSolution.Application.Catalog.DTOS;
using eShopSolution.Application.Catalog.Products.DTOS;
using eShopSolution.Application.Catalog.Products.DTOS.Public;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> getAllProducByCategory(GetProductPagingRequest request);
    }
}
