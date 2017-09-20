using DanubiusInfo.B4USApi.Data.Model;
using DanubiusInfo.B4USApi.Providers.Interfaces;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using DanubiusInfo.B4USApi.Data;

namespace DanubiusInfo.B4USApi.Providers
{
    public abstract class GenericProvider<T> : IGenericProvider<T>
        where T : Entity
    {
        protected DbContext entities;
        protected readonly DbSet<T> dbset;

        public GenericProvider(B4USContext context)
        {
            this.entities = context;
            this.dbset = context.Set<T>();
        }

        public T Add(T entity)
        {
            var newEntity = this.dbset.Add(entity);
            return newEntity;
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbset.AsEnumerable();
        }

        public void Save()
        {
            this.entities.SaveChanges();
        }
    }
}
