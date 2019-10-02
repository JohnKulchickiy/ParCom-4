using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Double[] counters = new Double[5];
            Thread[] threads = new Thread[5];

            for (int n = 0; n < 5; n++)
            {
                threads[n] = new Thread(() =>
                {
                    Int32 thrID = Thread.CurrentThread.ManagedThreadId;

                    PriorityTesting inst = new PriorityTesting();
                    //counters[n] = inst.counter;

                    inst.ThreadMethod(thrID);
                });
            }

            threads[0].Priority = ThreadPriority.Lowest;
            threads[1].Priority = ThreadPriority.BelowNormal;
            threads[2].Priority = ThreadPriority.Normal;
            threads[3].Priority = ThreadPriority.AboveNormal;
            threads[4].Priority = ThreadPriority.Highest;

            for (int i = 0; i < 5; i++)
            {
                threads[i].Start();
            }

            Thread.Sleep(10000);

            for (int i = 0; i < 5; i++)
            {
                txt_debug.Text += $"ID потока: {threads[i].ManagedThreadId}\tПриоритет потока: {threads[i].Priority}\t\tЗначение счётчика: {counters[i]}\r\n";
                threads[i].Abort();
            }
        }
    }
}
