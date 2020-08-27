﻿using slnMyStudy.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace slnMyStudy.Areas.Service.Controllers
{
    public class LangServiceController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ChangeLang([FromBody]SearchObj obj)
        {
            // Validate input 
            obj.culture = CultureHelper.GetImplementedCulture(obj.culture);

			// Save culture in a cookie 
			HttpCookie cookie = HttpContext.Current.Response.Cookies["_culture"];

			if (cookie != null)
			{
				// update cookie value 
				cookie.Value = obj.culture;
			}
			else
			{
				// create cookie value 
				cookie = new HttpCookie("_culture");
				cookie.Value = obj.culture;
				cookie.Expires = DateTime.Now.AddYears(1);
			}

			HttpContext.Current.Response.Cookies.Add(cookie);
            return Ok("語言變更");
        }

        public class SearchObj
        {
            public string culture { get; set; }
        }
    }
}
