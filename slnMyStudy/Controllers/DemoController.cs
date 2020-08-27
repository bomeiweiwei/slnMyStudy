using PagedList;
using slnMyStudy.Models;
using slnMyStudy.Models.ViewModel;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace slnMyStudy.Controllers
{
    public class DemoController : BaseController
    {
        /// <summary>
        /// 商品資訊網頁
        /// </summary>
        /// <param name="page"></param>
        /// <param name="catId"></param>
        /// <returns></returns>
        public ActionResult Index(int page = 1, int catId = 1)
        {
            ProductsService service = new ProductsService();
            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();

            ViewBag.catId = catId;

            int pageSize = 10;
            int pageCurrent = page < 1 ? 1 : page;

            var products = service.Get(p => p.CategoryID == catId);

            var result = products.ToList().ToPagedList(pageCurrent, pageSize);

            List<Categories> CategoryList = categoriesService.GetAll().ToList();
            List<Suppliers> SupplierList = suppliersService.GetAll().ToList();

            ProductsCategoriesViewModel ProductsCategory = new ProductsCategoriesViewModel()
            {
                CategoriesList = CategoryList.OrderBy(m => m.CategoryID).ToList(),
                ProductsList = result,
                ProductsPageList = result
            };

            ViewBag.CategoryList = CategoryList;
            ViewBag.SupplierList = SupplierList;
            ViewBag.CategoryItems = new SelectList(
                items: CategoryList,
                dataTextField: "CategoryName",
                dataValueField: "CategoryID"
                );
            ViewBag.SupplierItems = new SelectList(
                items: SupplierList,
                dataTextField: "CompanyName",
                dataValueField: "SupplierID"
                );
            return View(ProductsCategory);
        }
    }
}