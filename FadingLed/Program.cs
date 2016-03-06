using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace FadingLed
{
    public class Program
    {
        static PWM led;
        public static void Main()
        {
            //duty cycle (0 - 1) period, 10kHz frequency
            PWM led = new PWM(PWMChannels.PWM_PIN_D10, 10000, 0.1, false); 

            led.Start();

            while (true)
            {
                double startValue, endvalue;

                //fade in
                for (startValue = 0; startValue < 1; startValue = startValue + 0.00005)
                {
                    led.DutyCycle = startValue;
                }

                //fade out
                for (endvalue = startValue; endvalue > 0; endvalue = endvalue - 0.00005)
                {
                    led.DutyCycle = endvalue;
                }
            }

        }
    }
}

