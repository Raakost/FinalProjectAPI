using DLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public interface IRepository<T> where T : AbstractId
    {
        T Create(T t);

        List<T> ReadAll();

        T Get(int id);

        T Update(T t);

        bool Delete(T t);


    }
}
