﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NorthwindProject.Entities.Base;

#nullable disable

namespace NorthwindProject.Entities.Models
{
    public partial class Order : EntityBase
    {
         public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [ForeignKey("ShipViaNavigSation")]
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? ShipVia { get; set; }
        public decimal? Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Shipper ShipViaNavigSation { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
