using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Modals;

namespace WebApplication1.Models
{
    public class SerialNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SerialNumberIs { get; set; }

        #region ForeignKeys
        [ForeignKey("Id")]
        public Document Document { get; set; }
        #endregion ForeignKeys
    }
}
