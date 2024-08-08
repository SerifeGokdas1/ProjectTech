using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? AdminId { get; set; }

        [StringLength(30), Required]
        [MaxLength(30, ErrorMessage = "Kullanıcı ismi ve soysimi en fazla 30 karakterli olmalıdır.")]
        public string AdminNameSurname { get; set; }

        public string AdminImage { get; set; }
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        public string AdminMail { get; set; }
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir numara ve bir özel karakter içermelidir.")]
        public string AdminPassword { get; set; }
        public bool AdminStatus { get; set; }
    }
}
