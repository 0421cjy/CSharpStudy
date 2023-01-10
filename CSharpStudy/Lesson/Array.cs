using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Array
    {
        public Array()
        {

        }

        public void test()
        {
            // 1차 배열 Rectangular Array
            string[] player = new string[10];
            string[] regions = { "서울", "경기", "부산" };

            // 2차 배열
            string[,] depts = { { "김과장", "경리부" }, { "이과장", "총무부" } };

            // 3차 배열
            string[,,,] cubes;

            // Jagged Array (가변 배열)
            // 1차 배열 크기(3)는 명시해야함
            int[][] jaggedArray = new int[3][];

            // 각 1차 배열 요소당 서로 다른 크기의 배열 할당 가능
            jaggedArray[0] = new int[2];
            jaggedArray[1] = new int[3] { 1, 2, 3};

            jaggedArray[0][1] = 1;
            jaggedArray[0][1] = 2;

            int[] scores = { 80, 78, 60, 90, 100 };
            var sum = CalculateSum(scores);

            Console.WriteLine(sum);
        }

        public int CalculateSum(int[] scoresArray)
        {
            int sum = 0;
            for(int i =0; i< scoresArray.Length; i++)
            {
                sum += scoresArray[i];
            }

            return sum;
        }
    }
}
