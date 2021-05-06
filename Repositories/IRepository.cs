using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository_pattern.Repositories
{
    interface IRepository<T> where T:class 
    {
        List<T> GetAll();
        T Get(int Id);
        void Insert(T entitty);
        void Update(T entitty);
        void Delete(int Id);
    }
}
