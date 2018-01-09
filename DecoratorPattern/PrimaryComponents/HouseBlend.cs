using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.PrimaryComponents
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            base.description = "House Blend";
        }

        public override double Cost()
        {
            return 1.80d;
        }
    }
}
