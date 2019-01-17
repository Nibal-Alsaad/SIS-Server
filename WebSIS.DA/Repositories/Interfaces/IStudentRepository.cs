using System;
using System.Collections.Generic;
using System.Text;
using WebSIS.BL.Models;
using WebSIS.DA.Entities;

namespace WebSIS.DA.Repositories.Interfaces
{
  public interface IStudentRepository:IRepository<WebSIS.DA.Entities.Students,StudentModel,Guid>
    {
    }
}
