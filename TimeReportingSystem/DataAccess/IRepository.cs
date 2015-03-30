using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class IRepository<T>
    {
        protected string fileName;

        public IRepository(string fileName)
        {
            this.fileName = fileName;
        }
        abstract public IEnumerable<T> GetAll();
        abstract public void Add(T element);
        abstract public void Delete(T element);
        abstract public void Modify(T element);
    }
}
