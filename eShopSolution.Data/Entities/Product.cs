using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entities
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int OrginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public int SeoAlias { get; set; }       
    }
}
