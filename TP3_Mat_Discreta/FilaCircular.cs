using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Mat_Discreta
{
    public class FilaCircular
    {
        public int Size { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }
        public int[] Queue { get; set; }

        public FilaCircular(int size)
        {
            Size = size;
            Front = -1;
            Rear = -1;
            Queue = new int[Size];
        }

        public bool isFull()
        {
            if (Front == 0 && Rear == Size - 1)
            {
                return true;
            }
            if (Front == Rear + 1)
            {
                return true;
            }
            return false;
        }

        public bool isEmpty()
        {
            if (Front == -1)
                return true;
            else
                return false;
        }

        public void Insert(int element)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (Front == -1)
                    Front = 0;
                Rear = (Rear + 1) % Size;
                Queue[Rear] = element;
                Console.WriteLine("Inserted " + element);
            }
        }

        public int Remove()
        {
            int element;
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return (-1);
            }
            else
            {
                element = Queue[Front];
                if (Front == Rear)
                {
                    Front = -1;
                    Rear = -1;
                }
                else
                {
                    Front = (Front + 1) % Size;
                }
                return element;
            }
        }

        public void display()
        {
            int i;
            if (isEmpty())
            {
                Console.WriteLine("Empty Queue");
            }
            else
            {
                Console.WriteLine("Front : " + Front);
                Console.WriteLine("Items : ");
                for (i = Front; i != Rear; i = (i + 1) % Size)
                    Console.Write(Queue[i] + " ");
                Console.WriteLine(Queue[i]);
                Console.WriteLine("Rear : " + Rear);
            }
        }
    }
}
