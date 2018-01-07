using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    class StandardDuckQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
