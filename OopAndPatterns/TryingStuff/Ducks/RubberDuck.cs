using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    class RubberDuck : Duck
    {
        private readonly IQuackable duckQuack = new StandardDuckQuack();

        public RubberDuck()
            : base(new StandardDuckDisplay(), new StandardeDuckSwim())
        {
        }

        public void Quack()
        {
            this.duckQuack.Quack();
        }
    }
}
