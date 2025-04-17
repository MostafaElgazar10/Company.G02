using Company.G02.DAL.FOLDER_Models;
using Company.G02.DAL.FOLDER_Models.ModelEmployees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Interfaces
{
    public interface IEmployeeRepository :IGenaricRepository<Employee>
    {
      List<Employee> GetEmployeeBySearchValue(string searchValue);
    }
}
