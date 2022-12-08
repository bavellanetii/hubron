using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsInFullSpecification : BaseSpecification<Product>
    {
        public ProductsInFullSpecification()
        {
            AddInclude(x => x.Grade);
            AddInclude(x => x.LotNumber);
            AddInclude(x => x.Packaging);
            AddInclude(x => x.Status);
            AddInclude(x => x.Warehouse);
        }
    }
}