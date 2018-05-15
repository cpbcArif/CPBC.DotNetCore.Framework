using CPBC.DotNetCore.Common.Core;
using CPBC.DotNetCore.DAL.Core;
using System.Collections.Generic;

namespace CPBC.DotNetCore.BusinessLayer.Core
{
    public interface IActionManager
    {
        void Create(BaseEntity entity);
        void Update(BaseEntity entity);
        void Delete(BaseEntity entity);
        IEnumerable<BaseEntity> GetAll();
        IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// ??? Why
        /// </summary>
        void SaveChanges();
    }
}
