using Company.G02.BLL.Interfaces;
using Company.G02.DAL.Data.DBContexts;
using Company.G02.DAL.FOLDER_Models;
using Company.G02.DAL.FOLDER_Models.ModelEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Repositories
{
    public class EmployeeRepositore : GenaricRepository<Employee> , IEmployeeRepository
    {
        public EmployeeRepositore(CompanyDBContext context) : base(context) 
        {
            
        }

        public List<Employee> GetEmployeeBySearchValue(string searchValue)
        {
            throw new NotImplementedException();
        }
    }
}
