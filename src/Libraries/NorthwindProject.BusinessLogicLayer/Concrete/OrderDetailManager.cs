using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindProject.BusinessLogicLayer.Base;
using NorthwindProject.Entities.DTOs;
using NorthwindProject.Entities.Models;
using NorthwindProject.Interfaces;

namespace NorthwindProject.BusinessLogicLayer.Concrete
{
    public class OrderDetailManager : BusinessBase<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public OrderDetailManager(IServiceProvider service) : base(service)
        {
        }
    }
}