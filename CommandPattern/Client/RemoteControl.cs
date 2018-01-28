using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Commands;

namespace CommandPattern.Client
{
    class RemoteControl
    {
        private ICommand command;

        public RemoteControl()
        {
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Invoke()
        {
            this.command.Execute();
        }
    }
}
