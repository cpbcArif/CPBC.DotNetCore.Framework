using System;
using System.Collections.Generic;
using System.Text;

namespace CPBC.DotNetCore.DAL.Core
{
    public interface IUnitOfWork
    {
        void BeginTransaction();    
        void RollbackTransaction();
        void CommitTransaction();
        void SaveChanges();
    }
}
