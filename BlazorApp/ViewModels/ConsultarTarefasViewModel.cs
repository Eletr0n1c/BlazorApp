using System.ComponentModel.DataAnnotations;

namespace BlazorApp.ViewModels
{
    /// <summary>
    /// Modelo de dados para a página de consulta de tarefas
    /// </summary>
    public class ConsultarTarefasViewModel
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public string? DataInicio { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public string? DataFim { get; set; }
    }
}
