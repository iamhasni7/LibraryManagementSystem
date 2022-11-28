using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using static LibraryManagementSystem.Models.LibraryManagementSystem;

namespace LibraryManagementSystem.Controllers
{
	public class HomeController : Controller
	{
		private readonly LibraryManagementSystemDbContext LMS;
		public HomeController(LibraryManagementSystemDbContext db)
		{
			LMS = db;
		}

		public IActionResult Index()
		{			
			return View();
		}


	}
}
