﻿using eShopSolution.Application.Catalog.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.DTOS.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int categoryId { get; set; }
    }
}
