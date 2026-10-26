using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Singlton
{
    internal sealed class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new object();

        private  Logger()
        {
            // Private constructor to prevent instantiation
        }

        public static Logger Instance
        {
            get
            {
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}
