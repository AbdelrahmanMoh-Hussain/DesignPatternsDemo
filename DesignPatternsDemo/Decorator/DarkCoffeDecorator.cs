using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Decorator
{
    internal class DarkCoffeDecorator : CoffeDecorator
    {
        public DarkCoffeDecorator(Coffe coffe) : base(coffe)
        {
        }
        public override double GetCost() => base.GetCost() + 0.5;
        public override string GetDesciption() => base.GetDesciption() + ", Dark Roast";
    
    }
}
