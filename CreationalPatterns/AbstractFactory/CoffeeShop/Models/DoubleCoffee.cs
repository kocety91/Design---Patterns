﻿using CoffeeShop.AbstractProductModels;

namespace CoffeeShop.Models
{
    public class DoubleCoffee : PlainCoffee
    {
        public override string Name => "DoubleCoffee";

        public override int CoffeeContent => 200;

        public override int MilkContent => 0;
    }
}
