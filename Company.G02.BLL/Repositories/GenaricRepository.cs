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
    public class GenaricRepository<T> : IGenaricRepository<T> where T : BaseEntity
    {
        private readonly CompanyDBContext _Context;

        //ASK CLR Create Object From CompanyDBContext
        public GenaricRepository(CompanyDBContext context)
        {
            _Context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }
        public T? Get(int id)
        {
            return _Context.Set<T>().Find(id);

        }
        public int Add(T Model)
        {

            _Context.Set<T>().Add(Model);
            return _Context.SaveChanges();
        }
        public int Update(T Model)
        {
            _Context.Set<T>().Update(Model);
            return _Context.SaveChanges();
        }
        public int Delete(T Model)
        {
            _Context.Set<T>().Remove(Model);
            return _Context.SaveChanges();
        }
    }


}
/*
 *   private readonly CompanyDBContext _Context;

        //ASK CLR Create Object From CompanyDBContext
        public GenaricRepository(CompanyDBContext context)
        {
            _Context = context;
        }
        public IEnumerable<T> GetAll()
        {
            return _Context.Set<T>().ToList();
        }
        public T? Get(int id)
        {
            return _Context.Set<T>().Find(id);

        }
        public int Add(T Model)
        {

            _Context.Set<T>().Add(Model);
            return _Context.SaveChanges();
        }
        public int Update(T Model)
        {
            _Context.Set<T>().Update(Model);
            return _Context.SaveChanges();
        }
        public int Delete(T Model)
        {
            _Context.Set<T>().Remove(Model);
            return _Context.SaveChanges();
        }
 */