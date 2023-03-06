using System.ComponentModel.DataAnnotations;

namespace ApiFuncionarios.Services.Models
{
    /// <summary>
    /// Modelo de dados para edição de empresa
    /// </summary>
    public class EmpresasPutModel
    {
        [Required(ErrorMessage = "Por favor, informe o id da empresa desejada.")]
        public Guid? IdEmpresa { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome fantasia da empresa.")]
        public string? NomeFantasia { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a razão social da empresa.")]
        public string? RazaoSocial { get; set; }

        [RegularExpression("^[0-9]{14}$", ErrorMessage = "Por favor, informe um CNPJ com 14 dígitos numéricos.")]
        [Required(ErrorMessage = "Por favor, informe o CNPJ da empresa.")]
        public string? Cnpj { get; set; }
    }
}
