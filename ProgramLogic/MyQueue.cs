using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class MyQueue
    {
        private MyList head { get; set; }
        private MyList tail;
        public int count { get; private set; }

        public MyQueue()
        {
            head = null;
            tail = null;
            count = 0;
        }

        //очищение очереди
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // добавление элемента в очередь
        public void Push(double value)
        {
            MyList node = new MyList(value, null);
            if (head != null)
            {
                tail.Next = node;
                tail = node;
                
            }
            else
            {
                head = node;
                tail = node;
            }
            count++;
        }
        
        // взять из очереди
        public double Pop()
        {
            if (count == 0)
            {
                throw new Exception("Очередь пуста");
            }
            else
            {
                double element = head.Value;
                head = head.Next;
                count--;
                return element;
            }

        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            MyList p = head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.Value.ToString();
                p = p.Next;
            }
            return st;
        }
    }
}
