using SmartHouse.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlaisePascal.SmartHouse.Domain.UnitTest
{
    public class TwoLampDeviceTest
    {
        [Fact]
        public void TwoLampDevice_TurnOnOneLamp_1_SetsIsOnToTrueTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            Assert.True(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnOneLamp_1_Eco_SetsIsOnToTrueTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            Assert.True(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnOneLamp_2_SetsIsOnToTrueTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp2);
            Assert.True(device.Lamp2.IsOn);
            Assert.False(device.Lamp1.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnOneLamp_2_Eco_SetsIsOnToTrueTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new EcoLamp());
            device.TurnOnOneLamp(device.Lamp2);
            Assert.True(device.Lamp2.IsOn);
            Assert.False(device.Lamp1.IsOn);
        } 

        [Fact]
        public void TwoLampDevice_TurnOffOneLamp_1_SetsIsOnToFalseTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            device.TurnOffOneLamp(device.Lamp1);
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffOneLamp_1_Eco_SetsIsOnToFalseTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            device.TurnOffOneLamp(device.Lamp1);
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffOneLamp_2_SetsIsOnToFalseTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp2);
            device.TurnOffOneLamp(device.Lamp2);
            Assert.False(device.Lamp2.IsOn);
            Assert.False(device.Lamp1.IsOn);
            
        }

        [Fact]
        public void TwoLampDevice_TurnOffOneLamp_2_Eco_SetsIsOnToFalseTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new EcoLamp());
            device.TurnOnOneLamp(device.Lamp2);
            device.TurnOffOneLamp(device.Lamp2);
            Assert.False(device.Lamp2.IsOn);
            Assert.False(device.Lamp1.IsOn);

        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnBothLampsOn();
            Assert.True(device.Lamp1.IsOn);
            Assert.True(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_BothEco_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new EcoLamp());
            device.TurnBothLampsOn();
            Assert.True(device.Lamp1.IsOn);
            Assert.True(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnBothLampsOn();
            device.TurnBothLampsOff();
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_BothEco_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new EcoLamp());
            device.TurnBothLampsOn();
            device.TurnBothLampsOff();
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_Lamp_1_AlreadyOn_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            device.TurnBothLampsOn();
            Assert.True(device.Lamp1.IsOn);
            Assert.True(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_Lamp_1_Eco_AlreadyOn_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            device.TurnBothLampsOn();
            Assert.True(device.Lamp1.IsOn);
            Assert.True(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_Lamp_2_AlreadyOn_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp2);
            device.TurnBothLampsOn();
            Assert.True(device.Lamp1.IsOn);
            Assert.True(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_Lamp_2_Eco_AlreadyOn_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new EcoLamp());
            device.TurnOnOneLamp(device.Lamp2);
            device.TurnBothLampsOn();
            Assert.True(device.Lamp1.IsOn);
            Assert.True(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_Lamp_1_AlreadyOff_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp2);
            device.TurnBothLampsOff();
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_Lamp_1_Eco_AlreadyOff_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp2);
            device.TurnBothLampsOff();
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_Lamp_2_AlreadyOff_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.TurnOnOneLamp(device.Lamp1);
            device.TurnBothLampsOff();
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_Lamp_2_Eco_AlreadyOff_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new EcoLamp());
            device.TurnOnOneLamp(device.Lamp1);
            device.TurnBothLampsOff();
            Assert.False(device.Lamp1.IsOn);
            Assert.False(device.Lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_SetOneBrightness_1_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.SetOneLampBrightness(device.Lamp1, 30);
            Assert.Equal(30, device.Lamp1.BrightnessLevel);
        }

        [Fact]
        public void TwoLampDevice_SetOneBrightness_1_Eco_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new Lamp());
            device.SetOneLampBrightness(device.Lamp1, 30);
            Assert.Equal(30, device.Lamp1.BrightnessLevel);
        }

        [Fact]
        public void TwoLampDevice_SetOneBrightness_2_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.SetOneLampBrightness(device.Lamp2, 30);
            Assert.Equal(30, device.Lamp2.BrightnessLevel);
        }

        [Fact]
        public void TwoLampDevice_SetOneBrightness_2_Eco_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new EcoLamp());
            device.SetOneLampBrightness(device.Lamp2, 30);
            Assert.Equal(30, device.Lamp2.BrightnessLevel);
        }

        [Fact]
        public void TwoLampDevice_SetBothSameBrightness_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice(new Lamp(), new Lamp());
            device.SetBothLampsSameBrightness(70);
            Assert.Equal(70, device.Lamp1.BrightnessLevel);
            Assert.Equal(70, device.Lamp2.BrightnessLevel);
        }

        [Fact]
        public void TwoLampDevice_SetBothSameBrightness_BothEco_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice(new EcoLamp(), new EcoLamp());
            device.SetBothLampsSameBrightness(40);
            Assert.Equal(40, device.Lamp1.BrightnessLevel);
            Assert.Equal(40, device.Lamp2.BrightnessLevel);
        }
    }
}