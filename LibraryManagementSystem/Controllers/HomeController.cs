using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{			
			return View();
		}


		public IActionResult Login()
		{
			return View();
		}
	}
}
