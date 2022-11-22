﻿using AlgoStrategies.Models;

namespace AlgoStrategies
{
    public class Client
    {
        private AbstractStrategy _strategy;

        public Client(AbstractStrategy  strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithInterface();
        }
    }
}
