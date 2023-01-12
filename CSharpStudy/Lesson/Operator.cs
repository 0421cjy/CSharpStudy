using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Lesson
{
    class Operator
    {
        public void foo()
        {
            // 산술 연산자 +, -, *, /, %
            // 할당 연산자 =, +=, -=, *=, /=, %=
            // 증감 연산자 ++, --
            // 논리 연산자 && || !
            // 관계/ 비교 연산자 < > <= >= !=
            // 비트 연산자 &(AND) |(OR) ^(XOR) 
            // Shift 연산자 << >> (int i = 2; i << 5; 왼쪽으로 5비트 이동한다. 결과값은 2의 6승 64)
            // 조건 연산자 ? ??

            // ?? 연산자 Null-coalescing operator, Null 병합 연산자 C# 3.0이상에서 지원하는 연산자이다.

            int? i = null;
            i = i ?? 0;

            string s = null;
            s = s ?? string.Empty;
        }
    }
}
