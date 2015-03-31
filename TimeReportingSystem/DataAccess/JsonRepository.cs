using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class JsonRepository<T> : Repository<T>
    {
        public JsonRepository(string fileName)
            : base(fileName)
        {
            elements = GetAll().ToList();   
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
            Elements.Add(element);
            saveToFile(fileName);
        }

        public override void Delete(T removedElement)
        {
            //IEnumerable<T> elements = GetAll();
            elements.Remove(removedElement); //Where(m => m.Equals(removedElement));
            saveToFile(fileName);
        }

        public override void Modify(T element)
        {
            throw new NotImplementedException();
        }

        private void saveToFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (T element in Elements)
                {
                    var jsonElement = JsonConvert.SerializeObject(element);
                    sw.WriteLine(jsonElement);
                }
            }
        }
    }
}
