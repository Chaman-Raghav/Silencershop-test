using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Modals;

namespace WebApplication1.Models
{
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public int? DocumentId { get; set; }
        public Document Document { get; set; }
        public string FileName { get; set; }

        [ForeignKey("Id")]
        public int? UserId { get; set; }
        public User User { get; set; }
        public DateTime? UploadedDate { get; set; }

        [ForeignKey("Id")]
        public int? FileTypeId { get; set; }
        public FileType FileType { get; set; }
    }
}
