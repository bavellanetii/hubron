using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Decanting
{
    public class Decanting : BaseEntity
    {
        public DateOnly ProductionDate { get; set; }
        public DateOnly DespatchDate { get; set; }
        public Customer Customer { get; set; }
        public int? CustomerId { get; set; }
        public Grade Grade { get; set; }
        public int? GradeId { get; set; }
        public Packaging Packaging { get; set; }
        public int? PackagingId { get; set; }
        public Transport Transport { get; set; }   
        public int? TransportId { get; set; }
        public int TotalWeight { get; set; }
        public string Notes { get; set; }
    }
}