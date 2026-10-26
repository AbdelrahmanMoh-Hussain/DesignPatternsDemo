using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Facade
{
    internal class Dvd
    {
        public void On()
        {
            Console.WriteLine("DVD is on");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"Playing movie: {movie}");
        }
    }
}
