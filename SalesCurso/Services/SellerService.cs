using SalesCurso.Data;
using SalesCurso.Models;

namespace SalesCurso.Services
{
    public class SellerService
    {
        private readonly SalesCursoContext _context;

        public SellerService(SalesCursoContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
