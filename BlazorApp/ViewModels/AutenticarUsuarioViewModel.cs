using System.ComponentModel.DataAnnotations;

namespace BlazorApp.ViewModels
{
    public class AutenticarUsuarioViewModel
    {
        [Required(ErrorMessage ="Por favor, informe o email de acesso.")]
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido")]
        public string? Email { get; set; }

        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Por favor, informe a senha com letras maiúsculas, minúsculas, números, símbolos e pelo menos 8 caracteres.")]
        [Required(ErrorMessage ="Por favor, informe a senha de acesso.")]
        public string? Senha { get; set; }
    }
}
