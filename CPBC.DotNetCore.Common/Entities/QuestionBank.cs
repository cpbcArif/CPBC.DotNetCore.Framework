using CPBC.DotNetCore.Common.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CPBC.DotNetCore.Common.Entities
{
    public class QuestionBank : BaseEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int MasterItemId { get; set; }
        public QuestionBank MasterItem { get; set; }
        public bool IsMaster { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
