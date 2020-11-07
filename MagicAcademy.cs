using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    abstract class MagicAcademy
    {
        public void learnFireBall()
        {
            Console.WriteLine("You fail to learn the fireball spell. Study harder next time!");
        }
        public void summonImp()
        {
            Console.WriteLine("You learned to summon an imp! But he doesn't seem to obey you...");
        }

    }
}
