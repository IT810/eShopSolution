using eShopSolution.Application.Catalog.DTOS;
using eShopSolution.Application.Catalog.DTOS.Manage;
using eShopSolution.Application.Catalog.Products.DTOS;
using eShopSolution.Application.Catalog.Products.DTOS.Manage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        // Create new a product
        Task<int> Create(ProductCreateRequest request);

        // Update info of a product
        Task<int> Update(ProductUpdateRequest request);

        // Delete info of a product
        Task<int> Delete(int id);

        // Update product price of a product
        Task<bool> UpdatePrice(int productId, decimal newPrice);

        // Update product stock of a product
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
