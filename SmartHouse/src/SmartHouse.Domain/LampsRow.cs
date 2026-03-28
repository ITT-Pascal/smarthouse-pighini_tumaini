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

        public void RemoveLamp()
        {
            Lamps.Remove(Lamps[0]);
        }

        public void RemoveLamp(int position)
        {
            Lamps.RemoveAt(position);
        }

        public void SetAllBrightness(int brightness)
        {
            for (int i = 0; i < Lamps.Count; i++)
            {
                Lamps[i].SetBrightness(brightness);
            }
        }

        public void SetBrightness(int brightness, int position)
        {
            Lamps[position].SetBrightness(brightness);
        }

        public void SwitchAllOn()
        {
            for (int i = 0; i < Lamps.Count; i++)
            {
                Lamps[i].TurnOn();
            }
        }

        public void SwitchAllOff()
        {
            for (int i = 0; i < Lamps.Count; i++)
            {
                Lamps[i].TurnOff();
            }
        }

        public void SwitchLamp(int position)
        {
            if (Lamps[position].IsOn == true)
            {
                Lamps[position].TurnOff();
            }
            else 
            {
                Lamps[position].TurnOn();
            }
        }
    }
}
