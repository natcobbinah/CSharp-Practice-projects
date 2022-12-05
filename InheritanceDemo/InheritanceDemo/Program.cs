using System;

namespace InheritanceDemo
{
    class Progam
    {
        static void Main(string[] args)
        {
            Storm[] storm = new Storm[4];

            Pupil pupil = new Pupil("Mezilkree", "IceCrown");
            storm[0] = pupil.CastWindStorm();

            Mage mage = new Mage("Gul'dan", "Draenor");
            storm[1] = mage.CastRainStorm();

            Archmage archmage = new Archmage("Nielas Aran", "StormWind");
            storm[2] = archmage.CastRainStorm();
            storm[3] = archmage.CastLightningStorm();

            //delegate
            Action<Storm> action = new Action<Storm>(ShowDescription);
            Array.ForEach(storm, action);
        }

        private static void ShowDescription(Storm storm)
        {
            Console.WriteLine(storm.Announce());
        }
    }
}