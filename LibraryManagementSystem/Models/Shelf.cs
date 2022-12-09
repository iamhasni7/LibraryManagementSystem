using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Shelf
    {
        [Key]
        public int shelf_id { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string shelf_floor { get; set; }
        public int shelf_number { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ICollection<Book> Book { get; set; }
    }
}
