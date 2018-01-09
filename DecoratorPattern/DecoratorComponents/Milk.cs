using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorComponents
{
    class Milk : Beverage
    {
        private readonly Beverage component;

        public Milk(Beverage component)
        {
            this.component = component;
            this.description = this.component.GetDescription() + " And Milk";
        }

        public override double Cost()
        {
            return this.component.Cost() + 0.40d;
        }
    }
}
