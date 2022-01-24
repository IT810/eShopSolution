using eShopSolution.Application.Catalog.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.DTOS.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> categoryIds { get; set; }
    }
}
