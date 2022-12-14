using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class LotNumber : BaseEntity
    {
        public string Name { get; set; }
        public int BagCount { get; set; }
    }
}