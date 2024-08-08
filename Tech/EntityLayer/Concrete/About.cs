using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AboutId { get; set; }
        [StringLength(50), Required]
        public string AboutTitle { get; set; }
        [StringLength(250), Required]
        public string AboutDetail { get; set; }
        public string AboutFirstImage { get; set; }
        [StringLength(65), Required]
        public string AboutFirstSentence { get; set; }
        [StringLength(65), Required]
        public string AboutSecondSentence { get; set; }
        [StringLength(65), Required]
        public string AboutThirdSentence { get; set; }
        public string AboutSecondImage { get; set; }
        [StringLength(40), Required]
        public string AboutFirstTitle { get; set; }
        [StringLength(100), Required]
        public string AboutFirstExplanation { get; set; }
        [StringLength(40), Required]
        public string AboutSecondTitle { get; set; }
        [StringLength(100), Required]
        public string AboutSecondExplanation { get; set; }
        [StringLength(40), Required]
        public string AboutThirdTitle { get; set; }
        [StringLength(100), Required]
        public string AboutThirdExplanation { get; set; }
        [StringLength(40), Required]
        public string AboutFourthTitle { get; set; }
        [StringLength(100), Required]
        public string AboutFourthExplanation { get; set; }
        public string AboutFooterImage { get; set; }
        [StringLength(50), Required]
        public string AboutFooterTitle { get; set; }
        [StringLength(300), Required]
        public string AboutFooterText { get; set; }
        public bool AboutStatus { get; set; }
    }
}
