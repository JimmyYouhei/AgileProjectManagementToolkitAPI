using AgileProjectManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.AbstractClass
{
    public abstract class BaseService<T> : IProjectService<T> where T : class, IEntity
    {

        internal IRepository<T> repository;

        public BaseService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public virtual T CreateElement(T element)
        {

            var created =  repository.CreateElement(element);
            repository.SaveChanges();
            return created;
        }

        public virtual void DeleteElement(long id)
        {
            repository.DeleteElement(id);
            repository.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return repository.GetAll();
        }

        public virtual T GetById(long id)
        {
            return repository.GetById(id);
        }

        public virtual T UpdateElement(T element)
        {
            var updatedElement = repository.UpdateElement(element);
            repository.SaveChanges();
            return updatedElement;
        }
    }
}
