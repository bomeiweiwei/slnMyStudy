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
using System.Threading.Tasks;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using slnMyStudy.Service;
using static slnMyStudy.IdentityConfig;
using System.Text;
using System.Security.Cryptography;

namespace slnMyStudy.Areas.Customer.Controllers
{
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
            return RedirectToAction("Index", "Demo", new { area = "" });
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
            tMemberService tMemberService = new tMemberService();
            if (ModelState.IsValid)
            {
                //try
                //{
                //    Member tMember = new Member();
                //    tMember.Id = model.UserName;
                //    tMember.password = model.Password;
                //    #region 密碼加密
                //    tMember = FirstHashPasword(tMember);
                //    #endregion
                //    int count = tMemberService.Create(tMember);
                //}
                //catch (Exception)
                //{ 
                //}

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
                            var roleName = "Customer";
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
                            return RedirectToAction("Index", "Demo", new { area = "" });
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
            return RedirectToAction("Index", "Demo", new { area = "" });
        }

        private Member FirstHashPasword(Member member)
        {
            Guid userGuid = System.Guid.NewGuid();
            byte[] dataAndGuid = ASCIIEncoding.ASCII.GetBytes(member.password + userGuid.ToString());
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            string resultSha512 = Convert.ToBase64String(sha512.ComputeHash(dataAndGuid));
            member.password = resultSha512;
            member.memguid = userGuid.ToString();
            return member;
        }
    }
}