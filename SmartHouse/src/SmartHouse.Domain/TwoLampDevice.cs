using SmartHouse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.SmartHouse.Domain
{
    public class TwoLampDevice

    {
        public AbstractLamp Lamp1 { get; private set; }
        public AbstractLamp Lamp2 { get; private set; }


        public TwoLampDevice(AbstractLamp lamp1, AbstractLamp lamp2)
        {
            Lamp1 = lamp1;
            Lamp2 = lamp2;

            Lamp1.IsOn = false;
            Lamp2.IsOn = false;
        }

        public void TurnOnOneLamp(AbstractLamp currentLamp)
        {
            currentLamp.TurnOn();
        }

        public void TurnOffOneLamp(AbstractLamp currentLamp)
        {
            currentLamp.TurnOff();
        }

        public void TurnBothLampsOn()
        {
            Lamp1.TurnOn();
            Lamp2.TurnOn();
        }

        public void TurnBothLampsOff()
        {
            Lamp1.TurnOff();
            Lamp2.TurnOff();
        }

        public void SetOneLampBrightness(AbstractLamp currentLamp, int newBrightness)
        {
            currentLamp.SetBrightness(newBrightness);
        }

        public void SetBothLampsSameBrightness(int newBrightness)
        {
            Lamp1.SetBrightness(newBrightness);
            Lamp2.SetBrightness(newBrightness);
        }
    }
}
