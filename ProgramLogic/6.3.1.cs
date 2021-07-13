using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramLogic
{
    public class Queue123
    {
        public static void ResultQueue(MyQueue queue)
        {
            double n;
            int count = queue.count;
            for (int i = 0; i < count; i++)
            {
                if ((n = queue.Pop()) > 0) queue.Push(n);  
            }
        }

    }
}
