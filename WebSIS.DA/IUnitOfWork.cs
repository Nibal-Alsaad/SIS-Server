using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebSIS.DA.Repositories.Interfaces;

namespace WebSIS.DA
{
   public interface IUnitOfWork
    {
        IStudentRepository studentRepository { get; }
        IDepartmentCategoryRepository departmentCategoryRepository { get; }
        int commit();
        Task<int> CommitAsync();
        void Dispose();
    }
}
