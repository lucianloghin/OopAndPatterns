using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject weatherSubject = new WeatherObject();
            IDisplay display1 = new Display1(weatherSubject);
            display1.StartMonitoring();
        }
    }
}
