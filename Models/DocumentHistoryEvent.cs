using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DocumentHistoryEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("EventType")]
        public int Id { get; set; }
        public DocumentHistory DocumentHistory { get; set; }
        public string EventType { get; set; }
    }
}
