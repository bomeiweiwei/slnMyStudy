using slnMyStudy.Controllers;
using slnMyStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static slnMyStudy.IdentityConfig;

namespace slnMyStudy.Areas.Admin.Controllers
{
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
        //[Security(Roles = "Admin")]
        public ActionResult Index(string returnUrl)
        {
            List<CustomUser> result = new List<CustomUser>();

            var users = UserManager.Users.ToList();
            var Admins = RoleManager.Roles.Single(b => b.Name == "Admin").Users;
            var filterUserId = Admins.Select(m => m.UserId);
            result = users.Where(m => filterUserId.Any(id => id == m.Id)).ToList();

            return View(result);
        }

    }
}