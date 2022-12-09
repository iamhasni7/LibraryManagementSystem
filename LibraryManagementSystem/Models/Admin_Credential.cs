using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Admin_Credential
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
