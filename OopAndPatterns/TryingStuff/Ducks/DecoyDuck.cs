using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
            : base(new StandardDuckDisplay(), new StandardeDuckSwim())
        {

        }
    }
}
