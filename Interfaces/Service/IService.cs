using AgileProjectManagement.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Interfaces
{
    public interface IProjectService<T> where T : IEntity
    {
        IEnumerable<T> GetAll();

        T GetById(long id);

        void DeleteElement(long id);

        T UpdateElement(T element);

        T CreateElement(T element);

    }
}
