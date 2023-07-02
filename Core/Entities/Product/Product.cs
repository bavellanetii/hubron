using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public Warehouse Warehouse { get; set; }
        public int? WarehouseId { get; set; }
        public Grade Grade { get; set; }
        public int? GradeId { get; set; }
        public int? Weight { get; set; }
        public LotNumber LotNumber { get; set; }
        public int? LotNumberId { get; set; }
        public int? BagNumber { get; set; }
        public Packaging Packaging { get; set; }
        public int? PackagingId { get; set; }
        public int? DecantNote { get; set; }
        public Status Status { get; set; }
        public int? StatusId { get; set; }
        public string Notes { get; set; }

    }
}