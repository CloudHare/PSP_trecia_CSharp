using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    abstract class AlchemyLaboratory
    {
        public string brewSpeedPotion(int coins)
        {
            
            if (coins < 4)
            {
                Console.WriteLine("That's not enough gold. You're not allowed into the laboratory.");
                return "nothing";
            }
            else if (coins > 3)
            {
                Console.WriteLine("You brew a speed potion.");
                return "speed potion";
            }
            else
            {
                Console.WriteLine("Error brewing speed potion");
                return "nothing";
            }
        }
    }
}
