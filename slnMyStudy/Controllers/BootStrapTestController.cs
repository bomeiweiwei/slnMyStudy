using PagedList;
using slnMyStudy.Models;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace slnMyStudy.Controllers
{
    public class BootStrapTestController : Controller
    {
        // GET: BootStrapTest
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// TableTest
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult TableTest(int page = 1)
        {
            int pageSize = 10;
            int pageCurrent = page < 1 ? 1 : page;

            ProductsService service = new ProductsService();
            List<Products> products = service.GetAll().ToList();
            var result = products.ToList().ToPagedList(pageCurrent, pageSize);

            return View(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult BookInfo()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult CreateBook()
        {
            return View();
        }

        [HttpPost, ActionName("DoCreateBook")]
        [ValidateAntiForgeryToken]
        public JsonResult CreateBook(BookInfo book)
        {
            return Json(book.TxtBookName + "新增成功");
        }

        public ActionResult MediaInfo()
        {
            return View();
        }

        public ActionResult ListGroup()
        {
            return View();
        }

        public ActionResult ButtonGroup()
        {
            return View();
        }

        public ActionResult NavTest()
        {
            return View();
        }

        public ActionResult NavBarTest()
        {
            return View();
        }

        public ActionResult CardTest()
        {
            return View();
        }

        public ActionResult JSModal()
        {
            return View();
        }

        public ActionResult CarouseTest()
        {
            return View();
        }

        public ActionResult CollapseTest()
        {
            return View();
        }

        public ActionResult CollapseTest2()
        {
            return View();
        }

        //public ActionResult TestRenderAction(string content = "init")
        //{
        //    ViewBag.content = content;
        //    return View();
        //}

        //public ActionResult TestRenderAction2(string content = "init")
        //{
        //    ViewBag.content = content;
        //    return View();
        //}

        public ActionResult BootstrapDialogTest()
        {
            return View();
        }
        public ActionResult DialogShow(SearchModel searchObj)
        {
            ProductsService service = new ProductsService();
            List<Products> products = service.GetAll().ToList();
            if (searchObj.id.HasValue)
            {
                return View(products.Where(m => m.ProductID > searchObj.id).ToList());
            }
            else
            {
                return View(new List<Products>());
            }
        }
        public ActionResult BootstrapDialogShow(SearchModel searchObj)
        {
            ProductsService service = new ProductsService();
            List<Products> products = service.GetAll().ToList();
            if (searchObj.id.HasValue)
            {
                return View(products.Where(m => m.ProductID > searchObj.id).ToList());
            }
            else
            {
                return View(new List<Products>());
            }
        }
    }
}