using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using slnMyStudy.Controllers;
using slnMyStudy.Models;
using slnMyStudy.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using static slnMyStudy.IdentityConfig;

namespace slnMyStudy.Areas.Admin.Controllers
{
    //[Security(Roles = "Admin")]
    [AreaAuthorize("Admin")]
    public class AccountController : BaseController
    {
        //public AccountController() : base()
        //{
        //}

        //public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) : base(userManager, signInManager)
        //{
        //}

        //public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager) : base(userManager, signInManager, roleManager)
        //{
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Login", "Account", new { area = "Admin" });
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            model = EncodeModel(model);

            if (ModelState.IsValid)
            {
                string hashPwd = UserManager.PasswordHasher.HashPassword(model.Password);
                var user = new CustomUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    PasswordHash = hashPwd,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        var result = await UserManager.CreateAsync(user);
                        if (result.Succeeded)
                        {
                            //角色名稱
                            var roleName = "Admin";
                            //判斷角色是否存在
                            if (RoleManager.RoleExists(roleName) == false)
                            {
                                //角色不存在,建立角色
                                var role = new IdentityRole(roleName);
                                await RoleManager.CreateAsync(role);
                            }
                            //將使用者加入該角色
                            await UserManager.AddToRoleAsync(user.Id, roleName);

                            scope.Complete();
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        AddErrors(result);
                    }
                    catch (DbEntityValidationException ex)
                    {
                        logger.Error(GetEntityErrorMsg(ex));
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                        scope.Dispose();
                    }
                }
            }
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await SignInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, shouldLockout: false);
            switch (result)
            {
                case SignInStatus.Success:
                    return RedirectToLocal(returnUrl);
                //case SignInStatus.LockedOut:
                //    return View("Lockout");
                //case SignInStatus.RequiresVerification:
                //    return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
                case SignInStatus.Failure:
                default:
                    ModelState.AddModelError("", "登入嘗試失試。");
                    return View(model);
            }
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = UserManager.FindById(id);
            EditViewModel viewModel = new EditViewModel
            {
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditEmp(EditViewModel model)
        {
            model = EncodeModel(model);

            ModelState.Remove("Password");
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Edit", model);
            }
            else
            {                
                var user = await UserManager.FindByNameAsync(model.UserName);
                user.Email = model.Email;
                user.PhoneNumber = model.PhoneNumber;
                if (!string.IsNullOrWhiteSpace(model.Newpwd))
                {
                    user.PasswordHash = UserManager.PasswordHasher.HashPassword(model.Newpwd);
                }
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        var result = await UserManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            scope.Complete();
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        logger.Error(GetEntityErrorMsg(ex));
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                        scope.Dispose();
                    }
                }
            }
            return RedirectToAction("Edit", model);
        }

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CustomUser viewModel = UserManager.FindById(id);
            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(string id)
        {
            var user = await UserManager.FindByIdAsync(id);
            var logins = user.Logins;
            var rolesForUser = await UserManager.GetRolesAsync(user.Id);

            var appDbContext = HttpContext.GetOwinContext().Get<ApplicationDbContext>();
            using (var transaction = appDbContext.Database.BeginTransaction())
            {
                try
                {
                    foreach (var login in logins.ToList())
                    {
                        await UserManager.RemoveLoginAsync(login.UserId, new UserLoginInfo(login.LoginProvider, login.ProviderKey));
                    }

                    if (rolesForUser.Count() > 0)
                    {
                        foreach (var item in rolesForUser.ToList())
                        {
                            // item should be the name of the role
                            var result = await UserManager.RemoveFromRoleAsync(user.Id, item);
                        }
                    }

                    await UserManager.DeleteAsync(user);

                    transaction.Commit();

                    return Json("刪除成功");
                }
                catch (DbEntityValidationException ex)
                {
                    logger.Error(GetEntityErrorMsg(ex));
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    transaction.Rollback();
                }
                return Json("刪除失敗");
            }
        }
    }
}
