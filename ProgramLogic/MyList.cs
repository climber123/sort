using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class MyList
    {
        public double Value { get; set; }

        public MyList Next { get; set; }

        public MyList(double value = 0, MyList next = null)
        {
            Value = value;
            Next = next;
        }      
    }

    public class RealList
    {
        private MyList head;
        public int count { get; private set; }


        
        public RealList()
        {
            head = null;
            count = 0;
        }

        //добавление элемента в начало
        public void Add_First(int value)
        {
            MyList node = new MyList(value, head);
            head = node;
            count++;
        }

        //очищение списка
        public void Clear()
        {
            head = null;
            count = 0;
        }

        // Вывод списка
        public string[] Printer()                  
        {
            string[] st = new string[0];
            int L = 0;
            MyList node = head;
            if (node != null)
                do
                {
                    Array.Resize<string>(ref st, ++L);
                    st[L - 1] = node.Value.ToString();
                    node = node.Next;
                }
                while (node != null);
            return st;
        }

        //вставка последнего элемента
        public void Last(int value)
        {
            if (head != null)
            {
                MyList tail = new MyList();
                for (MyList node = head; node != null; node = node.Next)
                {
                    tail = node;
                }
                count++;
                tail.Next = new MyList(value, null);
            }
            else Add_First(value);   
        }

        //проверка на возрастание или убывание
        public int IsIncrease()
        {
            int d = 0;
            int n = 0;
            double a = head.Value;
            //bool inc, dec;
            for (MyList node = head; node != null; node = node.Next)
            {
                if (node.Value >= a)
                    n++;
                else if (node.Value <= a) 
                    d++;
                a = node.Value;
            }
            if (n == count) return 1;
            else if (d == count - 1) return -1;
            else return 0;
                
        }

        //обращение по индексу
        public double this[int index]
        {
            get
            {
                MyList node = head;
                for (int i = 0; i < index; i++)
                {
                    if (node.Next == null)
                        throw new Exception();
                    else
                        node = node.Next;
                    
                }
                return node.Value;
            }
            set
            {
                MyList node = head;
                for (int i = 0; i < index; i++)
                {
                    if (head.Next == null)
                        throw new Exception();
                    else
                        node = node.Next;

                }
                node.Value = value;
            }
        }

    }
}
