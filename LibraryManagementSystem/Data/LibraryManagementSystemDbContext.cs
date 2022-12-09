using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Data
{
    public class LibraryManagementSystemDbContext : DbContext
    {
        public LibraryManagementSystemDbContext(DbContextOptions<LibraryManagementSystemDbContext> options) : base(options)
        {

        }

        public DbSet<Book> books { get; set; }
        public DbSet<Category> categorys { get; set; }
        public DbSet<Shelf> shelfs { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Issued_Detail> issued_details { get; set; }
        public DbSet<Admin_Credential> admin_credentials { get; set; }
    }
}
