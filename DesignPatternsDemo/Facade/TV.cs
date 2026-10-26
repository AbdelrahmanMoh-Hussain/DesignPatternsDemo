using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Facade
{
    internal class TV
    {
        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"TV volume set to {volume}");
        }
    }
}
