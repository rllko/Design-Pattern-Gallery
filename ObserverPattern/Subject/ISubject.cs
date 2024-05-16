using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    internal interface ISubject<T>
    {
        public void RegisterObserver(T t);
        public bool RemoveObserver(T t);
        public void NotifyObservers();
    }
}
