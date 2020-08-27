using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using static slnMyStudy.IdentityConfig;

namespace slnMyStudy.Areas.Service.Controllers
{
    public class BaseApiController : ApiController
    {
        //public BaseApiController()
        //{
        //}

        //public BaseApiController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        //{
        //    UserManager = userManager;
        //    SignInManager = signInManager;
        //}

        //public BaseApiController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager)
        //{
        //    UserManager = userManager;
        //    SignInManager = signInManager;
        //    RoleManager = roleManager;
        //}
        //private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        //public ApplicationSignInManager SignInManager
        //{
        //    get => _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
        //    private set => _signInManager = value;
        //}

        public ApplicationUserManager UserManager
        {
            get => _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            private set => _userManager = value;
        }
        //private ApplicationRoleManager _roleManager;
        //public ApplicationRoleManager RoleManager
        //{
        //    get
        //    {
        //        return _roleManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
        //    }
        //    private set
        //    {
        //        _roleManager = value;
        //    }
        //}
    }
}
