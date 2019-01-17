using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSIS.BL.Models;
using WebSIS.DA.Context;
using WebSIS.DA.Repositories.Interfaces;

namespace WebSIS.DA.Repositories
{
   public class DepartmentCategoryRepository:RepositoryBase<WebSIS.DA.Entities.DepartmentsCategories,DepartmentCategoryModel,Guid>, IDepartmentCategoryRepository
    {
        SISContext _context;
        IMapper _mapper;
        public DepartmentCategoryRepository(SISContext context ,IMapper mapper):base(context,mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async override Task<DepartmentCategoryModel> GetAsync(Guid id)
        {
            var departmentCategory = await _context.DepartmentsCategories.FindAsync(id);
            await _context.Entry(departmentCategory)
           .Collection(category => category.Departments).LoadAsync();
            return _mapper.Map<DepartmentCategoryModel>(departmentCategory);
        }
    }
}
