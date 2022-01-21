using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NorthwindProject.Entities.Base;

#nullable disable

namespace NorthwindProject.Entities.Models
{
    public partial class CustomerCustomerDemo : EntityBase
    {
        [Key]
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}
