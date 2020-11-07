using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    class Hermit : FortuneTeller
    {
        public void getFortune(int coins)
        {
            if (coins < 10)
            {
                Console.WriteLine("You will encounter an Australian Drop Bear on your next adventure.");
            }
            else if (coins > 9)
            {
                Console.WriteLine("Next time you buy gruel, it will be mostly safe to eat.");
            }
            else
            {
                Console.WriteLine("Error getting fortune.");
            }
        }
    }
}
