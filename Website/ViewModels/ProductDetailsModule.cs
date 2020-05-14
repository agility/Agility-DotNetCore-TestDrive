using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Website.Models;

namespace Website.ViewModels
{
    public class ProductDetailsModule
    {
        public Module_ProductDetails Module { get; set; }
        public Product Product { get; set; }
        public ProductCategory Category { get; set; }
    }
}