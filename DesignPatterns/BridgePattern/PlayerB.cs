using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class PlayerB : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing music from player B.");
        }
    }
}
