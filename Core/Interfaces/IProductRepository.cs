using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<Warehouse>> GetWarehousesAsync();
        Task<IReadOnlyList<Grade>> GetGradesAsync();
        Task<IReadOnlyList<LotNumber>> GetLotNumbersAsync();
        Task<IReadOnlyList<Status>> GetStatusesAsync();
        Task<IReadOnlyList<Packaging>> GetPackagingAsync();

    }
}