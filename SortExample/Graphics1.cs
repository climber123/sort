using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogic;

namespace SortExample
{

    class Graphics1
    {
        //static Info[] arr = new Info[1000];
        public static int[] StartSortBuble(Info[] arr)
        {
            return SortBuble(arr,0, arr.Length - 1);
        }
        private static int[] SortBuble(Info[] arr,int left, int right)
        {
            int[] count = new int[2]; // count[0] - обмен, count[1] - сравнения
            count[0] = count[1] = 0;
            for (int i = left; i <= right; i++)
                for (int j = right; j > left; j--)
                {
                    Info t;
                    count[1]++;
                    if (arr[j - 1].inf > arr[j].inf)
                    {
                        t = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = t;
                        count[0]++;
                    }
                }
            return count;
        }

        public static Info[] Random(int l)
        {
            Info[] arr = new Info[l];
            Random rnd = new Random();
            for (int i = 0; i < l; i++)
            {
                arr[i].inf = rnd.Next(100);
            }
            return arr;
        }

        public static int[] StartQuickSort(Info[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            return QuickSort(arr,left, right);
        }
        private static int[] QuickSort(Info[] arr,int left, int right)  // Рекурсивная
        {
            int[] count = new int[2];
            count[0] = count[1] = 0;

            int i = left; int j = right;
            int x = arr[(left + right) / 2].inf;

            do
            {
                while (arr[i].inf < x)
                {
                    i++;
                    count[1]++;
                }
                while (arr[j].inf > x)
                {
                    j--;
                    count[1]++;
                }
                if (i <= j)
                {
                    Info tmp = arr[i]; arr[i] = arr[j]; arr[j] = tmp;
                    i++; j--;
                    count[0]++;
                }
            }
            while (i <= j);

            if (left < j)
            {
                if (j - left < 6)
                    SortBuble(arr,left, j);
                else
                    QuickSort(arr,left, j);
            }
            if (i < right)
            {
                if (right - i < 6)
                    SortBuble(arr,i, right);
                else
                    QuickSort(arr,i, right);
            }
            return count;
        }

        public static int[] QuickStack(Info[] arr)
        {
            int[] count = new int[2];
            count[0] = count[1] = 0;
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
                    while (arr[i].inf < x)
                    {
                        i++;
                        count[1]++;
                    }
                    while (arr[j].inf > x)
                    {
                        j--;
                        count[1]++;
                    }
                    if (i <= j)
                    {
                        Info tmp = arr[i]; arr[i] = arr[j]; arr[j] = tmp;
                        i++; j--;
                        count[0]++;
                    }
                }
                while (i <= j);



                if (i < right)
                {
                    if (right - i < 6) SortBuble(arr,i, right);
                    else
                    {

                        stack.Push(i);
                        stack.Push(right);
                    }
                }
                if (left < j)
                {
                    if (j - left < 6) SortBuble(arr,left, j);
                    else
                    {

                        stack.Push(left);
                        stack.Push(j);
                    }
                }

            }
            while (!stack.StackIsEmpty());

            return count;
        }
    }
}
