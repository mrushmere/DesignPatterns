using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var soundSystem = new SoundSystem();
            soundSystem.Player = new PlayerA();

            soundSystem.Play();

            soundSystem.Player = new PlayerB();
            soundSystem.Play();

            Console.ReadLine();
        }
    }
}
