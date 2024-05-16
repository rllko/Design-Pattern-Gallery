using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    /// <summary>
    /// The Observer Pattern defines a one-to-many dependency between objects
    /// so that when one object changes state, all of its dependents are notified and updated automatically.
    /// </summary>
    internal class YoutubeChannelSubject : ISubject<IObserver>
    {
        List<IObserver> observers = new();

        public void RegisterObserver(IObserver t)
        {
            observers.Add(t);
        }

        public void NotifyObservers()
        {
            foreach (IObserver subscriber in observers)
            {
                subscriber.Update("hi");
            }
        }

        public bool RemoveObserver(IObserver t)
        {
            if (observers.Contains(t))
            {
                observers.Remove(t);
                return true;
            }
            return false;
        }
    }
}
