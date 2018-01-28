using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class LightOnCommand : ICommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        
        public void Execute()
        {
            this.light.On();
        }
    }
}
