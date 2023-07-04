using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Decanting;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class DecantingRepository : IDecantingRepository
    {
        public Task<IReadOnlyList<Customer>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Order>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Transport>> GetTransportsAsync()
        {
            throw new NotImplementedException();
        }
    }
}