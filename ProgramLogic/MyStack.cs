﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class MyNode
    {
        public char Value { get; set; }

        public MyNode Next { get; set; }

        public MyNode(char value, MyNode next = null)
        {
            Value = value;
            Next = next;
        }
    }
    public class MyStack
    {
        private MyNode head;
        private int count;

        public MyStack()
        {
            head = null;
            count = 0;
        }

        //очищение стека
        public void Clear()
        {
            head = null;
            count = 0;
        }

        // добавление элемента в стек
        public void Push(char value)
        {
            MyNode new_element = new MyNode(value, head);
            head = new_element;
            count++;
        }
        
        // взять элемент из стека
        public char Pop()
        {
            if (count == 0)
            {
                throw new Exception("Стек пуст");
            }
            else
            {
                char element = head.Value;
                head = head.Next;
                count--;
                return element;
            }

        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            MyNode p = head;
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
