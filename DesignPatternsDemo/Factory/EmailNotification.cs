using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Factory
{
    internal class EmailNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Sending an email notification");
        }

    }
}
