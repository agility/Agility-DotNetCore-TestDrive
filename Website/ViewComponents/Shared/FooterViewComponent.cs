using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website;
using Website.Models;
using Agility.Web.Extensions;
using Agility.Web;
using Agility.Web.Objects;

namespace Website.ViewComponents.Shared
{
    public class Footer: ViewComponent
    {

        public Task<IViewComponentResult> InvokeAsync() 
        {
            return Task.Run<IViewComponentResult>(() =>
            {

                var footer = new AgilityContentRepository<GlobalFooter>("GlobalFooter").Item("");
                return View("~/Views/Shared/Footer.cshtml", footer);

            });
        }

    }

}