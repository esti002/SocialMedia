using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void GenericAdd(T t);
        void GenericDelete(T t);
        void GenericUpdate(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
