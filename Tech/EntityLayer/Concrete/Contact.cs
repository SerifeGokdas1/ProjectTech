using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        public string ContactAddress { get; set; }
        [RegularExpression(@"^[0-9]{11}$", ErrorMessage = "Telefon numarası 11 haneli olmalıdır.")]
        public string ContactMobilePhoneNumber { get; set; }
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        public string ContactMailAddress { get; set; }
        [Url(ErrorMessage = "Geçerli bir Instagram linki giriniz.")]
        public string ContactInstagram { get; set; }
        [Url(ErrorMessage = "Geçerli bir Youtube linki giriniz.")]
        public string ContactYoutube { get; set; }
        [Url(ErrorMessage = "Geçerli bir Facebook linki giriniz.")]
        public string ContactFacebook { get; set; }
        [Url(ErrorMessage = "Geçerli bir X linki giriniz.")]
        public string ContactX { get; set; }
        [Url(ErrorMessage = "Geçerli bir LinkedIn linki giriniz.")]
        public string ContactLinkedIn { get; set; }
        public bool ContactStatus { get; set; }
    }
}
