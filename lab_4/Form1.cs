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
                { new PriorityTesting(), new PriorityTesting(), new PriorityTesting(), new PriorityTesting(), new PriorityTesting() };
            Thread[] threads = new Thread[5];
            Int32 thrID = Thread.CurrentThread.ManagedThreadId;

            for (int n = 0; n < 5; n++)
            {
                threads[n] = new Thread(new ParameterizedThreadStart(inst[n].ThreadMethod));
            }

            threads[0].Priority = ThreadPriority.Lowest;
            threads[1].Priority = ThreadPriority.BelowNormal;
            threads[2].Priority = ThreadPriority.Normal;
            threads[3].Priority = ThreadPriority.AboveNormal;
            threads[4].Priority = ThreadPriority.Highest;

            for (int i = 0; i < 5; i++)
            {
                threads[i].Start(thrID);
            }

            Thread.Sleep(10000);

            for (int i = 0; i < 5; i++)
            {
                txt_debug.Text += $"ID потока: {threads[i].ManagedThreadId}\tЗначение счётчика: {inst[i].counter}\tПриоритет потока: {threads[i].Priority}\r\n";
                threads[i].Abort();
            }

            txt_debug.Text += "______________________________________________________________________\r\n";
        }
    }
}
