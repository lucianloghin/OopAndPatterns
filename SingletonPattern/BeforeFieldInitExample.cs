using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAndStatic
{
    class BeforeFieldInitExample
    {
        // Adding the static constructor removes the BeforeFieldInit attribute / flag
        // The BeforeFieldInit means that the type can be initialized at any point before
        // any static fields are referenced. In theory it means that it can be lazy instantiated,
        // if you call a static method which doesn't touch any static fields, the JIT doesn't need
        // to initialize the field.
        //static BeforeFieldInitExample() { }

        // In practice this doesn't really happens.
        // The class is initialized earlier than it would be otherwise.

        // With the BeforeFieldInit (without static constructor), the type initialization is different
        // between the Release and Debug modes

        public static string x = EchoAndReturn("a");
        public static string y = EchoAndReturn("b");
        public static string EchoAndReturn(string s)
        {
            Console.WriteLine(s);
            return s;
        }
    }
}
