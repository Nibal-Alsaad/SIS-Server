using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSIS.BL.Models;

namespace WebSIS.DA.Repositories.Interfaces
{
  public interface IDepartmentCategoryRepository:IRepository<WebSIS.DA.Entities.DepartmentsCategories,DepartmentCategoryModel, Guid>
    {

    }
}
