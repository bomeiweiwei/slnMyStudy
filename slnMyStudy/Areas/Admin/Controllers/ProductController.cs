using PagedList;
using slnMyStudy.Controllers;
using slnMyStudy.Models;
using slnMyStudy.Models.ViewModel;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static slnMyStudy.IdentityConfig;

namespace slnMyStudy.Areas.Admin.Controllers
{
    //[Security(Roles = "Admin")]
    [AreaAuthorize("Admin")]
    public class ProductController : BaseController
    {
        // GET: Admin/Product
        //public ProductController() : base()
        //{
        //}

        //public ProductController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) : base(userManager, signInManager)
        //{
        //}

        //public ProductController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager) : base(userManager, signInManager, roleManager)
        //{
        //}

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
            return View(ProductsCategory);
        }

        public ActionResult Details(int? id)
        {
            ProductsService productsService = new ProductsService();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = productsService.FindOne(m => m.ProductID == id.Value);
            if (products == null)
            {
                return HttpNotFound();
            }

            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();
            ViewBag.CategoryList = categoriesService.GetAll().ToList();
            ViewBag.SupplierList = suppliersService.GetAll().ToList();

            return View(products);
        }

        public ActionResult Create()
        {
            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();

            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued")] Products products)
        {
            products = EncodeModel(products);

            ProductsService productsService = new ProductsService();
            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();

            ModelState.Remove("ProductID");
            if (ModelState.IsValid)
            {
                int result = productsService.Create(products);
                return RedirectToAction("Index", "Product", new { area = "Admin" });
            }

            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName", products.CategoryID);
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName", products.SupplierID);
            return View();
        }

        public ActionResult Edit(int? id)
        {
            ProductsService productsService = new ProductsService();
            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = productsService.FindOne(m => m.ProductID == id.Value);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName", products.CategoryID);
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName", products.SupplierID);
            return View(products);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued")] Products products)
        {
            products = EncodeModel(products);

            ProductsService productsService = new ProductsService();
            CategoriesService categoriesService = new CategoriesService();
            SuppliersService suppliersService = new SuppliersService();
            if (ModelState.IsValid)
            {
                int result = productsService.Update(products);
                return RedirectToAction("Index", "Product", new { area = "Admin" });
            }
            ViewBag.CategoryID = new SelectList(categoriesService.GetAll(), "CategoryID", "CategoryName", products.CategoryID);
            ViewBag.SupplierID = new SelectList(suppliersService.GetAll(), "SupplierID", "CompanyName", products.SupplierID);
            return View(products);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductsService productsService = new ProductsService();
            Products products = productsService.FindOne(m => m.ProductID == id);
            int result = productsService.Delete(products);
            return Json("Success");
        }
    }
}