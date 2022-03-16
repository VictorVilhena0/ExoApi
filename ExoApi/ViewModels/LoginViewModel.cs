using System.ComponentModel.DataAnnotations;

namespace ExoApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o email do usuário")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário")]
        public string Senha { get; set; }
    }
}
