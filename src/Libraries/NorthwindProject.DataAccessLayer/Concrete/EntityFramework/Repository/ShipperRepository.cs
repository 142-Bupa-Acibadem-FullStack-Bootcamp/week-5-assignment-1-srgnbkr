using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthwindProject.DataAccessLayer.Abstract;
using NorthwindProject.Entities.Models;

namespace NorthwindProject.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class ShipperRepository : EntityRepositoryBase<Shipper>, IShipperRepository
    {
        public ShipperRepository(DbContext context) : base(context)
        {
        }
    }
}