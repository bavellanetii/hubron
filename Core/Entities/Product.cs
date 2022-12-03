using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        public ProductName ProductName { get; set; }
        public int ProductNameId { get; set; }
        public string LotNumber { get; set; }
        public int BagNumber { get; set; }
        public int Weight { get; set; }
        public Warehouse Warehouse { get; set; }
        public int WarehouseId { get; set; }
        public string DecantNote { get; set; }
        public string Packaging { get; set; }
        public string Status { get; set; }
        public string  Notes { get; set; }
        
    }
}