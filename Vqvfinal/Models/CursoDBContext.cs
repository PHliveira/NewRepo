using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vqvfinal.Models
{
    public class CursoDBContext : DbContext

    {

        public CursoDBContext(DbContextOptions<CursoDBContext> options) :
        base(options)
        { }
        public DbSet<Cursovqv> curso { get; set; }// curso é nome do banco de dados (cursovqv) a tabela
    }
}
