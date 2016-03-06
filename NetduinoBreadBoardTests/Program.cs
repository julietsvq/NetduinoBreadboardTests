using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoBreadBoardTests
{
    public class Program
    {
        private static OutputPort led = new OutputPort(Pins.GPIO_PIN_D10, false);
        public static void Main()
        {
            InterruptPort btn = new InterruptPort(Pins.ONBOARD_BTN, false, Port.ResistorMode.Disabled, Port.InterruptMode.InterruptEdgeBoth);
            btn.OnInterrupt += Btn_OnInterrupt;

            Thread.Sleep(Timeout.Infinite);
        }

        private static void Btn_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            led.Write(data2 == 1);
        }
    }
}
