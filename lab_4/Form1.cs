using System;
using System.Threading;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_FreeThread_Click(object sender, EventArgs e)
        {
            PriorityTesting[] inst = new PriorityTesting[5]
                { new PriorityTesting(), new PriorityTesting(), new PriorityTesting(), new PriorityTesting(), new PriorityTesting() }; // Объявляем и инициализируем массив типа PriorityTesting 
            Thread[] threads = new Thread[5]; //Объявляем массив потоков 

            for (int n = 0; n < 5; n++)
            {
                threads[n] = new Thread(new ParameterizedThreadStart(inst[n].ThreadMethod)); // Делегируем экземплярный метод из нашего типа в поток
            }

            //Задаем приоритеты
            threads[0].Priority = ThreadPriority.Lowest;
            threads[1].Priority = ThreadPriority.BelowNormal;
            threads[2].Priority = ThreadPriority.Normal;
            threads[3].Priority = ThreadPriority.AboveNormal;
            threads[4].Priority = ThreadPriority.Highest;

            //Поочерёдно стартуем потоки
            foreach (Thread thr in threads)
            {
                thr.Start(thr.ManagedThreadId);
            }

            //Даём главному потоку отдохнуть, он и так у нас бедный 
            Thread.Sleep(10000);

            //Поочередно выводим информацию о потоках и кол-во выполненых операций 
            for (int i = 0; i < 5; i++)
            {
                txt_debug.Text += $"ID потока: {threads[i].ManagedThreadId}\tЗначение счётчика: {inst[i].counter}\tПриоритет потока: {threads[i].Priority}\r\n";
                threads[i].Abort();
            }

            txt_debug.Text += "______________________________________________________________________\r\n";
        }
    }
}
