using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
	public class LibraryManagementSystemDbContext : DbContext
	{
		public LibraryManagementSystemDbContext(DbContextOptions<LibraryManagementSystemDbContext> options) : base(options)
		{

		}

		public DbSet<Book_Details> book { get; set; }
		public DbSet<Category_Details> category { get; set; }
		public DbSet<Shelf_Details> shelf { get; set; }
		public DbSet<User_Details> user { get; set; }
		public DbSet<Issued_Details> issued_details { get; set; }
		public DbSet<Admin_Credentials> admin_credentials { get; set; }
	}
}
