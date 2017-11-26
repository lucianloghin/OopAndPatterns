using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAndStatic
{
    // A singleton class should not be inherited
    public sealed class DoubleCheckSingleton
    {
        // the volatile keyword  ensures that that when the variable is read it has the latest asigned value.
        // the memory model of modern-day systems contains processor registers, various levels of cache and main memory.
        // when the program executes, the data might be cached by the processor.
        // Any updates done on the data would be at a cache level. Only at a later point the values from the cached will be flushed to the main memory.
        // When another thread reads the data, it will read it from the main memory and it might have an outdated version.
        // The volatile keyword informs the JIT compiler that the value should never be cached.
        // Thus the compiler avoids unig any optimisations on the variable that might lead to data conflicts.
        private volatile static DoubleCheckSingleton instance;
        private static readonly object mutex = new object();

        public static DoubleCheckSingleton Instance
        {
            get
            {
                // this check prevents locking each time the instance needs to be retrieved
                if (instance == null)
                {
                    // this will ensure that only a single thread will create a new instance
                    lock (mutex)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckSingleton();
                        }

                        return instance;
                    }
                }

                return instance;
            }
        }

        private DoubleCheckSingleton()
        {
        }
    }
}
