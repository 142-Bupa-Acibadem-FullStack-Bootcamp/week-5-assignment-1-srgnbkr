using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindProject.Entities.Base;

namespace NorthwindProject.Entities.DTOs
{
    public class DtoEmployeeTerritory : DtoBase
    {
        public int EmployeeId { get; set; }
        public string TerritoryId { get; set; }
        
    }
}