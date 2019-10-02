using System;
using System.Diagnostics;

namespace lab_4
{
    class PriorityTesting
    {
        //public Boolean finish; Не нужен, так как есть реализованное в классе Thread экземплярное свойство
        
        public Double counter = 0;

        public void ThreadMethod(Object thrID)
        {
            ProcessThread tempThr = Process.GetCurrentProcess().Threads[(Int32)thrID];

            while (tempThr.ThreadState != ThreadState.Terminated)
            {
                counter++;
            }
        }

    }
}
