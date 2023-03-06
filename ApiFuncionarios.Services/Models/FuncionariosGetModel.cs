using System.ComponentModel.DataAnnotations;

namespace ApiFuncionarios.Services.Models
{
    /// <summary>
    /// Modelo de dados para consulta de funcionários
    /// </summary>
    public class FuncionariosGetModel
    {
        public Guid? IdFuncionario { get; set; }
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataAdmissao { get; set; }
        /// <summary>
        /// Dados da empresa do funcionário
        /// </summary>
        public EmpresasGetModel? Empresa { get; set; }

    }
}
