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
    /// Classe de mapeamento para a entidade Empresa
    /// </summary>
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            //nome da tabela no banco de dados
            builder.ToTable("EMPRESA");

            //chave primária da tabela
            builder.HasKey(e => e.IdEmpresa);

            //mapeamento dos campos
            builder.Property(e => e.IdEmpresa)
                .HasColumnName("IDEMPRESA");

            builder.Property(e => e.NomeFantasia)
                .HasColumnName("NOMEFANTASIA")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.RazaoSocial)
                .HasColumnName("RAZAOSOCIAL")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(e => e.Cnpj)
                .HasColumnName("CNPJ")
                .HasMaxLength(14)
                .IsRequired();

            builder.Property(e => e.DataHoraCadastro)
                .HasColumnName("DATAHORACADASTRO")
                .IsRequired();            
        }
    }
}
