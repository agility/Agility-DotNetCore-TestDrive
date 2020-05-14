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
    public class ProductListing: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync(Module_ProductListing module) 
        {
            return Task.Run<IViewComponentResult>(() =>
            {


                int categoryID = 0;
                int page = 0;

                var catStr = Request.Query["category"];
                var pageStr = Request.Query["page"];

                int.TryParse(catStr, out categoryID);
                int.TryParse(pageStr, out page);

                if (page == 0) page = 1;

                int totalCount = 0;
                int pageSize = module.ProductsPerPage;
                string rowFilter = "";

                if (categoryID > 0)
                {
                    rowFilter = string.Format("ProductCategoryID = {0}", categoryID);
                }

                int skip = (page - 1) * pageSize;
                int take = pageSize;

                var products = new AgilityContentRepository<Product>("Products").Items(rowFilter, "Title ASC", take, skip, out totalCount);

                var model = new ProductListingModule();
                model.Categories = new AgilityContentRepository<ProductCategory>("ProductCategories").Items();
                model.FilteredCategory = model.Categories.Where(i => i.ContentID == categoryID).FirstOrDefault();
                model.Products = products;
                model.Module = module;

                var pagination = new Pagination();
                pagination.BaseUrl = Request.Path.Value;
                pagination.CurrentPageNumber = page;
                pagination.ResultsPerPage = module.ProductsPerPage;
                pagination.PaginationAs = PaginationMode.PageNumbers;
                pagination.TotalResults = totalCount;

                model.Pagination = pagination;

                
                return View("~/Views/Products/ProductListingModule.cshtml", model);
            });
        }

    }

}