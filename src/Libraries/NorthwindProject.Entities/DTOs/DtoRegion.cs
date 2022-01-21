using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindProject.Entities.Base;

namespace NorthwindProject.Entities.DTOs
{
    public class DtoRegion : DtoBase
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }
    }
}