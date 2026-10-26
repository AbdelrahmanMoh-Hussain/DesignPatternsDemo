using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Decorator
{
    internal class CoffeDecorator : Coffe
    {
        private readonly Coffe _coffe;

        public CoffeDecorator(Coffe coffe)
        {
            _coffe = coffe;
        }

        public override double GetCost() => _coffe.GetCost();

        public override string GetDesciption() => _coffe.GetDesciption();
    }
}
