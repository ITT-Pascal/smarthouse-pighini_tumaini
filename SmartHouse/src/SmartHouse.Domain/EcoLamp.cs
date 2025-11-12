using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Domain
{
    public class EcoLamp: AbstractLamp 
    {
        public const int MaxBrightnessLevel  = 50;
        
        public bool IsPowerSaving { get; private set; }
        
        public EcoLamp()

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
                throw new ArgumentOutOfRangeException("Brightness level must be between 0 and 50.");
            }
            BrightnessLevel = levelOfBrightness;
        }

        public void TurnPowerSavingModeOn()
        {
            IsPowerSaving = true;
        }

        public void TurnPowerSavingModeOff()
        {
            IsPowerSaving = false;
        }
    }
}