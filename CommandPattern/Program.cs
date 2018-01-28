using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Client;
using CommandPattern.Commands;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            RemoteControl rc = new RemoteControl();
            rc.SetCommand(lightOn);
            rc.Invoke();
        }
    }
}
