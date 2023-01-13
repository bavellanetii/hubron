using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductSpecParameters
    {
        private const int MaxPageSize = 100;
        public int PageIndex {get; set;} = 1;

        private int _pageSize = 30; 
        public int PageSize
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
        public int? LotNumberId { get; set; }
        public int? WarehouseId { get; set; }
        public int? PackagingId { get; set; }
        public int? StatusId { get; set; }
        public int? GradeId { get; set; }
        public string Sort { get; set; }
        private string _search;
        public string Search 
        {   
            get => _search;
            set => _search = value.ToLower();
        }
    }
}