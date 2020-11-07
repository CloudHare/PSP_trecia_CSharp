using System;
using System.Collections.Generic;
using System.Text;

namespace PSP_trecia_CSharp
{
    class ArcaneBaristaAcademy : MagicAcademy, Healer, FortuneTeller, OwlCare
    {
        Herbalist herbalist = new Herbalist();
        Hermit hermit = new Hermit();
        OwlBarber owlBarber = new OwlBarber();

        public void healWounds()
        {
            herbalist.healWounds();
        }

        public void curePoison(string poison)
        {
            herbalist.curePoison(poison);
        }

        public void getFortune(int coins)
        {
            hermit.getFortune(coins);
        }

        public void feedOwl(int coins)
        {
            owlBarber.feedOwl(coins);
        }

        public void stylizeOwl(int coins)
        {
            owlBarber.stylizeOwl(coins);
        }
    }
}
