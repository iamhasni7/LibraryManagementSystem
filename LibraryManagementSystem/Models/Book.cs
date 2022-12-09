using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
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
        public Category Category { get; set; }

        [ForeignKey("Shelf_Details")]
        public int? shelf_id { get; set; }
        public Shelf Shelf { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ICollection<Issued_Detail> Issued_Detail { get; set; }
    }
}
