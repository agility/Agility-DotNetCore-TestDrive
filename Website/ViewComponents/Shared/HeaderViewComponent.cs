using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website;
using Website.Models;
using Website.ViewModels;
using Agility.Web.Extensions;
using Agility.Web;
using Agility.Web.Objects;

namespace Website.ViewComponents.Shared
{
    public class Header: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync() 
        {
            return Task.Run<IViewComponentResult>(() =>
            {

                HeaderModel model = new HeaderModel()
                {
                    Header = new AgilityContentRepository<GlobalHeader>("GlobalHeader").Item(""),
                    Sitemap = AgilityContext.AgilitySiteMap

                };

                return View("~/Views/Shared/Header.cshtml", model);
            });
        }

    }

}