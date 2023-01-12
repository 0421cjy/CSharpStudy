using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.Lesson
{
    class Condition
    {
        private int val;
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;

        public void foo(string[] args)
        {
            int a = -11;

            if (a >= 0)
            {
                val = a;
            }
            else
            {
                val = -a;
            }

            Console.WriteLine(val);

            if (args.Length != 1)
            {
                Console.WriteLine("Usage: MyApp.exe option");
                return;
            }

            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;
                case "/c":
                    continueOnError = true;
                    break;
                case "/l":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("unknown argument: {0}", option);
                    break;
            }
        }
    }
}
