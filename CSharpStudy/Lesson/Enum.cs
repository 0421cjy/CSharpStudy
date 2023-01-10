using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class MyEnum
    {
        public enum Category
        {
            Cake,
            IceCream,
            Bread
        }

        public enum City
        {
            Seoul,
            Daejun,
            Busan = 5,
            Jeju = 10,
        }

        [Flags]
        enum Border
        {
            None = 0,
            Top = 1,
            Right = 2,
            Bottom = 4,
            Left = 8,
        }

        public void foo()
        {
            City myCity;

            // enum 타입에 값을 대입하는 방법
            myCity = City.Seoul;

            // enum을 int로 변환(casting)하는 방법
            int cityValue = (int)myCity;

            if (myCity == City.Seoul)
            {
                Console.WriteLine("welcome to seoul");
            }

            Border b = Border.Top | Border.Bottom;
            int temp = (int)b;

            // int로 변환 >> 5
            Console.WriteLine(temp);

            if ((b & Border.Top) != 0)
            {
                // HasFlag() 이용 플래그 체크
                if (b.HasFlag(Border.Bottom))
                {
                    Console.WriteLine(b.ToString());
                }
            }
        }
    }
}
