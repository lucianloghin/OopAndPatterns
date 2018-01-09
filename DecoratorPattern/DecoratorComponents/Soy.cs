using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorComponents
{
    class Soy : Beverage
    {
        private readonly Beverage component;

        public Soy(Beverage component)
        {
            this.component = component;
            this.description = this.component.GetDescription() + " And Soy";
        }

        public override double Cost()
        {
            return this.component.Cost() + 0.50d;
        }
    }
}
