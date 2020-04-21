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
        public string CustomerName { get; set; }

        [ForeignKey("Id")]
        public int? DocumentStatusId { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public string TSN { get; set; }
        public bool? IsFlagged { get; set; }
        public bool? IsAssigned { get; set; }
       
        public int? SerialNumberId { get; set; }

        [ForeignKey("Id")]
        public int? UserId { get; set; } 
        public User User { get; set; }
        public int? VersionNumber { get; set; }
        public string CreationDate { get; set; }
        public string ExpirationDate { get; set; }

        public List<AssignedUser> AssignedUsers {get; set;}
        public List<SerialNumber> SerialNumbers { get; set; }
        public List<Note> Notes { get; set; }
        public List<FlaggedDocument> FlaggedDocuments { get; set; }

    }
}
