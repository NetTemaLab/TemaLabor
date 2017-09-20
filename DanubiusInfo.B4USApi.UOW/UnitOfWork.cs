using DanubiusInfo.B4USApi.Data;
using System;

namespace DanubiusInfo.B4USApi.UOW
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private B4USContext dbContext;

        public UnitOfWork(B4USContext context)
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
                if (this.dbContext != null)
                {
                    this.dbContext.Dispose();
                    this.dbContext = null;
                }
            }
        }
    }
}
