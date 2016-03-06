using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;


namespace RGBLeds
{
    public class Program
    {
        enum color { red, green, blue };

        private static OutputPort[] leds = new OutputPort[3]
           {
                new OutputPort(Pins.GPIO_PIN_D10, false),
                new OutputPort(Pins.GPIO_PIN_D9, false),
                new OutputPort(Pins.GPIO_PIN_D8, false)
           };

        public static void Main()
        {    
            while(true)
            {
                FlashLed(color.red);
                FlashLed(color.green);
                FlashLed(color.blue);
            }
        }

        private static void FlashLed(color ledcolor)
        {
            leds[(int)ledcolor].Write(true);
            Thread.Sleep(1000);
            leds[(int)ledcolor].Write(false);
            Thread.Sleep(1000);
        }
    }
}
