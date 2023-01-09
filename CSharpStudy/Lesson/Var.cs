using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Var
    {
        // 필드 (클래스 내에서 공통적으로 사용되는 전역 변수)
        int globalVar;
        const int MAX = 1024;

        // 상수
        // const 컴파일 타임 상수
        // readonly 런타임 상수
        const int MAX_VALUE = 2147483647;
        readonly int Max;

        public Var()
        {
            Max = 1;
        }

        public void Method1()
        {
            // 로컬 변수
            int localVar;

            // 아래 할당이 없다면 에러 발생
            localVar = 100;

            Console.WriteLine(globalVar);
            Console.WriteLine(localVar);
        }
    }
}
