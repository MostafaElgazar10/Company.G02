using Company.G02.BLL.Interfaces;
using Company.G02.DAL.Data.DBContexts;
using Company.G02.DAL.FOLDER_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Repositories
{
    public class DepartmentRepository : GenaricRepository<Department> , IDepartmentRepository
    {
        public DepartmentRepository(CompanyDBContext context) : base (context) 
        {
            
        }


    }
}
