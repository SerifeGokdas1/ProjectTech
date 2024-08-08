using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SliderId { get; set; }
        [StringLength(25), Required]
        public string SliderHeader { get; set; }
        [StringLength(200), Required]
        public string SliderText { get; set; }
        public string SliderImage { get; set; }
        [Url(ErrorMessage = "Geçerli bir Youtube linki giriniz.")]
        public string SliderVideoLink { get; set; }
        public bool SliderStatus { get; set; }
    }
}
