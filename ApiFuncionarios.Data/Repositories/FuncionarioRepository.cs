using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiFuncionarios.Data.Contexts;
using ApiFuncionarios.Data.Entities;
using ApiFuncionarios.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiFuncionarios.Data.Repositories
{
    /// <summary>
    /// Repositório de dados para Funcionario
    /// </summary>
    public class FuncionarioRepository : IRepository<Funcionario>
    {
        public void Add(Funcionario entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Funcionarios.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Update(Funcionario entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public void Delete(Funcionario entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Funcionarios.Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public List<Funcionario> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Funcionarios
                    .Include(f => f.Empresa)
                    .OrderBy(f => f.Nome)
                    .ToList();
            }
        }

        public Funcionario GetById(Guid? id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Funcionarios
                    .Include(f => f.Empresa)
                    .Where(f => f.IdFuncionario == id)
                    .FirstOrDefault();
            }
        }
    }
}
