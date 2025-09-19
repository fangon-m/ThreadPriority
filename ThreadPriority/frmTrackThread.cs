using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadPriorityDemo;

namespace ThreadPriority
{
    public partial class frmTrackThread : Form
    {
        
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("THREAD STARTS");
            Thread threadA = new Thread(MyThreadClass.Thread1) { Name = "Thread A" };
            Thread threadB = new Thread(MyThreadClass.Thread2) { Name = "Thread B" };
            Thread threadC = new Thread(MyThreadClass.Thread1) { Name = "Thread C" };
            Thread threadD = new Thread(MyThreadClass.Thread2) { Name = "Thread D" };

            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("END OF THREAD");

            label1.Text = "END OF THREAD";
        }
    }
}
