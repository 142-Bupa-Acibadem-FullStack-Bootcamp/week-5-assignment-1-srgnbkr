using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthwindProject.DataAccessLayer.Abstract;
using NorthwindProject.Entities.DTOs;
using NorthwindProject.Entities.Models;



namespace NorthwindProject.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class OrderDetailRepository : EntityRepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(DbContext context) : base(context)
        {
        }
    }
}