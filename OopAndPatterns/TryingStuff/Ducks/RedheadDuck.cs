using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    class RedheadDuck : Duck
    {
        private readonly IQuackable duckQuack = new StandardDuckQuack();
        private readonly IFlyable duckFly = new StandardDuckFly();

        public RedheadDuck()
            : base(new StandardDuckDisplay(), new StandardeDuckSwim())
        {
            
        }

        public void Quack()
        {
            this.duckQuack.Quack();
        }

        public void Fly()
        {
            this.duckFly.Fly();
        }
    }
}
