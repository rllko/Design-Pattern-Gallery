using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    internal class SubscriberObserver : IObserver
    {
        private readonly string _name;
        public string Name
        {
            get { return _name; }
            init { _name = value; }
        }

        public void Update(string msg)
        {
            Console.WriteLine(Name + " RECIEVED A NOTIFICATION:" + msg);
        }
    }
}
