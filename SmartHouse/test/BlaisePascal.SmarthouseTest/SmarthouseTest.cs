using SmartHouse.Domain;

namespace BlaisePascal.SmartHouse.Domain.UnitTest
{
    public class SmarthouseTest
    {
        [Fact]
        public void Lamp_TurnOn_SetsIsOnToTrue()
        {
            Lamp lamp = new Lamp();
            lamp.TurnOn();
            Assert.True(lamp.IsOn);
        }
        [Fact]
        public void Lamp_TurnOff_SetsIsOnToFalse()
        {
            Lamp lamp = new Lamp();
            lamp.TurnOn();
            lamp.TurnOff();
            Assert.False(lamp.IsOn);
        }
        [Fact]
        public void Lamp_SetBrightness_ValidLevel_SetsBrightnessLevel()
        {
            Lamp lamp = new Lamp();
            lamp.SetBrightness(50);
            Assert.Equal(50, lamp.BrightnessLevel);
        }
        [Fact]
        public void Lamp_SetBrightness_NegativeLevel_ThrowsArgumentOutOfRangeException()
        {
            Lamp lamp = new Lamp();
            Assert.Throws<ArgumentOutOfRangeException>(() => lamp.SetBrightness(-5));
        }

        [Fact]
        public void Lamp_SetBrightness_AboveMaxLevel_ThrowsArgumentOutOfRangeException()
        {
            Lamp lamp = new Lamp();
            Assert.Throws<ArgumentOutOfRangeException>(() => lamp.SetBrightness(101));
        }

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