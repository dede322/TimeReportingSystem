using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class JsonRepository<T> :IRepository<T>
    {
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Add(T element)
        {
            throw new NotImplementedException();
        }

        public void Delete(T element)
        {
            throw new NotImplementedException();
        }

        public void Modify(T element)
        {
            throw new NotImplementedException();
        }
    }
}
