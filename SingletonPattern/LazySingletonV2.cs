using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class LazySingletonV2
    {
        private readonly static Lazy<LazySingletonV2> lazyInstance = new Lazy<LazySingletonV2>(() => new LazySingletonV2());

        public static LazySingletonV2 Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        private LazySingletonV2()
        {
            Console.WriteLine("LazySingletonV2 private constructor called");
        }

        static LazySingletonV2()
        {
            Console.WriteLine("LazySingletonV2 static constructor called");
        }

        public static void PrintSomething()
        {
            Console.WriteLine("LazySingletonV2 print something executed");
        }
    }
}
