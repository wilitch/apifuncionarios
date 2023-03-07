using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiFuncionarios.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiFuncionarios.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento para a entidade Funcionario
    /// </summary>
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            //nome da tabela no banco de dados
            builder.ToTable("FUNCIONARIO");

            //chave primária da tabela
            builder.HasKey(f => f.IdFuncionario);

            //mapeamento dos campos
            builder.Property(f => f.IdFuncionario)
                .HasColumnName("IDFUNCIONARIO");

            builder.Property(f => f.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(f => f.Matricula)
                .HasColumnName("MATRICULA")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(f => f.Cpf)
                .HasColumnName("CPF")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(f => f.DataAdmissao)
                .HasColumnName("DATAADMISSAO")
                .IsRequired();

            builder.Property(f => f.IdEmpresa)
                .HasColumnName("IDEMPRESA")
                .IsRequired();

            //mapeamento do relacionamento entre as entidades
            builder.HasOne(f => f.Empresa) //Um funcionário está vinculado a uma empresa
                .WithMany(e => e.Funcionarios) //Uma empresa pode ter vários funcionários
                .HasForeignKey(f => f.IdEmpresa); //Chave estrangeira
        }
    }
}
