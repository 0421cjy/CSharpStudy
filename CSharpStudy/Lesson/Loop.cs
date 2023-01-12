using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Lesson
{
    class Loop
    {
        public void foo()
        {
            // for 루프
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Loop {0}", i);
            }

            var array = new string[] { "A", "B", "C", "D"};

            // foreach 루프
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }

            // 성능은 for문이 약간 더 빠르다.
            // foreach는 간결함이 장점이다.

            string[,,] arr = new string[,,]
            {
                { {"1", "2"}, {"11", "22"} },
                { {"3", "4"}, {"33", "44"} }
            };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(0); k++)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                }
            }

            foreach(var s in arr)
            {
                Console.WriteLine(s);
            }


            int i1 = 1;

            while(i1 <= 10)
            {
                Console.WriteLine(i1);
                i1++;
            }

            int i2 = 1;

            do
            {
                Console.WriteLine(i2);
                i2++;

            } while (i2 <= 10);


            List<char> keyList = new List<char>();
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey();
                keyList.Add(key.KeyChar);

            } while (key.Key != ConsoleKey.Q);

            Console.WriteLine();
            foreach (var k in keyList)
            {
                Console.WriteLine(k);
            }
        }
    }
}
