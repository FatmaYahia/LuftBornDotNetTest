using Entity.AuthModel;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace LuftbornTest.AppAdmin.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession session;
        private readonly UnitOfWork UOW;
        public LoginController(IHttpContextAccessor httpContextAccessor ,UnitOfWork UOW)
        {
            session = httpContextAccessor.HttpContext.Session;
            this.UOW = UOW;

        }
        public IActionResult Index()
        {
            session.Clear();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SystemUser systemUser)
        {
           

            if (UOW.systemUserRepository.UserExist(systemUser.Email, systemUser.Password))
            {
                systemUser = UOW.systemUserRepository.GetByEmail(systemUser.Email);
                session.SetString("Email", systemUser.Email);
                session.SetString("FullName", systemUser.FullName);
                session.SetString("JobTitle", systemUser.JobTitle);
                return RedirectToAction(nameof(Index), "Home");
            }
            ViewData["Error"] = "Email Or Password Are Wrong, Or Account is Deactivated";
          
            return View(systemUser);
        }
        public IActionResult Logout()
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
