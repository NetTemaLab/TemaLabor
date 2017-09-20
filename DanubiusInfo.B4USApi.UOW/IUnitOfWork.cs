using System;
using System.Data.Entity;

namespace DanubiusInfo.B4USApi.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
