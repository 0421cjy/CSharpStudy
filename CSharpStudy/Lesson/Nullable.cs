using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Lesson
{
    class Nullable
    {
        public void foo()
        {
            int? i = null;
            bool? b = null;
            int?[] a = new int?[100];

            Nullable<int> i2 = null;
            i2?.ToString();
        }

        // Value 타입이 아닌 레퍼런스 타입은 Nullable을 쓸 필요가 없는데, 그것은 모든 레퍼런스 타입은 이미 NULL을 허용하기 때문이다.

        double _Sum = 0;
        DateTime _Time;
        bool? _Selected;

        public void CheckInput(int? i, double? d, DateTime? time, bool? selected)
        {
            if (i.HasValue && d.HasValue)
            {
                this._Sum = (double)i.Value + (double)d.Value;
            }

            if (!time.HasValue)
            {
                throw new ArgumentException;
            }
            else
            {
                this._Time = time.Value;
            }

            // 만약 selected가 null 이면 false를 할당
            this._Selected = selected ?? false;
        }

        void NullableTest()
        {
            int? a = null;
            int? b = 0;
            int result = System.Nullable.Compare<int>(a, b);
            Console.WriteLine(result); // 결과 -1;

            double? c = 0.01;
            double? d = 0.0100;
            bool result2 = System.Nullable.Equals<double>(c, d);
            Console.WriteLine(result2); // 결과 true
        }
    }
}
