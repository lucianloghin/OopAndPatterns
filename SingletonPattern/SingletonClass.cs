using System;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace SingletonPatternAndStatic
{
    // A singleton class should not be inherited
    public sealed class SingletonClass
    {
        // this will be initialized in the static constructor
        // the CLR ensures that the static constructor is called only once. This makes it a thread safe solution
        private static readonly SingletonClass _instance = new SingletonClass();

        public static SingletonClass Instance
        {
            get
            {
                return _instance;
            }
        }

        private SingletonClass()
        {
            Debug.WriteLine("Private constructor");
        }
        
        // adding the static constructor removes the beforefieldinit flag
        static SingletonClass()
        {
            Debug.WriteLine("Static constructor");
        }
    }
}