using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopServicePortal_2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public double Phone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Password { get; set; }
    }
}
