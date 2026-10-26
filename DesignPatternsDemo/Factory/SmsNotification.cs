using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Factory
{
    internal class SmsNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Sending an SMS notification");
        }
    
    }
}
