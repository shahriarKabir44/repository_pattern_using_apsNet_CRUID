using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data ;
using repository_pattern.Models;
using System.Data.Entity;

namespace repository_pattern.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {

        InventoryDBEntities context = new InventoryDBEntities();
        public void Delete(int Id)
        {
            this.context.Set<T>().Remove(this.Get(Id));
            this.context.SaveChanges();
        }

        public T Get(int Id)
        {
            return this.context.Set<T>().Find(Id);
        }

        public List<T> GetAll()
        { 
            return this.context.Set<T>().ToList();

        }

        public void Insert(T entitty)
        {
            this.context.Set<T>().Add(entitty);
            this.context.SaveChanges();
        }

        public void Update(T entitty)
        {
            this.context.Entry(entitty).State = EntityState.Modified;
            this.context.SaveChanges();
        }
    }
}