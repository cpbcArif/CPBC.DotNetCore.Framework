using CPBC.DotNetCore.BusinessLayer.Core;
using CPBC.DotNetCore.Common.Core;
using CPBC.DotNetCore.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPBC.DotNetCore.BusinessLayer.Managers.QuestionBankManagement
{
    public interface IQuestionBankManager: IActionManager
    {
        IEnumerable<QuestionBank> Get(int Id);

        IEnumerable<QuestionBank> GetAllActive();
    }
}
