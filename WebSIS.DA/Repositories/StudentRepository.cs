using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebSIS.BL.Models;
using WebSIS.DA.Context;
using WebSIS.DA.Repositories.Interfaces;

namespace WebSIS.DA.Repositories
{
    
  public  class StudentRepository:RepositoryBase<Entities.Students,StudentModel,Guid>,IStudentRepository
    {

        public StudentRepository(SISContext context,IMapper mapper):base(context,mapper)
        {

        }
    }
}
