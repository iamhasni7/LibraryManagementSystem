using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LibraryManagementSystem.Models
{
	public class Book_Details
	{
		[Key]
		public int book_id { get; set; }

		[Column(TypeName = "varchar(100)")]
		public string book_title { get; set; }

		[Column(TypeName = "varchar(100)")]
		public string book_author { get; set; }

		public int book_release_year { get; set; }

		[ForeignKey("Category_Details")]
		public int? category_id { get; set; }
		public Category_Details Category_Details { get; set; }

		[ForeignKey("Shelf_Details")]
		public int? shelf_id { get; set; }
		public Shelf_Details Shelf_Details { get; set; }

		[DeleteBehavior(DeleteBehavior.SetNull)]
		public ICollection<Issued_Details> Issued_Details { get; set; }
	}

	public class Category_Details
	{
		[Key]
		public int category_id { get; set; }

		[Column(TypeName = "varchar(100)")]
		public string category_name { get; set; }

		[DeleteBehavior(DeleteBehavior.SetNull)]
		public ICollection<Book_Details> Book_Details { get; set; }
	}

	public class Shelf_Details
	{
		[Key]
		public int shelf_id { get; set; }

		[Column(TypeName = "varchar(20)")]
		public string shelf_floor { get; set; }
		public int shelf_number { get; set; }

		[DeleteBehavior(DeleteBehavior.SetNull)]
		public ICollection<Book_Details> Book_Details { get; set; }
	}

	public class User_Details
	{
		[Key]
		public int user_id { get; set; }

		[Column(TypeName = "varchar(50)")]
		public string user_name { get; set; }

		[Column(TypeName = "varchar(10)")]
		public string user_gender { get; set; }

		[Column(TypeName = "Date")]
		public DateTime user_dob { get; set; }

		[Column(TypeName = "varchar(15)")]
		public string user_type { get; set; }

		[DeleteBehavior(DeleteBehavior.SetNull)]
		public ICollection<Issued_Details> Issued_Details { get; set; }
	}

	public class Issued_Details
	{
		[Key]
		public int issued_id { get; set; }

		[ForeignKey("Book_Details")]
		public int? book_id { get; set; }
		public Book_Details Book_Details { get; set; }

		[ForeignKey("User_Details")]
		public int? user_id { get; set; }
		public User_Details User_Details { get; set; }
	}

	public class Admin_Credentials
	{
		[Key]
		public int id { get; set; }

		[Column(TypeName = "varchar(50)")]
		public string name { get; set; }

		[Required(ErrorMessage = "LoginID is required")]
		[Column(TypeName = "varchar(50)")]
		public string loginid { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string password { get; set; }
	}
}
