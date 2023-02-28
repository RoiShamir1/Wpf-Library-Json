using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FinalManager
{
    public abstract class LogBase
    {
        public abstract void WriteLog(string message);
    }
}
