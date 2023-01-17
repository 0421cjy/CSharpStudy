using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello. world...");

            // c# 키워드는 컴파일시 .net 데이터 타입으로 변환된다.

            // bool
            bool b = true;
            System.Boolean b2 = true;

            // Numeric
            short sh = -32768;
            int i = 2147483647;
            long l = 1234L;         // L suffix
            float f = 123.45F;      // F suffix
            double d1 = 123.45;
            double d2 = 123.45D;    // D suffix
            decimal d = 123.45M;    // M suffix

            System.Byte b3 = 255;
            System.SByte b4 = 127;
            System.Int16 sh2 = -32768;
            System.UInt16 sh3 = 65535;
            System.Int32 i2 = 2147483647;
            System.UInt32 i3 = 4294967295;
            System.Int64 l2 = 1234L;
            System.UInt64 l3 = 1234UL;

            // Char/String
            char c = 'A';
            string s = "Hello";

            // DateTime 2011-10-30 12:35
            DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

            // null 가질 수 있는 타입 (Reference) null 가질 수 없는 타입 (value) 타입

            string s3;
            s3 = null;

            // nullable Type C# 2.0에서 추가되었다.
            int? i4 = null;
            i4 = 101;

            bool? b5 = null;
            Console.WriteLine(b5);

            b5 = false;
            Console.WriteLine(b5);

            //int? 를 int로 할당
            Nullable<int> j = null;
            Console.WriteLine(j);

            j = 10;
            Console.WriteLine(j);

            int k = j.Value;
            Console.WriteLine(j);

            Var var2 = new Var();
            var2.Method1();

            MyEnum e2 = new MyEnum();
            e2.foo();

            // (1) foreach 사용해서 Iteration
            var list = new MyList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // (2) 수동 Iteration
            var it = list.GetEnumerator();

            Console.WriteLine(it.Current); // 빈칸
            it.MoveNext();
            Console.WriteLine(it.Current); // 1
            it.MoveNext();
            Console.WriteLine(it.Current); // 2

            var myPoint = new MyPoint(3, 5);
            Console.WriteLine(myPoint.ToString());

            var myCustomer = new MyCustomer();
            myCustomer.Age = 1;
            myCustomer.Name = "peter";

            Console.WriteLine(myCustomer.Age);
            Console.WriteLine(myCustomer.Name);

            Console.WriteLine(myCustomer.GetCustomerData());
        }
    }
}
