using System.ComponentModel;

namespace SmartHouse.Domain
{
    public class Lamp
    {
        public bool IsOn { get; private set; }
        public int Brightness { get; private set; } 
        public string Color { get; private set; }
        public Lamp()
        {
            IsOn = false;
            Brightness = 0;
            Color = "White";
        }

    }
}
