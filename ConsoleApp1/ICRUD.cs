using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICRUD <T>
    {
        List<T> Read();
       
        public void Create(T item);
       
        public void Update(T item);
     
        public void Delete(T item);

    }
}
