using System;
using System.Diagnostics;

namespace lab_4
{
    class PriorityTesting
    {
        //public Boolean finish; Не нужен, так как есть реализованное в классе Thread экземплярное свойство
        
        public Double counter = 0; // Экземплярный каунтер

        public void ThreadMethod(Object thrID)
        {
            ProcessThread tempThr = Process.GetCurrentProcess().Threads[(Int32)thrID]; // Находим наш поток через все потоки исполняемого программой процесса 

            while (tempThr.ThreadState != ThreadState.Terminated) // Инкриментируем каунтер до завершения работы потока 
            {
                counter++;
            }
        }

    }
}
