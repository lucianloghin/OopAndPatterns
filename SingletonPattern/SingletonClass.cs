using System;
using System.Linq;
using System.Net;

namespace SingletonPattern
{
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
        }
        
        // dunno exactly why this helps, has something to do with beforefieldinit flag
        static SingletonClass()
        {
        }
    }
}