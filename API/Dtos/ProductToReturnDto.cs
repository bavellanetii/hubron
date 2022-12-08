using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductToReturnDto
    {
        public int Id { get; set; }
        public string Warehouse { get; set; }
        public string Grade { get; set; }
        public int? Weight { get; set; }
        public string LotNumber { get; set; }
        public int? BagNumber { get; set; }
        public string Packaging { get; set; }
        public int? DecantNote { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }
}