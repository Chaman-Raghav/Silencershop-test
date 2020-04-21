using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Modals;

namespace WebApplication1.Models
{
    public class GlobalCorrectionLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public int? DocumentId { get; set; }
        public Document Document { get; set; }
        public int? UserId { get; set; }
        public string Description { get; set; }
        public DateTime? InitialDate { get; set; }
    }
}
