using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    class OwlBarber : OwlCare
    {
        public void feedOwl(int coins)
        {
            if (coins < 3)
            {
                Console.WriteLine("Your owl was fed gruel. Feel ashamed yet?");
            }
            else if (coins > 2)
            {
                Console.WriteLine("Your owl was fed some nice juicy worms. Better than the gruel you eat.");
            }
            else
            {
                Console.WriteLine("Error feeding owl");
            }
        }

        public void stylizeOwl(int coins)
        {
            if (coins < 3)
            {
                Console.WriteLine("Is that nail polish?");
            }
            else if (coins > 2)
            {
                Console.WriteLine("You owl has a beard now");
            }
            else
            {
                Console.WriteLine("Error stylizing owl");
            }
        }
    }
}
