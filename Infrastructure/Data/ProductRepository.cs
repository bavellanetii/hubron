using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly WarehouseContext _context;
        public ProductRepository(WarehouseContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products
                .Include(g => g.Grade)
                .Include(w => w.Warehouse)
                .Include(l => l.LotNumber)
                .Include(p => p.Packaging)
                .Include(s => s.Status)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
                .Include(g => g.Grade)
                .Include(w => w.Warehouse)
                .Include(l => l.LotNumber)
                .Include(p => p.Packaging)
                .Include(s => s.Status)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Warehouse>> GetWarehousesAsync()
        {
            return await _context.Warehouses.ToListAsync();
        }

        public async Task<IReadOnlyList<Grade>> GetGradesAsync()
        {
            return await _context.Grades.ToListAsync();
        }

        public async Task<IReadOnlyList<LotNumber>> GetLotNumbersAsync()
        {
            return await _context.LotNumbers.ToListAsync();
        }

        public async Task<IReadOnlyList<Status>> GetStatusesAsync()
        {
            return await _context.Statuses.ToListAsync();
        }

        public async Task<IReadOnlyList<Packaging>> GetPackagingAsync()
        {
            return await _context.Packaging.ToListAsync();
        }
    }
}