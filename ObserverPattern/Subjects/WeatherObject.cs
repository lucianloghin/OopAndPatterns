using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observers;
using ObserverPattern.Subjects;

namespace ObserverPattern
{
    internal class WeatherObject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public int GetTemperature()
        {
            return 20;
        }

        public int GetHumidity()
        {
            return 60;
        }

        public void MeasurementsChanged()
        {
            int temperature = GetTemperature();
            int humidity = GetHumidity();

            foreach (IObserver observer in observers)
            {
                observer.Notify(temperature, humidity);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
