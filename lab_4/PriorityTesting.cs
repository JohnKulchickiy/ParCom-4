using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class PriorityTesting
    {
        //public Boolean finish; Не нужен, так как есть реализованное в классе Thread экземплярное свойство
        private const System.Diagnostics.ThreadState abortSt = System.Diagnostics.ThreadState.Terminated;
        
        public Double counter = 0;

        public void ThreadMethod(Int32 thrID)
        {
            ProcessThread tempThr = Process.GetCurrentProcess().Threads[thrID];

            while (tempThr.ThreadState != abortSt)
            {
                counter++;
            }
        }

    }
}
