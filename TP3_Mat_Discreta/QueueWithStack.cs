using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Mat_Discreta
{
    public class QueueWithStack
    {
        public System.Collections.Stack s1 = new (10);
        public System.Collections.Stack s2 = new (10);

        public void enQueue(int x)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }

            s1.Push(x);

            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public int deQueue()
        {
            if (s1.Count == 0)
            {
                Console.WriteLine("Queue is Empty");
            }

            int x = (int)s1.Peek();
            s1.Pop();
            return x;
        }
    }
}
