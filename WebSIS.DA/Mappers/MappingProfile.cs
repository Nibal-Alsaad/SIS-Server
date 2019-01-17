using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebSIS.BL.Models;
using WebSIS.DA.Entities;

namespace WebSIS.DA.Mappers
{
   public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<DepartmentCategoryModel, DepartmentsCategories>();
            CreateMap<DepartmentsCategories, DepartmentCategoryModel>();
        }
               
    }
}
