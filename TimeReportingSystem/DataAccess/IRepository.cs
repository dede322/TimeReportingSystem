﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    interface IRepository <T>
    {
        IEnumerable<T> GetAll();
        void Add(T element);
        void Delete(T element);
        void Modify(T element);
    }
}
