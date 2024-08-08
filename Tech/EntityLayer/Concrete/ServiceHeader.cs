using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ServiceHeader
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceHeaderId { get; set; }
        [StringLength(35), Required]
        public string ServiceHeaderKeyword { get; set; }
        [StringLength(110), Required]
        public string ServiceHeaderDescription { get; set; }
        public bool ServiceHeaderStatus { get; set; }
    }
}
