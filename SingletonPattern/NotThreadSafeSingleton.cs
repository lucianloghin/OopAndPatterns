using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternAndStatic
{
    class NotThreadSafeSingleton
    {
        private static NotThreadSafeSingleton instance;

        public static NotThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NotThreadSafeSingleton();
                }

                return instance;
            }
        }

        private NotThreadSafeSingleton()
        {

        }
    }
}
