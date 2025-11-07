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
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp1);
            Assert.True(device.lamp1.IsOn);
            Assert.False(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnOneLamp_2_SetsIsOnToTrueTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp2);
            Assert.True(device.lamp2.IsOn);
            Assert.False(device.lamp1.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffOneLamp_1_SetsIsOnToFalseTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp1);
            device.TurnOffOneLamp(device.lamp1);
            Assert.False(device.lamp1.IsOn);
            Assert.False(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffOneLamp_2_SetsIsOnToFalseTheOtherRemainsFalse()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp2);
            device.TurnOffOneLamp(device.lamp2);
            Assert.False(device.lamp2.IsOn);
            Assert.False(device.lamp1.IsOn);
            
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnBothLampsOn();
            Assert.True(device.lamp1.IsOn);
            Assert.True(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnBothLampsOn();
            device.TurnBothLampsOff();
            Assert.False(device.lamp1.IsOn);
            Assert.False(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_Lamp_1_AlreadyOn_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp1);
            device.TurnBothLampsOn();
            Assert.True(device.lamp1.IsOn);
            Assert.True(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOnBothLamps_Lamp_2_AlreadyOn_SetsIsOnToTrueToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp2);
            device.TurnBothLampsOn();
            Assert.True(device.lamp1.IsOn);
            Assert.True(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_Lamp_1_AlreadyOff_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp2);
            device.TurnBothLampsOff();
            Assert.False(device.lamp1.IsOn);
            Assert.False(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_TurnOffBothLamps_Lamp_3_AlreadyOff_SetsIsOnToFalseToBothLamps()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.TurnOnOneLamp(device.lamp1);
            device.TurnBothLampsOff();
            Assert.False(device.lamp1.IsOn);
            Assert.False(device.lamp2.IsOn);
        }

        [Fact]
        public void TwoLampDevice_SetBothSameBrightness_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.SetBothLampsSameBrightness(70);
            Assert.Equal(70, device.lamp1.BrightnessLevel);
            Assert.Equal(70, device.lamp2.BrightnessLevel);
        }
        [Fact]
        public void TwoLampDevice_SetOneBrightness_SetsBrightnessLevel()
        {
            TwoLampDevice device = new TwoLampDevice();
            device.SetOneLampBrightness(device.lamp1, 30);
            Assert.Equal(30, device.lamp1.BrightnessLevel);
        }


    }
}