﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFuncionarios.Data.Entities
{
    /// <summary>
    /// Classe de entidade para Funcionário
    /// </summary>
    public class Funcionario
    {
        private Guid? _idFuncionario;
        private string? _nome;
        private string? _matricula;
        private string? _cpf;
        private DateTime? _dataAdmissao;
        private Guid? _idEmpresa;
        private Empresa? _empresa;

        public Guid? IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Matricula { get => _matricula; set => _matricula = value; }
        public string? Cpf { get => _cpf; set => _cpf = value; }
        public DateTime? DataAdmissao { get => _dataAdmissao; set => _dataAdmissao = value; }
        public Guid? IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public Empresa? Empresa { get => _empresa; set => _empresa = value; }
    }
}
