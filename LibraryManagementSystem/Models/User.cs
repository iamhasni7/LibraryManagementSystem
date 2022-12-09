using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Column(TypeName = "varchar(50)")]
        public string user_name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [Column(TypeName = "varchar(10)")]
        public string user_gender { get; set; }

        [Column(TypeName = "Date")]
        public DateTime user_dob { get; set; }

        [Column(TypeName = "varchar(15)")]
        public string user_type { get; set; }

        [DeleteBehavior(DeleteBehavior.SetNull)]
        public ICollection<Issued_Detail> Issued_Detail { get; set; }
    }
}
