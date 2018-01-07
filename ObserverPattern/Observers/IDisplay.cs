using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    interface IDisplay
    {
        void StartMonitoring();

        void StopMonitoring();

        //void Display();
    }
}
