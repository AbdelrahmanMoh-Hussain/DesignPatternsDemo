using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Factory
{
    internal abstract class NotificationFactory
    {
        internal abstract INotification CreateNotification();
    }
}
