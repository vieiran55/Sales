using SalesCurso.Data;
using SalesCurso.Models;

namespace SalesCurso.Services
{
    public class DepartmentService
    {
        private readonly SalesCursoContext _context;

        public DepartmentService(SalesCursoContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
