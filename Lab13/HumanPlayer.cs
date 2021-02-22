using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class HumanPlayer : Player
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HumanPlayer()
        {

        }
        
        public static RPS GenerateRPS()
        {
            
            var humanInput = Console.ReadLine();
            if (humanInput.Equals("r", StringComparison.OrdinalIgnoreCase))
            {
                return RPS.Rock;
            }
            else if (humanInput.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                return RPS.Paper;
            }
            else 
            {
                return RPS.Scissors;
            }
            

        }
    }
}
