using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAndStatic
{
    partial class Program
    {
        //static void Main(string[] args)
        //{
        //    //LazySingletonV1.PrintSomething();

        //    LazySingletonV1Updated.PrintSomething();
        //    var x = LazySingletonV1Updated.Instance;
        //    //LazySingletonV2.PrintSomething();

        //    Console.ReadLine();
        //}

        // for BeforeFieldInit
        static void Main()
        {
            Console.WriteLine("-------start-------");

            BeforeFieldInitExample.EchoAndReturn("Hello");

            // var test = BeforeFieldInitExample.x;

            Console.WriteLine("-------end-------");
            Console.ReadLine();
        }
    }
}
