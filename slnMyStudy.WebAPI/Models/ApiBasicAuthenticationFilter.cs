using slnMyStudy.Models;
using slnMyStudy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;

namespace slnMyStudy.WebAPI.Models
{
    public class ApiBasicAuthenticationFilter : BasicAuthenticationFilter
    {

        public ApiBasicAuthenticationFilter()
        { }

        public ApiBasicAuthenticationFilter(bool active) : base(active)
        { }


        protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            // 在這裡加上帳號密碼的驗證，可以從資料庫取出資料進行比對
            string strUserName = username;
            string strPassword = password;
            bool blIsAuthorize = false;

            tMemberService tMemberService = new tMemberService();
            //tMember member = db.tMember.Where(m => m.Id == username && m.password == password).FirstOrDefault();
            string memguid = null;
            try
            {
                memguid = tMemberService.FindOne(m => m.Id == username).memguid;
            }
            catch (Exception)
            {
                
            }
            if (memguid == null)
            {
                blIsAuthorize = true;
            }
            else
            {
                byte[] dataAndGuid = ASCIIEncoding.ASCII.GetBytes(password + memguid);
                SHA512 sha512 = new SHA512CryptoServiceProvider();
                string resultSha512 = Convert.ToBase64String(sha512.ComputeHash(dataAndGuid));
                Member member = tMemberService.FindOne(m => m.Id == username && m.password == resultSha512);
                if (member != null)
                    blIsAuthorize = true;
            }

            return blIsAuthorize;
        }
    }
}