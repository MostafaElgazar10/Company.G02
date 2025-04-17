﻿using Company.G02.DAL.FOLDER_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.BLL.Interfaces
{
    public interface IGenaricRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T? Get(int id);

        int Add(T Model);
        int Update(T Model);
        int Delete(T Model);
    }
}
