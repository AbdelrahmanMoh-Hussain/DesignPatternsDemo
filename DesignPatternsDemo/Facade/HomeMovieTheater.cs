using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Facade
{
    internal class HomeMovieTheater
    {
        private readonly Dvd _dvd;
        private readonly TV _tv;

        public HomeMovieTheater(Dvd dvd, TV tv)
        {
            _dvd = dvd;
            _tv = tv;
        }

        public void WatchMovie(string movie)
        {
            _tv.On();
            _tv.SetVolume(20);
            _dvd.On();
            _dvd.Play(movie);
        }
    }
}
