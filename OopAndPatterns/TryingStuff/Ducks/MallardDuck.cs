using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    class MallardDuck : Duck
    {
        private readonly IQuackable duckQuack = new StandardDuckQuack();
        private readonly IFlyable duckFly = new StandardDuckFly();

        public MallardDuck()
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
