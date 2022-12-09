using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Category
    {
        [Key]
        public int category_id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string category_name { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ICollection<Book> Book { get; set; }
    }
}
