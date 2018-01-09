using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.PrimaryComponents
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            base.description = "Dark Roast";
        }

        public override double Cost()
        {
            return 2.00d;
        }
    }
}
