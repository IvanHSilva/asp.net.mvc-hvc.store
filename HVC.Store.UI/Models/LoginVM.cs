using System.ComponentModel.DataAnnotations;

namespace HVC.Store.UI.Models {
    public class LoginVM {
        [Required(ErrorMessage = "E-Mail deve ser digitado!")]
        [StringLength(100, ErrorMessage = "E-Mail pode ter o máximo de 100 caracteres!")]
        [RegularExpression(@"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)", ErrorMessage = "E-Mail Inválido!")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "Senha deve ser digitada!")]
        [StringLength(30, ErrorMessage = "Senha pode ter o máximo de 30 caracteres!")]
        public string Password { get; set; }
        public bool UserLogged { get; set; }
        public string ReturnUrl { get; set; }
    }
}
