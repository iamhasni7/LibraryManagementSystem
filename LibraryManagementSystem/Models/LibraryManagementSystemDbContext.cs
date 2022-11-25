using Microsoft.EntityFrameworkCore;
using static LibraryManagementSystem.Models.LibraryManagementSystem;

namespace LibraryManagementSystem.Models
{
	public class LibraryManagementSystemDbContext : DbContext
	{
		public LibraryManagementSystemDbContext(DbContextOptions<LibraryManagementSystemDbContext> options) : base(options)
		{

		}

		public DbSet<Book_Details> book_details { get; set; }
		public DbSet<Category_Details> category_details { get; set; }
		public DbSet<Shelf_Details> shelf_details { get; set; }
		public DbSet<User_Details> user_details { get; set; }
		public DbSet<Issued_Details> issued_details { get; set; }
	}
}
