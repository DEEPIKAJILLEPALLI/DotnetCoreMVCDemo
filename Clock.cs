using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreWebApplication1
{
    public class Clock : IClock
    {
        public DateTime GetTime()
        { 
            return  DateTime.Now;
        }
    }
}
