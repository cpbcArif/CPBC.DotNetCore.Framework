using System;
using System.Collections.Generic;
using System.Text;
using CPBC.DotNetCore.Common.Core;
using CPBC.DotNetCore.Common.Entities;
using CPBC.DotNetCore.DAL.Core;

namespace CPBC.DotNetCore.BusinessLayer.Managers.QuestionBankManagement
{
    public class QuestionBankManager : IQuestionBankManager
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Create(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuestionBank> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuestionBank> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
