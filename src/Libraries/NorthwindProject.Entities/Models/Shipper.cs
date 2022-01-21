using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NorthwindProject.Entities.Base;

#nullable disable

namespace NorthwindProject.Entities.Models
{
    public partial class Shipper : EntityBase
    {
       
        [Key]

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
