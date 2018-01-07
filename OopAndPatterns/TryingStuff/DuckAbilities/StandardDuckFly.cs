using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    internal class StandardDuckFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Standard Fly");
        }
    }
}
