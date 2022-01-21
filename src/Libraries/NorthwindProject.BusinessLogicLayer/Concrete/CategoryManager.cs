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
    public class CategoryManager : BusinessBase<Category, DtoCategory>, ICategoryService
    {
        public CategoryManager(IServiceProvider service) : base(service)
        {
        }
    }
}
