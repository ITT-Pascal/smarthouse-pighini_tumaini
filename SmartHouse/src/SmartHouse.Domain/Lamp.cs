using SmartHouse.Domain;

namespace BlaisePascal.SmartHouse.Domain
{
    public class Lamp : AbstractLamp
    {
     
        public const int MaxBrightnessLevel = 100;

        public Lamp()
        {
            IsOn = false;
        }

        public override void TurnOn()
        {
            IsOn = true;
        }

        public override void TurnOff()
        {
            IsOn = false;
        }

        public override void SetBrightness(int levelOfBrightness)
        {
            if (levelOfBrightness < 0 || levelOfBrightness > MaxBrightnessLevel)
            {
                throw new ArgumentOutOfRangeException("Brightness level must be between 0 and 100.");
            }
            BrightnessLevel = levelOfBrightness;
        }
    }
}
