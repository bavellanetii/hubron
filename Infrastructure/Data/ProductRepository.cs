using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return await _context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<IReadOnlyList<Warehouse>> GetWarehousesAsync()
        {
            return await _context.Warehouses.ToListAsync();
        }

        public async Task<IReadOnlyList<Grade>> GetGradesAsync()
        {
            return await _context.Grades.ToListAsync();
        }
    }
}