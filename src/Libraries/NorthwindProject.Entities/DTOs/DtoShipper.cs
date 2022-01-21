using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindProject.Entities.Base;

namespace NorthwindProject.Entities.DTOs
{
    public class DtoShipper : DtoBase
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        
    }
}