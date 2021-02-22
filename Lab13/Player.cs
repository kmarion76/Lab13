using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public interface Player
    {
        public string Name { get; set; }
        
       

       

        public virtual RPS GenerateRPS()
        {
            
            return default;
        }
        
    }
}
