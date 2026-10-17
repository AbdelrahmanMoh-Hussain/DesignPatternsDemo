using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Adaptor
{
    internal class App
    {
        private readonly ILogger _logger;

        public App(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Log("Hello, World!");
        }
    }
}
