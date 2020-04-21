using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Modals;

namespace WebApplication1.Models
{
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public int? DocumentId { get; set; }
        public Document Document { get; set; }
        public string Description { get; set; }
        [ForeignKey("Id")]
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
