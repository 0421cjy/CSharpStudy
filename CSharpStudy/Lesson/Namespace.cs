using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Lesson
{
    class Namespace
    {
        public int Calculate(int a, int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);

            int abs_sum = System.Math.Abs(a) + Math.Abs(b);
            return abs_sum;
        }
    }
}
