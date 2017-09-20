using System;
using System.Data.Entity;

namespace DanubiusInfo.B4USApi.UOW
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private DbContext dbContext;

        public UnitOfWork(DbContext context)
        {
            this.dbContext = context;
        }

        public int Commit()
        {
            return this.dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(this.dbContext != null)
                {
                    this.dbContext.Dispose();
                    this.dbContext = null;
                }
            }
        }
    }
}
