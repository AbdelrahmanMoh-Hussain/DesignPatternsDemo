using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Factory
{
    internal class App2
    {
        private readonly NotificationFactory _notificationFactory;

        public App2(NotificationFactory notificationFactory)
        {
            _notificationFactory = notificationFactory;
        }

        public void SendNotification()
        {
            var notification = _notificationFactory.CreateNotification();
            notification.Notify();
        }
    }
}
