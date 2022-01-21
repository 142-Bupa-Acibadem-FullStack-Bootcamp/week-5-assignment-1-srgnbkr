using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindProject.Entities.DTOs;
using NorthwindProject.Entities.Models;
using NorthwindProject.Interfaces;
using NorthwindProject.WebAPI.Base;

namespace NorthwindProject.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeTerritoriesController : ApiBaseController<IEmployeeTerritoryService, EmployeeTerritory, DtoEmployeeTerritory>
    {
        public EmployeeTerritoriesController(IEmployeeTerritoryService service) : base(service)
        {
        }
    }
}