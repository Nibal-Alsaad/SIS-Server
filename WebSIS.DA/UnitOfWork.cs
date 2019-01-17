using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSIS.DA.Context;
using WebSIS.DA.Repositories;
using WebSIS.DA.Repositories.Interfaces;

namespace WebSIS.DA
{
    public class UnitOfWork : IUnitOfWork
    {
        SISContext _context;
        IMapper _mapper;
        public UnitOfWork(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            studentRepository = new StudentRepository(_context, _mapper);
            departmentCategoryRepository = new DepartmentCategoryRepository(_context, _mapper);
        }
        public IStudentRepository studentRepository { get; }

        public IDepartmentCategoryRepository departmentCategoryRepository { get; }

        public int commit()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
