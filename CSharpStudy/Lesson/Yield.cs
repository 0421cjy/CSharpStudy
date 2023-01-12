using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Yield
    {
        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }

        public void foo()
        {
            foreach (var num in GetNumber())
            {
                Console.WriteLine(num);
            }


        }
    }

    public class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }

        // GetEnumerator
        // MoveNext
        // Current
        // MoveNext
        // Current
    }
}
