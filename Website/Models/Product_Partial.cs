using Agility.Web;
using Agility.Web.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public partial class Product
    {

        /// <summary>
        /// Returns the dynamic page url for a product
        /// </summary>
        /// <returns>Url for the current show</returns>
        public string Url
        {

            get
            {

                DynamicPageItem d = Data.GetDynamicPageItem("~/products/product-details", ReferenceName, Row);

                
                return $"/products/{d.Name}";
            }

        }

    }
}