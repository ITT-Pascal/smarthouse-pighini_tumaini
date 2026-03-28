using SmartHouse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.SmarthouseTest
{
    public class EcoLampTest
    {
        [Fact]
        public void EcoLamp_TurnOn_SetsIsOnToTrue()
        {
            EcoLamp ecoLamp = new EcoLamp();
            ecoLamp.TurnOn();
            Assert.True(ecoLamp.IsOn);
        }
        [Fact]
        public void EcoLamp_TurnOff_SetsIsOnToFalse()
        {
            EcoLamp ecoLamp = new EcoLamp();
            ecoLamp.TurnOn();
            ecoLamp.TurnOff();
            Assert.False(ecoLamp.IsOn);
        }
        [Fact]
        public void EcoLamp_SetBrightness_ValidLevel_SetsBrightnessLevel()
        {
            EcoLamp ecoLamp = new EcoLamp();
            ecoLamp.TurnOn();
            ecoLamp.SetBrightness(25);
            Assert.Equal(25, ecoLamp.BrightnessLevel);
        }
        [Fact]
        public void EcoLamp_SetBrightness_NegativeLevel_ThrowsArgumentOutOfRangeException()
        {
            EcoLamp ecoLamp = new EcoLamp();
            Assert.Throws<ArgumentOutOfRangeException>(() => ecoLamp.SetBrightness(-5));
        }

        [Fact]
        public void EcoLamp_SetBrightness_AboveMaxLevel_ThrowsArgumentOutOfRangeException()
        {
            EcoLamp ecoLamp = new EcoLamp();
            Assert.Throws<ArgumentOutOfRangeException>(() => ecoLamp.SetBrightness(51));
        }

        [Fact]
        public void EcoLamp_TurnPowerSavingModeOn_SetsIsPowerSavingToTrue()
        {
            EcoLamp ecoLamp = new EcoLamp();
            ecoLamp.TurnPowerSavingModeOn();
            Assert.True(ecoLamp.IsPowerSaving);
        }

        [Fact]
        public void EcoLamp_TurnPowerSavingModeOff_SetsIsPowerSavingToFalse()
        {
            EcoLamp ecoLamp = new EcoLamp();
            Assert.False(ecoLamp.IsPowerSaving);
        }
    }
}
