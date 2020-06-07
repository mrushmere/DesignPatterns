using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class PlayerA : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing music from player A.");
        }
    }
}
