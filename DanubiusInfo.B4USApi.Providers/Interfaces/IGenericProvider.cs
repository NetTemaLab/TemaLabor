using DanubiusInfo.B4USApi.Data.Model;
using System.Collections.Generic;

namespace DanubiusInfo.B4USApi.Providers.Interfaces
{
    public interface IGenericProvider<T> where T : Entity
    {
        T Add(T entity);
        IEnumerable<T> GetAll();
        void Save();
    }
}
