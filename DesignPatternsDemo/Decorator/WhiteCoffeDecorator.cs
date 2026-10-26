using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Decorator
{
    internal class WhiteCoffeDecorator : CoffeDecorator
    {
        public WhiteCoffeDecorator(Coffe coffe)
            : base(coffe)
        {
            
        }

        public override string GetDesciption()
        {
            return base.GetDesciption() + ", White Coffe";
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.3;
        }
    }
}
