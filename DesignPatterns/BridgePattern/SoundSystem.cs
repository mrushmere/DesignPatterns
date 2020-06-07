namespace BridgePattern
{
    public class SoundSystem
    {
        public IPlayer Player { get; set; }
        public virtual void Play()
        {
            Player.Play();
        }
    }
}
