using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Models;

namespace Website.ViewModels
{
    public class ProductListingModule
    {
        public Module_ProductListing Module { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public ProductCategory FilteredCategory { get; set; }
        public List<Product> Products { get; set; }
        public Pagination Pagination { get; set; }
    }
}