using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JsonRepository<T> : IRepository<T>
    {
        public JsonRepository(string fileName)
            : base(fileName)
        {
        }

        public override IEnumerable<T> GetAll()
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

        public override  void Add(T element)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                var jsonElement = JsonConvert.SerializeObject(element);
                sw.WriteLine(jsonElement);
            }
        }

        public override void Delete(T element)
        {
            throw new NotImplementedException();
        }

        public override void Modify(T element)
        {
            throw new NotImplementedException();
        }
    }
}
