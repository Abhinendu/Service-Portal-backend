using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopServicePortal_2.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required] public string Summary { get; set; }
        public string description { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string ComplaintType { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        
        public int UserId { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public int CommentId { get; set; }
    }
}
