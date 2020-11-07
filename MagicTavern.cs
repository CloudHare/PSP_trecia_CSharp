using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    abstract class MagicTavern
    {
        public void rentRoom(int coins)
        {
            if(coins < 5)
            {
                Console.WriteLine("You got an old room that stinks like goblin's socks.");
            }
            else if (coins > 4)
            {
                Console.WriteLine("You got a decent room with jsut a few ferac rats.");
            }
            else
            {
                Console.WriteLine("Error renting room.");
            }
        }

        public void buyGruel()
        {
            Console.WriteLine("You buy some gruel. It didn't even cost anything. Maybe you're the one who should have gotten paid to take it?");
        }
    }
}
