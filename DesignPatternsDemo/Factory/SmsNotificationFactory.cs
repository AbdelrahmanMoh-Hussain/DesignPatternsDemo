using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Factory
{
    internal class SmsNotificationFactory : NotificationFactory
    {
        internal override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    
    }
}
