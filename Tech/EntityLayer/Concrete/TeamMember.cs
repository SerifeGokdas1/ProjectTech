using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TeamMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamMemberId { get; set; }
        [StringLength(25), Required]
        public string TeamMemberNameSurname { get; set; }
        [StringLength(200), Required]
        public string TeamMemberImage { get; set; }
        [Url(ErrorMessage = "Geçerli bir Youtube linki giriniz.")]
        public string TeamMemberLinkedIn { get; set; }
        public bool SliderStatus { get; set; }
    }
}
