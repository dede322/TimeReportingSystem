using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class Repository<T>
    {
        protected string fileName;
        protected IList<T> elements;
        public IList<T> Elements 
        {
            get { return elements; }
        }

        public Repository(string fileName)
        {
            this.fileName = fileName;
            elements = new List<T>();
        }

        public abstract IEnumerable<T> GetAll();
        public abstract void Add(T element);
        public abstract void Delete(T element);
        public abstract void Modify(T element);
    }
}
