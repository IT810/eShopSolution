using eShopSolution.Application.Catalog.DTOS;
using eShopSolution.Application.Catalog.Products.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products
{
    interface IPublicProductService
    {
        PagedViewModel<ProductViewModel> getAllProducByCategory(int CategoryId, int pageIndex, int pageSize);
    }
}
