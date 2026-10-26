using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Factory
{
    internal class EmailNotificationFactory : NotificationFactory
    {
        internal override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    
    }
}
