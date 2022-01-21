using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthwindProject.DataAccessLayer.Abstract;
using NorthwindProject.Entities.Models;

namespace NorthwindProject.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EmployeeTerritoryRepository : EntityRepositoryBase<EmployeeTerritory>, IEmployeeTerritoryRepository
    
    {
        public EmployeeTerritoryRepository(DbContext context) : base(context)
        {
        }
    }
}