﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpStudy.Lesson
{
    class String
    {
        public void foo()
        {
            // Immutable Type <-> Mutable Type
            // 문자열(string) 변수
            string s1 = "C#";
            string s2 = "Programming";

            // 문자(char) 변수
            char c1 = 'A';
            char c2 = 'B';

            // 문자열 결합
            string s3 = s1 + " " + s2;
            Console.WriteLine("String : {0}", s3);

            // 부분 문자열 발췌
            string s3substring = s3.Substring(1, 5);
            Console.WriteLine("Substring : {0}", s3substring);
        }

        public void bar()
        {
            string s = "C# Studies";

            // 문자열을 배열 인덱스로 한문자 엑세스
            for(int i = 0; i< s.Length; i++)
            {
                Console.WriteLine("{0}: {1}",i, s[i]);
            }

            // 문자열을 문자배열로 변환 string to string[]
            string str = "Hello";
            char[] charArray = str.ToArray();

            for (int i =0; i< charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }

            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = charArray2.ToString();

            Console.WriteLine(s);

            char c1 = 'A';
            char c2 = (char)(c1 + 3);
            Console.WriteLine(c2); // D 출력
        }

        public void StringBuilder()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            StringBuilder sb = new StringBuilder();
            for(int i =0; i <= 26; i++)
            {
                sb.Append(i.ToString());
                sb.Append(System.Environment.NewLine);
            }

            string s = sb.ToString();

            stopwatch.Stop();

            Console.WriteLine(s);
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
