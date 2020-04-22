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
        public string Description { get; set; }

        #region ForeignKeys
        [ForeignKey("Id")]
        public Document Document { get; set; }
        
        [ForeignKey("Id")]
        public User User { get; set; }
        #endregion ForeignKeys
    }
}
