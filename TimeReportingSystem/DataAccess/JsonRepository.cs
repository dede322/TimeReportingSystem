using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class JsonRepository<T> : IRepository<T>
    {
        public JsonRepository(string fileName)
            : base(fileName)
        {
        }

        override public IEnumerable<T> GetAll()
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                T element;
                while (sr.EndOfStream == false)
                {
                    element = JsonConvert.DeserializeObject<T>(sr.ReadLine());
                    yield return element;
                }
            }
        }

        override public void Add(T element)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                var jsonElement = JsonConvert.SerializeObject(element);
                sw.WriteLine(jsonElement);
            }
        }

        override public void Delete(T element)
        {
            throw new NotImplementedException();
        }

        override public void Modify(T element)
        {
            throw new NotImplementedException();
        }
    }
}
