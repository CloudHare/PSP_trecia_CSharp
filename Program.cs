using System;

namespace PSP_trecia_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArcaneBaristaAcademy academy = new ArcaneBaristaAcademy();

            academy.learnFireBall();

            academy.healWounds();
            academy.curePoison("anise");

            academy.getFortune(2);

            academy.feedOwl(20);
        }
    }
}
