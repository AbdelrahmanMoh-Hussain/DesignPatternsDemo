using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Decorator
{
    internal class SimpleCoffe : Coffe
    {
        public override double GetCost() => 1.0;
        public override string GetDesciption() => "Simple Coffe";

    }
}
