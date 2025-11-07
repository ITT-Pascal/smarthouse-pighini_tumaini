using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Domain
{
    public abstract class AbstractLamp
    {
        public bool IsOn { get; set; }
        public int BrightnessLevel { get; set; }

        public abstract void TurnOn();
        public abstract void TurnOff();
        public abstract void SetBrightness(int levelOfBrightness);
    }
}
