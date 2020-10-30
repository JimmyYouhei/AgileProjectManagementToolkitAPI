using AgileProjectManagement.AbstractClass;
using AgileProjectManagement.Context;
using AgileProjectManagement.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileProjectManagement.Repository
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {

        internal ProjectDbContext dbContext;

        internal DbSet<T> dbSet;

        public BaseRepository(ProjectDbContext context)
        {
            dbContext = context;
            dbSet = dbContext.Set<T>();
        }

        public virtual T CreateElement(T element)
        {
            return dbContext.Set<T>().Add(element).Entity;
        }

        public virtual void DeleteElement(long id)
        {
            var deleteElement = dbContext.Set<T>().Find(id);
            dbContext.Set<T>().Remove(deleteElement);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual T GetById(long id)
        {
            return dbSet.FirstOrDefault();
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public T UpdateElement(T element)
        {
            return dbSet.Update(element).Entity;
        }
    }
}
