using slnMyStudy.Models;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace slnMyStudy.WebAPI.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,password")] Member tMember)
        {
            tMemberService tMemberService = new tMemberService();
            if (ModelState.IsValid)
            {
                #region 密碼加密
                tMember = FirstHashPasword(tMember);
                #endregion        
                tMemberService.Create(tMember);
                
                return RedirectToAction("Index");
            }

            return View(tMember);
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