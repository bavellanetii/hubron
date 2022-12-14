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
        public ProductsInFullSpecification(ProductSpecParameters productParams)
            : base(x => 
                (!productParams.LotNumberId.HasValue || x.LotNumberId == productParams.LotNumberId) &&
                (!productParams.WarehouseId.HasValue || x.WarehouseId == productParams.WarehouseId) &&
                (!productParams.PackagingId.HasValue || x.PackagingId == productParams.PackagingId) &&
                (!productParams.StatusId.HasValue || x.StatusId == productParams.StatusId) &&
                (!productParams.GradeId.HasValue || x.GradeId == productParams.GradeId)
            )
        {
            AddInclude(x => x.Grade);
            AddInclude(x => x.LotNumber);
            AddInclude(x => x.Packaging);
            AddInclude(x => x.Status);
            AddInclude(x => x.Warehouse);
            
            AddOrderBy(x => x.Grade.Name);
            
            ApplyPaging(productParams.PageSize * (productParams.PageIndex -1), productParams.PageSize);

            if(!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
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