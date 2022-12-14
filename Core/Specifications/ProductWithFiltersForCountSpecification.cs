using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParameters productParams)
            : base(x => 
                (!productParams.LotNumberId.HasValue || x.LotNumberId == productParams.LotNumberId) &&
                (!productParams.WarehouseId.HasValue || x.WarehouseId == productParams.WarehouseId) &&
                (!productParams.PackagingId.HasValue || x.PackagingId == productParams.PackagingId) &&
                (!productParams.StatusId.HasValue || x.StatusId == productParams.StatusId) &&
                (!productParams.GradeId.HasValue || x.GradeId == productParams.GradeId)
            )
        {
        }
    }
}