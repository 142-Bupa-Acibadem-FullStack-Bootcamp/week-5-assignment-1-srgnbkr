using NorthwindProject.Entities.Models;
using NorthwindProject.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Interfaces
{
    public interface ICategoryService : IGenericService<Category, DtoCategory>
    {
    }
}
