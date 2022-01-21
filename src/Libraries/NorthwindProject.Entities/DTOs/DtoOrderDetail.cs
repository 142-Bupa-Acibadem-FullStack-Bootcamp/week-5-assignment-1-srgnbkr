using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindProject.Entities.Base;

namespace NorthwindProject.Entities.DTOs
{
    public class DtoOrderDetail : DtoBase
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        
    }
}

