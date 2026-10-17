using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Builder
{
    internal class Pizza
    {
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public string Toppings { get; set; }

        private Pizza() { } // Private constructor to prevent direct instantiation

        override public string ToString()
        {
            return $"Pizza with {Crust} crust, {Sauce} sauce, and {Toppings} toppings.";
        }

        public class Builder
        {
            private readonly Pizza _pizza;

            public Builder()
            {
                _pizza = new Pizza();
            }

            public Builder WithCrust(string crust)
            {
                _pizza.Crust = crust;
                return this;
            }

            public Builder WithSauce(string sauce)
            {
                _pizza.Sauce = sauce;
                return this;
            }

            public Builder WithToppings(string toppings)
            {
                _pizza.Toppings = toppings;
                return this;
            }

            public Pizza Build()
            {
                return _pizza;
            }
        }
    }
}
