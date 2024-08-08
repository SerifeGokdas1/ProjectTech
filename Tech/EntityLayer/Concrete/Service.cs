using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }
        [StringLength(35), Required]
        public string ServiceName { get; set; }
        [StringLength(100), Required]
        public string ServiceTitle { get; set; }
        [StringLength(1300), Required]
        public string ServiceDescription { get; set; }
        public string ServiceImage { get; set; }
        [StringLength(60), Required]
        public string FirstEffectiveSentence { get; set; }
        [StringLength(60), Required]
        public string SecondEffectiveSentence { get; set; }
        [StringLength(60), Required]
        public string ThirdEffectiveSentence { get; set; }
        public bool ServiceStatus { get; set; }
    }
}
