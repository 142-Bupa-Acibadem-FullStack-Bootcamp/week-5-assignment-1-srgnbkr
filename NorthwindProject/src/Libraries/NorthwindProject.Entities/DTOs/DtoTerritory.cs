using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindProject.Entities.Base;

namespace NorthwindProject.Entities.DTOs
{
    public class DtoTerritory : DtoBase
    {
        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }
    }
}