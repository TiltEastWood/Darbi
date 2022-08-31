using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> sounds = new List<ISound>();

            Firework firework = new Firework();
            Parrot parrot = new Parrot();
            Radio radio = new Radio();

            sounds.Add(firework);
            sounds.Add(parrot);
            sounds.Add(radio);

            MakeSound(sounds);
        }
        public static void MakeSound(List<ISound> soundsource)
        {
            foreach (ISound sound in soundsource)
            {
                sound.PlaySound();
            }
        }
    }
}