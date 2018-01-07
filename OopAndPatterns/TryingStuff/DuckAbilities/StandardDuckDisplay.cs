using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    internal class StandardDuckDisplay : IDisplayable
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
    }
}
