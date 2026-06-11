using DesignPatternAndSolidTask.Enums;
using DesignPatternAndSolidTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAndSolidTask.ObserverPattern
{
    internal class OrderSubject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private Order order;
        public OrderSubject(Order order)
        {
            this.order = order;
        }
        public void SetOrderStatus(OrderStatus orderStatus)
        {
            notify(orderStatus);
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void notify(OrderStatus orderStatus)
        {
            foreach(IObserver observer in _observers)
            {
                observer.Update(order,orderStatus);
            }
        }
    }
}


