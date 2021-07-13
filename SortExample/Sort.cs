using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;
using ProgramLogic;

namespace SortExample
{

    public struct Info
    {
        public int x;
        public int y;
        public int inf;
        public Color color;
    }
    struct TInf
    {
        public int l;
        public int r;
        public TInf(int l, int r)
        {
            this.l = l; this.r = r;
        }
    }
    //(T or T) and (F or (T and F))
    public class Sort
    {

        static Pen MyPen = new Pen(Color.Black, 2);
        static Font MyFont = new Font("Arial", 12);
        static Info[] arr = new Info[20];

        public static void Draw(Graphics g)
        {
    
            const int d = 15;
            int L = arr.Length;
            string s;
            SizeF size;
            g.Clear(Color.White);
            for (int i = 0; i <= L - 1; i++)
            {
                MyPen.Color = arr[i].color;
                g.DrawEllipse(MyPen, arr[i].x - d , arr[i].y - d, 2 * d, 2 * d);

                s = Convert.ToString(arr[i].inf);
                size = g.MeasureString(s, MyFont);
                g.DrawString(s, MyFont, Brushes.Black, arr[i].x - size.Width / 2 , arr[i].y - size.Height / 2);
            }
        }
        

            static void Change(Graphics g, int i, int j)
            {
                arr[i].color = Color.Yellow;
                arr[j].color = Color.Yellow;
                int x1 = arr[i].x;
                int y1 = arr[i].y;
                int x2 = arr[j].x;
                int y2 = arr[j].y;
            int y3 = 0;
            int y4 = 0;
                double y;

                for (int t = 0; t < 20; t++)
                {
                    switch (t)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            y = 30 * t / 4;
                            arr[i].y = y1 - (int)(y);
                            arr[j].y = y2 + (int)(y);
                        y3 = arr[i].y;
                        y4 = arr[j].y;
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        y = (x2 - x1) * (t - 4) / 7;
                            arr[i].x = x1 + (int)(y);
                            arr[j].x = x2 - (int)(y);
                            break;
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                            y = 30 * (t - 11) / 4;
                            arr[i].y = y3 + (int)(y);
                            arr[j].y = y4 - (int)(y);
                            break;
                    }
                DrawSort1.MyDraw();
                //Thread.Sleep(50);
                }

                arr[i].color = Color.Black;
                arr[j].color = Color.Black;
                DrawSort1.MyDraw();
                

            }
            
        public static void StartSortBuble(Graphics g)
        {
            SortBuble(g, 0, arr.Length - 1);
        }
            private static void SortBuble(Graphics g, int left, int right)
            {
                
                for (int i = left; i <= right; i++)
                for (int j = right; j > left; j--)
                {
                    Info t;
                    if (arr[j - 1].inf > arr[j].inf)
                    {
                        Change(g, j, j - 1);
                        t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                    }
                }
            }

            public static void Random()
            {
                //Info[] arr = new Info[col];
                int L = arr.Length;
                Random rnd = new Random();
                for (int i = 0; i < L; i++)
                {
                    arr[i].x = 50 + i * 30;
                    arr[i].y = 100;
                    arr[i].color = Color.Black;
                    arr[i].inf = rnd.Next(100);
                }
                

            }

        public static void StartQuickSort(Graphics g)
        {
            int left = 0;
            int right = arr.Length - 1;
            QuickSort(g, left, right);
        }
        private static void QuickSort(Graphics g, int left, int right)  // Рекурсивная
        {
            
            int i = left; int j = right;
            int x = arr[(left + right) / 2].inf; 

            do
            {
                while (arr[i].inf < x)     
                    i++;
                while (arr[j].inf > x)     
                    j--;
                if (i <= j)          
                {
                    Change(g, i, j);
                    Info tmp = arr[i]; arr[i] = arr[j]; arr[j] = tmp;
                    i++; j--;
                }
            }
            while (i <= j);

            if (left < j)
            {
                if (j - left < 6)
                    SortBuble(g, left, j);
                else
                QuickSort(g, left, j);
            }
            if (i < right)
            {
                if (right - i < 6)
                    SortBuble(g, i, right);
                else
                QuickSort(g, i, right);
            }
        }

        public static void QuickStack(Graphics g)  
        {

            int left = 0; int right = arr.Length - 1;
            MyStackForSort stack = new MyStackForSort();
           
            stack.Push(left);
            stack.Push(right);

            do
            {
                right = stack.Pop();
                left = stack.Pop(); 

                    int i = left; int j = right;
                    int x = arr[(left + right) / 2].inf;

                    do
                    {
                        while (arr[i].inf < x) i++;
                        while (arr[j].inf > x) j--;
                        if (i <= j)
                        {
                            Change(g, i, j);
                            Info tmp = arr[i]; arr[i] = arr[j]; arr[j] = tmp;
                            i++; j--;
                        }
                    }
                    while (i <= j);
                       
                    

                    if (i < right)
                    {
                        if ( right - i < 6) SortBuble(g, i, right);
                        else
                        {
                            
                            stack.Push(i);
                            stack.Push(right);
                        }
                    }
                    if (left < j)
                    {
                        if (j - left < 6) SortBuble(g, left, j);
                        else
                        {
                            
                            stack.Push(left);
                            stack.Push(j);
                        }
                    }

            }
            while (!stack.StackIsEmpty());

        }

    }
    
}
