using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Modals;

namespace WebApplication1.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? SerialNumberId { get; set; }
        public int? VersionNumber { get; set; }
        public string CustomerName { get; set; }
        public string TSN { get; set; }
        public bool? IsFlagged { get; set; }
        public bool? IsAssigned { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        #region ForeignKeys
        [ForeignKey("Id")]
        public DocumentStatus DocumentStatus { get; set; }
       
        [ForeignKey("Id")] 
        public User User { get; set; }
        #endregion ForeignKeys

        public List<AssignedUser> AssignedUsers {get; set;}
        public List<SerialNumber> SerialNumbers { get; set; }
        public List<Note> Notes { get; set; }
        public List<FlaggedDocument> FlaggedDocuments { get; set; }
        public List<File> Files { get; set; }
        public List<GlobalCorrectionLog> GlobalCorrectionLogs { get; set; }
        public List<DocumentHistory> DocumentHistories { get; set; }

    }
}
