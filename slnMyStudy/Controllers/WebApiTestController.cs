using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace slnMyStudy.Controllers
{
    public class WebApiTestController : Controller
    {
        // GET: WebApiTest
        public ActionResult Index()
        {
            string baseUrl = new Uri(Request.Url, Url.Content("~")).AbsoluteUri;
            baseUrl = baseUrl.Remove(baseUrl.Length - 1);
            ViewBag.baseUrl = baseUrl;
            return View();
        }
    }
}