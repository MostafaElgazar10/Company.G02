using Company.G02.BLL.Interfaces;
using Company.G02.DAL.DBcontexts;
using Company.G02.DAL.FOLDER_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepositore
    {
        private readonly CompanyDBContext _Context;
        public DepartmentRepository ()
        {
            _Context = new CompanyDBContext ();
        }
        public IEnumerable<Department> GetAll()
        {
           return _Context.Departments.ToList ();
        }
        public Department? Get(int id)
        {
            return _Context.Departments.Find (id);

        }
        public int Add(Department Model)
        {
          
              _Context.Departments.Add (Model);
            return _Context.SaveChanges();
        }
        public int Update(Department Model)
        {
            _Context.Departments.Update(Model);
            return _Context.SaveChanges();
        }
        public int Delete(Department Model)
        {
            _Context.Departments.Remove(Model);
            return _Context.SaveChanges();
        }

       
    }
}
