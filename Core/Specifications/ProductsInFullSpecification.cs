using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsInFullSpecification : BaseSpecification<Product>
    {
        public ProductsInFullSpecification(string sort, int? lotNumberId, int? warehouseId, 
                                           int? packagingId, int? statusId, int? gradeId)
            : base(x => 
                (!lotNumberId.HasValue || x.LotNumberId == lotNumberId) &&
                (!warehouseId.HasValue || x.WarehouseId == warehouseId) &&
                (!packagingId.HasValue || x.PackagingId == packagingId) &&
                (!statusId.HasValue || x.StatusId == statusId) &&
                (!gradeId.HasValue || x.GradeId == gradeId)
            )
        {
            AddInclude(x => x.Grade);
            AddInclude(x => x.LotNumber);
            AddInclude(x => x.Packaging);
            AddInclude(x => x.Status);
            AddInclude(x => x.Warehouse);
            
            AddOrderBy(x => x.Grade.Name);
            
            

            if(!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "warehouse":
                        AddOrderBy(w => w.Warehouse.Name);
                        break;
                    case "lotNumberAscending":
                        AddOrderBy(l => l.LotNumber.Name);
                        break;
                    case "packaging":
                        AddOrderBy(p => p.Packaging.Name);
                        break;
                    case "status":
                        AddOrderBy(s => s.Status.Name);
                        break;
                    default:
                        AddOrderBy(x => x.Grade.Name);
                        break;
                }
            }
        }

        public ProductsInFullSpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.Grade);
            AddInclude(x => x.LotNumber);
            AddInclude(x => x.Packaging);
            AddInclude(x => x.Status);
            AddInclude(x => x.Warehouse);
        }
    }
}