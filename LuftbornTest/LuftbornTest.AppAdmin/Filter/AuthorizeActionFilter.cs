using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LuftbornTest.AppAdmin.Filter
{
    public class AuthorizeActionFilter : IActionFilter
    {
        private readonly ISession Session;
        public AuthorizeActionFilter(IHttpContextAccessor HttpContextAccessor)
        {
             Session = HttpContextAccessor.HttpContext.Session;
        }
        void IActionFilter.OnActionExecuting(ActionExecutingContext context)
        {
            string Email = Session.GetString("Email");
            if (string.IsNullOrEmpty(Email))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
        }
        void IActionFilter.OnActionExecuted(ActionExecutedContext context)
        {
         
        }

       
    }
   public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute()
            : base(typeof(AuthorizeActionFilter))
        {
          
        }
    }
}
