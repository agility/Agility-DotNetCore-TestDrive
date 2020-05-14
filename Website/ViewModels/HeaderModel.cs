using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agility.Web;
using Agility.Web.Objects;
using Website.Models;

namespace Website.ViewModels
{
	public class HeaderModel
	{
		public GlobalHeader Header { get; set; }
		public AgilitySiteMap Sitemap { get; set; }
	}
}
