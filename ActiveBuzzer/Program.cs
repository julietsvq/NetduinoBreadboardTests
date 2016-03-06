using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace ActiveBuzzer
{
    public class Program
    {
        private static OutputPort buzzer = new OutputPort(Pins.GPIO_PIN_D8, false);
        public static void Main()
        {
            InterruptPort btn = new InterruptPort((Cpu.Pin)0x15, false, Port.ResistorMode.Disabled, Port.InterruptMode.InterruptEdgeBoth);
            btn.OnInterrupt += Btn_OnInterrupt;
        }

        private static void Btn_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            buzzer.Write(data2 == 1);
        }

    }
}
