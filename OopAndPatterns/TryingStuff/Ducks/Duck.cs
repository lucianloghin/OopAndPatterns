using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAndPatterns.TryingStuff
{
    internal abstract class Duck
    {
        private readonly IDisplayable displayable;
        private readonly ISwimable swimable;

        protected Duck(IDisplayable displayable, ISwimable swimable)
        {
            this.displayable = displayable;
            this.swimable = swimable;
        }

        public void Display()
        {
            this.displayable.Display();
        }

        public void Swim()
        {
            this.swimable.Swim();
        }
    }
}
