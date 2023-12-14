using SalesCurso.Data;
using SalesCurso.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesCurso.Services
{
    public class DepartmentService
    {
        private readonly SalesCursoContext _context;

        public DepartmentService(SalesCursoContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
