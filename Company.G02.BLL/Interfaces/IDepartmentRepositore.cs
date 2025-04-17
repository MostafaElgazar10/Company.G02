using Company.G02.DAL.FOLDER_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Interfaces
{
    public interface IDepartmentRepositore
    {
        IEnumerable<Department> GetAll();
        Department? Get(int id);

        int Add(Department Model);
        int Update(Department Model);
        int Delete(Department Model);
    }
}
