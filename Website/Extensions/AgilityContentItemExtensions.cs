using Agility.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Extensions
{
    public static class AgilityContentItemExtensions
    {

		public static string QuizDetailsURL(this AgilityContentItem contentItem)
		{
			string detailsUrl = string.Empty;
            string itemUrl = contentItem["URL"] as string;

			switch (contentItem.ReferenceName)
			{
				case "Quizzes":
					detailsUrl = string.Format("~/quizzes/{0}", itemUrl);
					break;

				case "Polls":
					detailsUrl = string.Format("~/polls/{0}", itemUrl);
					break;

				default:
					break;
			}

			return detailsUrl;
		}

        public static string ArticleDetailsURL(this AgilityContentItem contentItem)
        {
            string detailsUrl = string.Empty;
            string itemUrl = contentItem["URL"] as string;

            switch (contentItem.ReferenceName)
            {
                case "Articles":
                    detailsUrl = string.Format("~/articles/{0}", itemUrl);
                    break;

                case "Factoids":
                    detailsUrl = string.Format("~/factoids/{0}", itemUrl);
                    break;

                case "GuestBlog":
                    detailsUrl = string.Format("~/guest-blogs/{0}", itemUrl);
                    break;

                case "Listicles":
                    detailsUrl = string.Format("~/listicles/{0}", itemUrl);
                    break;

                case "PhotoEditorials":
                    detailsUrl = string.Format("~/photo-editorials/{0}", itemUrl);
                    break;

                case "ProductSpotlights":
                    detailsUrl = string.Format("~/product-spotlights/{0}", itemUrl);
                    break;

                case "Videos":
                    detailsUrl = string.Format("~/videos/{0}", itemUrl);
                    break;

                default:
                    break;
            }

            return detailsUrl;
        }

    }
}