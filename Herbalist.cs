using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    class Herbalist : Healer
    {
        public void healWounds() 
        {
            Console.WriteLine("Your wounds have been healed!");
        }

        public void curePoison(string poison)
        {
            Console.WriteLine("You have been cured from " + poison + ". Seems odd how he used the same incense like last time.");
        }
    }
}
