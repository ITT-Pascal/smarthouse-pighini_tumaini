using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse.Domain
{
    public class LampsRow

        //TODO: fai i test


    {
        public List<AbstractLamp> Lamps { get;  private set; }

        public LampsRow() 
        {
            Lamps = new List<AbstractLamp>();
        }  
        
        public void AddLamp(AbstractLamp LampToAdd)
        {
            Lamps.Add(LampToAdd);
        }

        public void AddLamp(AbstractLamp LampToAdd, int position)
        {
            Lamps[position] = LampToAdd;
        }
        
        public void AddEcoLamp(AbstractLamp EcoLampToAdd)
        {
            Lamps.Add(EcoLampToAdd);
        }

        public void AddEcoLamp(AbstractLamp EcoLampToAdd, int position)
        {
            Lamps[position] = EcoLampToAdd;
        }

        public void SwitchAllOn()
        {
            for (int i = 0; i < Lamps.Count; i++)
            {
                AbstractLamp lamp = Lamps[i];
                lamp.TurnOn();
            }
        }

        public void SwitchAllOff()
        {
            for (int i = 0; i < Lamps.Count; i++)
            {
                AbstractLamp lamp = Lamps[i];
                lamp.TurnOff();
            }
        }

        public void SwitchLamp(int position)
        {
            AbstractLamp lamp = Lamps[position];
            
            if (lamp.IsOn == true)
            {
                lamp.TurnOff();
            }
            else 
            {
                lamp.TurnOn();
            }
        }
    }
}
