using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorComponents
{
    class Whip : Beverage
    {
        private readonly Beverage component;

        public Whip(Beverage component)
        {
            this.component = component;
            this.description = this.component.GetDescription() + " And Whip";
        }

        public override double Cost()
        {
            return this.component.Cost() + 0.50d;
        }
    }
}
