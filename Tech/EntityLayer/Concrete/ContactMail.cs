using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ContactMail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ContactMailId { get; set; }


        [StringLength(40), Required]
        [MaxLength(40, ErrorMessage = "Kullanıcı ismi ve soysimi en fazla 40 karakterli olmalıdır.")]
        public string ContactNameSurname { get; set; }


        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        public string ContactMailAddress { get; set; }

        [StringLength(50), Required]
        public string ContactMailSubject{ get; set; }
        [StringLength(350), Required]
        public string ContactMailMessage{ get; set; }
        public string? ContactMailDate{ get; set; }
        public bool ContactMailStatus{ get; set; }

    }
}
