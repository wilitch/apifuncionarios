using System.ComponentModel.DataAnnotations;

namespace ApiFuncionarios.Services.Models
{
    /// <summary>
    /// Modelo de dados para cadastro de funcionário
    /// </summary>
    public class FuncionariosPostModel
    {
        //[RegularExpression("^[A-Za-zÀ-Üà-ü\\s]{8,100}$", ErrorMessage = "Por favor, informe um nome válido de 8 a 100 caracteres.")]
        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string? Nome { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a matrícula do funcionário.")]
        public string? Matricula { get; set; }

        [RegularExpression("^[0-9]{11}$", ErrorMessage = "Por favor, informe um CPF com 11 dígitos numéricos.")]
        [Required(ErrorMessage = "Por favor, informe o CPF do funcionário.")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de admissão do funcionário.")]
        public DateTime? DataAdmissao { get; set; }

        [Required(ErrorMessage = "Por favor, informe a empresa do funcionário.")]
        public Guid? IdEmpresa { get; set; }
    }
}
