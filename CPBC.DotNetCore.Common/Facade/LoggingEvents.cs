using System;
using System.Collections.Generic;
using System.Text;


/*
 * Source: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-2.1&tabs=aspnetcore2x
 */

namespace CPBC.DotNetCore.Common.Facade
{
    public class LoggingEvents
    {
        public const int GenerateItems = 1000;
        public const int ListItems = 1001;
        public const int GetItem = 1002;
        public const int InsertItem = 1003;
        public const int UpdateItem = 1004;
        public const int DeleteItem = 1005;

        public const int GetItemNotFound = 4000;
        public const int UpdateItemNotFound = 4001;
    }
}
