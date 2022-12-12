using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class LotNumber : BaseEntity
    {
        public string Name { get; set; }
        private string year;
        public string Year
        {
            get{return year; }
            set
            {
                year = Name.Substring(5);
            }
        }
        public int BagCount { get; set; }
        

    }
}