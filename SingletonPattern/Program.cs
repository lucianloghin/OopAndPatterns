using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //LazySingletonV1.PrintSomething();

            LazySingletonV1Updated.PrintSomething();
            var x = LazySingletonV1Updated.Instance;
            //LazySingletonV2.PrintSomething();

            Console.ReadLine();
        }
    }
}
