using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class MyNode123
    {
        public int Value { get; set; }

        public MyNode123 Next { get; set; }

        public MyNode123(int value, MyNode123 next = null)
        {
            Value = value;
            Next = next;
        }
    }
    public class MyStackForSort
    {
        private MyNode123 head;
        private int count;

        public MyStackForSort()
        {
            head = null;
            count = 0;
        }

        public bool StackIsEmpty()
        {
            return head == null;
        }

        //очищение стека
        public void Clear()
        {
            head = null;
            count = 0;
        }

        // добавление элемента в стек
        public void Push(int value)
        {
            MyNode123 new_element = new MyNode123(value, head);
            head = new_element;
            count++;
        }

        // взять элемент из стека
        public int Pop()
        {
            if (count == 0)
            {
                throw new Exception("Стек пуст");
            }
            else
            {
                int element = head.Value;
                head = head.Next;
                count--;
                return element;
            }

        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            MyNode123 p = head;
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
