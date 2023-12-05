using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesCurso.Models;

namespace SalesCurso.Data
{
    public class SalesCursoContext : DbContext
    {
        public SalesCursoContext (DbContextOptions<SalesCursoContext> options)
            : base(options)
        {
        }

        public DbSet<SalesCurso.Models.Department> Department { get; set; } = default!;
    }
}
