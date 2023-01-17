using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    // C# 구조체는 클래스와 같이 메서드, 프로퍼티 등 거의 비슷한 구조를 가지고 있지만, 상속(inheritance)은 할 수 없다. 하지만 인터페이스(interface)는 구현할 수 있다.
    struct MyPoint
    {
        public int x;
        public int y;

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }
    }

    class Struct
    {
        // struct를 사용하면 Value Type
        // class를 사용하면 reference Type
    }

    // System.Int32 (Value Type)
    public struct Int32
    {

    }

    // System.String (Reference Type)
    public sealed class String1
    {

    }
}
