using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RandomPlayer : Player
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RandomPlayer()
        {

        }
        
        public static RPS GenerateRPS()
        {
            var random = new Random();
            RPS randomEnum = (RPS)random.Next(0, 3);
            return randomEnum;
        }
    }
}
