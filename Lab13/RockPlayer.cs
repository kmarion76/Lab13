using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class RockPlayer : Player
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RockPlayer()
        {
            
            
        }

        public static RPS GenerateRPS()
        {

            RPS rockplayer = RPS.Rock;
            return rockplayer;
        }
    }
}
