using Microsoft.EntityFrameworkCore;
using ProjetoAquasis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCrud.Models
{
    public class FuncionarioContext : DbContext

    { 
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base (options)
        {

        }
        public DbSet<Funcionario> funcionarios { get; set; }
    }
}
