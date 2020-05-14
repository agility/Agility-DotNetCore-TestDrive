using Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.ViewModels
{
    public class ProductList
    {
        public List<Product> Products { get; set; }
        public Module_ProductListing Module { get; set; }
    }
}