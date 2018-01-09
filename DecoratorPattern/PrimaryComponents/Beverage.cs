using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class Beverage
    {
        protected string description;

        public abstract double Cost();

        public string GetDescription()
        {
            return description;
        }
    }
}
