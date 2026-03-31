using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Rpoon2Labos.DiceClasses
{
    internal class Die
    {
        private int numberOfSides;
        private Random randomGenerator;
        public Die(int numberOfSides, Random RandomGenerator)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = RandomGenerator;
        }
        public int Roll()
        {
            return randomGenerator.Next(1, numberOfSides + 1);
            
        }

    }
}
