using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Mat_Discreta
{
    public class Stack
    {
        public int Max { get; set; }
        public int Top { get; set; }
        public int[] Items { get; set; }
        
        public Stack(int max)
        {
            Max = max;
            Items = new int[Max];
            Top = -1;
        }

        public bool IsEmpty()
        {
            return (Top < 0);
        }
        
        public bool Push(int data)
        {
            if (Top >= Max)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                Items[++Top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (Top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = Items[Top--];
                return value;
            }
        }

        public void Display()
        {
            if (Top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = Top; i >= 0; i--)
                {
                    Console.WriteLine(Items[i]);
                }
            }
        }
    }
}
