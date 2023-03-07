using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFuncionarios.Data.Entities
{
    /// <summary>
    /// Classe de entidade para Empresa
    /// </summary>
    public class Empresa
    {
        private Guid? _idEmpresa;
        private string? _nomeFantasia;
        private string? _razaoSocial;
        private string? _cnpj;
        private DateTime? _dataHoraCadastro;
        private List<Funcionario>? _funcionarios;

        public Guid? IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string? NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string? RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public string? Cnpj { get => _cnpj; set => _cnpj = value; }
        public DateTime? DataHoraCadastro { get => _dataHoraCadastro; set => _dataHoraCadastro = value; }
        public List<Funcionario>? Funcionarios { get => _funcionarios; set => _funcionarios = value; }
    }
}
