using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace slnMyStudy.Models
{
    public class AreaAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly string area;

        public AreaAuthorizeAttribute(string area)
        {
            this.area = area;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //string loginUrl = "";
            //if (area == "Admin")
            //{
            //    loginUrl = "~/Admin/Account/Login";
            //}
            //else if (area == "Customer")
            //{
            //    loginUrl = "~/Customer/Account/Login";
            //}


            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (!AuthorizeCore(filterContext.HttpContext))
            {
                filterContext.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    { "controller", "Account" },
                    { "action", "Login" },
                    { "area", area }
                });
            }

            //驗證有過也不留cache
            SetCachePolicy(filterContext);
            
            //filterContext.Result = new RedirectResult(loginUrl + "?returnUrl=" + filterContext.HttpContext.Request.Url.PathAndQuery);
        }

        private void SetCachePolicy(AuthorizationContext filterContext)
        {
            //怕下一秒把這個人被改成Unauth，但因為上一秒他成功進來過，被瀏覽器cache permission，導致雖然已unauth卻還是進的來，所以set 0
            var cachePolicy = filterContext.HttpContext.Response.Cache;
            cachePolicy.SetProxyMaxAge(new TimeSpan(0));
            cachePolicy.AddValidationCallback(CacheValidateHandler, null);
        }

        private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus)
        {
            if (!Enum.IsDefined(typeof(HttpValidationStatus), validationStatus))
            {
                throw new InvalidEnumArgumentException(nameof(validationStatus), (int)validationStatus,
                    typeof(HttpValidationStatus));
            }

            validationStatus = OnCacheAuthorization(new HttpContextWrapper(context));
        }

    }

    public class Security : AuthorizeAttribute
    {
        // Set default Unauthorized Page Url here
        private string _notifyUrl = "/Error/Unauthorized";

        public string NotifyUrl
        {
            get { return _notifyUrl; }
            set { _notifyUrl = value; }
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (AuthorizeCore(filterContext.HttpContext))
            {
                HttpCachePolicyBase cachePolicy =
                    filterContext.HttpContext.Response.Cache;
                cachePolicy.SetProxyMaxAge(new TimeSpan(0));
                cachePolicy.AddValidationCallback(CacheValidateHandler, null);
            }

            /// This code added to support custom Unauthorized pages.
            else if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                if (NotifyUrl != null)
                    filterContext.Result = new RedirectResult(NotifyUrl);
                else
                    // Redirect to Login page.
                    HandleUnauthorizedRequest(filterContext);
            }
            /// End of additional code
            else
            {
                // Redirect to Login page.
                HandleUnauthorizedRequest(filterContext);
            }
        }

        private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus)
        {
            if (!Enum.IsDefined(typeof(HttpValidationStatus), validationStatus))
            {
                throw new InvalidEnumArgumentException(nameof(validationStatus), (int)validationStatus,
                    typeof(HttpValidationStatus));
            }

            validationStatus = OnCacheAuthorization(new HttpContextWrapper(context));
        }
    }
}