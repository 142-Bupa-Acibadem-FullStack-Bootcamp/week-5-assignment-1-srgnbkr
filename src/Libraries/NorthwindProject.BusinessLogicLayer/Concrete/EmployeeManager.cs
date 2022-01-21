using NorthwindProject.BusinessLogicLayer.Base;
using NorthwindProject.Entities.DTOs;
using NorthwindProject.Entities.Models;
using NorthwindProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.BusinessLogicLayer.Concrete
{
    public class EmployeeManager : BusinessBase<Employee, DtoEmployee>, IEmployeeService
    {
        public EmployeeManager(IServiceProvider service) : base(service)
        {
        }
    }
}
