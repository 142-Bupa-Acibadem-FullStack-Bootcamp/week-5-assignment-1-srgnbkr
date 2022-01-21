using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NorthwindProject.Entities.Base;

#nullable disable

namespace NorthwindProject.Entities.Models
{
    public partial class Region : EntityBase
    {
        
        [Key]

        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territory> Territories { get; set; }
    }
}
