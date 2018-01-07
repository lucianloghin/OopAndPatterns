using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Subjects;

namespace ObserverPattern.Observers
{
    class Display1 : IObserver, IDisplay
    {
        private readonly ISubject subject;
        private int humidity;
        private int temperature;

        public Display1(ISubject subject)
        {
            this.subject = subject;
        }

        public void StartMonitoring()
        {
            this.subject.RegisterObserver(this);
        }

        public void StopMonitoring()
        {
            this.subject.UnregisterObserver(this);
        }

        public void Notify(int temperature, int humidity)
        {
            this.temperature = temperature;
            this.humidity = humidity;

            this.Display();
        }

        private void Display()
        {
            Console.WriteLine($"Temperature: {this.temperature}; Humidity: {this.humidity}");
        }
    }
}
