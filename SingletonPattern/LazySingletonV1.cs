using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAndStatic
{
    class LazySingletonV1
    {
        // this will be instantiated even if the PrintSomething method is called
        private readonly static LazySingletonV1 instance = new LazySingletonV1();

        public static LazySingletonV1 Instance
        {
            get
            {
                return instance;
            }
        }

        private LazySingletonV1()
        {
            Console.WriteLine("LazySingletonV1 private constructor called");
        }

        static LazySingletonV1()
        {
            Console.WriteLine("LazySingletonV1 static constructor called");
        }

        public static void PrintSomething()
        {
            Console.WriteLine("LazySingletonV1 print something executed");
        }
    }

    class LazySingletonV1Updated
    {
        private class LazySingletonV1UpdatedHolder
        {
            internal readonly static LazySingletonV1Updated Instance = new LazySingletonV1Updated();

            static LazySingletonV1UpdatedHolder()
            {
                Console.WriteLine("LazySingletonV1UpdatedHolder static constructor called");
            }
        }
        
        public static LazySingletonV1Updated Instance
        {
            get
            {
                return LazySingletonV1UpdatedHolder.Instance;
            }
        }

        // IMPORTANT !!!
        // private constructor will not be called until the Instance field from LazySingletonV1UpdatedHolder is called
        private LazySingletonV1Updated()
        {
            Console.WriteLine("LazySingletonV1Updated private constructor called");
        }

        // static constructor will be called when PrintSomething is called
        static LazySingletonV1Updated()
        {
            Console.WriteLine("LazySingletonV1Updated static constructor called");
        }

        public static void PrintSomething()
        {
            Console.WriteLine("LazySingletonV1Updated print something executed");
        }
    }
}
