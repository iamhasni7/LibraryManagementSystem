using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Issued_Detail
    {
        [Key]
        public int issued_id { get; set; }

        [ForeignKey("Book_Details")]
        public int? book_id { get; set; }
        public Book Book { get; set; }

        [ForeignKey("User_Details")]
        public int? user_id { get; set; }
        public User User { get; set; }
    }
}
