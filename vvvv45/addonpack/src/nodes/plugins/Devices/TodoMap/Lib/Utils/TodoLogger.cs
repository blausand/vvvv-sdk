using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VVVV.Core.Logging;

namespace VVVV.TodoMap.Lib.Utils
{
    public class TodoLogger : ILogger
    {
        //TodoEngine todoEngine;
        public TodoLogger() {
            DebugLogger me = new DebugLogger();
            me.Log(LogType.Debug,"Guten MOrgen");
        }
        //void 
    }
}
