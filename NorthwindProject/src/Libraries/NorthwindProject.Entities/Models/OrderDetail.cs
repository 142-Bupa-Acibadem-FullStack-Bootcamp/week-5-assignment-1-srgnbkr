using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindProject.Entities.Base;

#nullable disable

namespace NorthwindProject.Entities.Models
{
    public partial class OrderDetail : EntityBase
    {
        [Key]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
