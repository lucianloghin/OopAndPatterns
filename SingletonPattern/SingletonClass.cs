using System;
using System.Linq;
using System.Net;

namespace SingletonPattern
{
    public sealed class SingletonClass
    {
        [ThreadStatic]
        private static SingletonClass _instance;

        public static SingletonClass Instance
        {
            get
            {
                return _instance;
            }
        }
        static SingletonClass()
        {
            _instance = new SingletonClass();
        }
    }
}