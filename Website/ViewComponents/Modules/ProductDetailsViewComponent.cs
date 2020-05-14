using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website;
using Website.Models;
using Agility.Web.Extensions;
using Agility.Web;
using Website.ViewModels;
using Microsoft.AspNetCore.Http.Extensions;

namespace Website.ViewComponents.Modules
{
    public class ProductDetails: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(Module_ProductDetails module) 
        {
            return Task.Run<IViewComponentResult>(() =>
            {

                var product = AgilityContext.GetDynamicPageItem<Product>();

                var model = new ProductDetailsModule();
                model.Module = module;

                if (product != null && product.ReferenceName == "Products")
                {
                    model.Product = product;

                    var category = new AgilityContentRepository<ProductCategory>("ProductCategories").Items().Where(i => i.ContentID == product.ProductCategoryID).FirstOrDefault();
                    model.Category = category;
                }



                return View("~/Views/Products/ProductDetailsModule.cshtml", model);
            });
        }

    }

}