using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    internal class StandardeDuckSwim : ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Standard swim");
        }
    }
}
