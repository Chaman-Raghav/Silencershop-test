using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Modals;

namespace WebApplication1.Models
{
    public class DocumentHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        #region ForeignKeys
        [ForeignKey("Id")]
        public Document Document { get; set; }

        [ForeignKey("Id")]
        public DocumentHistoryEvent EventType { get; set; }

        [ForeignKey("Id")]
        public User EventMadeByUser { get; set; }
        #endregion ForeignKeys

    }
}
