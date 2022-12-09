using LibraryManagementSystem.Data;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
	{
		private readonly LibraryManagementSystemDbContext _context;
		public HomeController(LibraryManagementSystemDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{			
			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			Admin_Credential objAdmin = new Admin_Credential();
			return View(objAdmin);
		}

		[HttpPost]
        public IActionResult Login(string loginId, string password)
        {
            var status = _context.admin_credentials.Where(m => m.loginid == loginId && m.password == password).FirstOrDefault();

            if (status == null)
			{
				ViewBag.LoginStatus = 0;
			}

			else
			{
				return RedirectToAction("SuccessPage", "Home");
			}
			return View();
		}

		public IActionResult SuccessPage()
		{
			return View();
		}
    }
}
