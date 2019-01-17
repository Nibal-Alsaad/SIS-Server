using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSIS.BL.Models;
using WebSIS.DA;

namespace WebSIS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentCategoryController : Controller
    {
        IUnitOfWork _unitOfWork;
        public DepartmentCategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet("/api/DepartmentCategory/DepartmentsCatergories")]
        public async Task<IActionResult> GetAllDepartmentsCatergories()
        {
            var data =await _unitOfWork.departmentCategoryRepository.GetAllAsync();
              if (data == null)
            {
                return BadRequest("no data");
            }
            return Ok(data);
        }
        [HttpGet("/api/DepartmentCategory/{id}")]
        public async Task<IActionResult> GetDepartmentCategory(Guid id)
        {
            var data = await _unitOfWork.departmentCategoryRepository.GetAsync(id);
              if (data == null)
            {
                return BadRequest("no data");
            }
            return Ok(data);
        }

        [HttpPost("/api/DepartmentCategory/Add")]
        public  async Task<IActionResult> AddDepartmentCategory([FromBody] DepartmentCategoryModel categoryModel)
        {
            try
            {
                if (categoryModel == null)
                return BadRequest("parameter not exist");

                await _unitOfWork.departmentCategoryRepository.AddAsync(categoryModel);
                _unitOfWork.commit();
                return Ok();
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        [HttpPut("/api/DepartmentCategory/Edit")]
        public async Task<IActionResult> EditDepartmentCategory([FromBody] DepartmentCategoryModel categoryModel)
        {
            if (categoryModel == null)
            return BadRequest("parameter not exist");

            _unitOfWork.departmentCategoryRepository.UpdateItem(categoryModel);
            _unitOfWork.commit();
            return Ok();

        }

        [HttpPost("/api/DepartmentCategory/Delete")]
        public async Task<IActionResult> DeleteDepartmentCategory([FromBody] DepartmentCategoryModel categoryModel)
        {
            if (categoryModel == null)
                return BadRequest("parameter not exist");

            _unitOfWork.departmentCategoryRepository.RemoveItem(categoryModel);
            _unitOfWork.commit();
            return Ok();

        }

    }
}