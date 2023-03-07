using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiFuncionarios.Data.Entities;
using ApiFuncionarios.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncionarios.Data.Contexts
{
    /// <summary>
    /// Classe para conexão com o banco de dados através do EF
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método para mapear a string de conexão do banco de dados no EF
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD_ApiFuncionarios;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        /// <summary>
        /// Método para adicionarmos as classes de mapeamento do projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
        }

        /// <summary>
        /// Propriedade para fornecer os métodos de CRUD para Empresa
        /// </summary>
        public DbSet<Empresa> Empresas { get; set; }

        /// <summary>
        /// Propriedade para fornecer os métodos de CRUD para Funcionario
        /// </summary>
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
