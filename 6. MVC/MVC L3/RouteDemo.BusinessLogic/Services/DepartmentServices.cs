using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route.Demo.DataAccess.Repositories.DepartmentRepo;
using RouteDemo.BusinessLogic.DataTransferObject;


namespace RouteDemo.BusinessLogic.Services
{
    class DepartmentServices(IDepartmentRepository departmentRepository)
    {
        // 1.0 Injection : CLR will understand that we need in inject DepartmentRepsoitoty, but it can not do it
        // we need to add services in services container in program.cs

        // Get All Departments
        public IEnumerable<DepartmentDto> GetAllDepartments()
        {
            var Departments = departmentRepository.GetAll();

            var departmentToReturns = Departments.Select(D => new DepartmentDto() // Mapping
            {
                DepartmentId = D.Id,
                Name = D.Name,
                Code = D.Code, 
                Description = D.Description,
                DateOfCreation = DateOnly.FromDateTime(D.CreatedOn)
            });

            return departmentToReturns;
        }

        public DepartmentDetialsDto? GetDepartmentById(int id)
        {
            var department = departmentRepository.GetById(id);

            // Mapper
            if (department is null) return null;
            else
            {
                var departmentToReturn = new DepartmentDetialsDto()
                {
                    Id = department.Id,
                    CreatedBy = department.CreatedBy,
                    CreatedOn = DateOnly.FromDateTime(department.CreatedOn),
                    LastModifedBy
                };
            }
        }
     }
}
