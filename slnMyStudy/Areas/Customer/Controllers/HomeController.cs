using slnMyStudy.Controllers;
using slnMyStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static slnMyStudy.IdentityConfig;

namespace slnMyStudy.Areas.Customer.Controllers
{
    //[Security(Roles = "Admin")]
    [AreaAuthorize("Admin")]
    public class HomeController : BaseController
    {
        //public HomeController() : base()
        //{
        //}

        //public HomeController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) : base(userManager, signInManager)
        //{
        //}

        //public HomeController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager) : base(userManager, signInManager, roleManager)
        //{
        //}
       
        public ActionResult Index(string returnUrl)
        {
            List<CustomUser> result = new List<CustomUser>();

            var users = UserManager.Users.ToList();
            var Customer = RoleManager.Roles.Single(b => b.Name == "Customer").Users;
            var filterUserId = Customer.Select(m => m.UserId);
            result = users.Where(m => filterUserId.Any(id => id == m.Id)).ToList();

            return View(result);
        }
    }
}