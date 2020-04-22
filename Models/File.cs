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
        public string FileName { get; set; }
        public DateTime? UploadedDate { get; set; }

        #region ForeignKeys
        [ForeignKey("Id")]
        public User User { get; set; }

        [ForeignKey("Id")]
        public Document Document { get; set; }

        [ForeignKey("Id")]
        public FileType FileType { get; set; }
        #endregion ForeignKeys
    }
}
