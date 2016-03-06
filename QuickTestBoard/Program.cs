using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace QuickTestBoard
{
    public class Program
    {
        public static void Main()
        {
            OutputPort led = new OutputPort(Pins.GPIO_PIN_D10, false);
            bool on = false;

            while(true)
            {
                on = !on;
                led.Write(on);
                Thread.Sleep(600);
            }
        }
    }
}
