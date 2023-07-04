using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Decanting;

namespace Core.Interfaces
{
    public interface IDecantingRepository
    {
        Task<Order> GetOrderByIdAsync(int id);
        Task<IReadOnlyList<Order>> GetOrdersAsync();
        Task<IReadOnlyList<Customer>> GetCustomersAsync();
        Task<IReadOnlyList<Transport>> GetTransportsAsync();
    }
}