using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace PasiveBuzzer
{
    public class Program
    {
        private static PWM buzzer = new PWM(PWMChannels.PWM_PIN_D10, 100, 0.0, false);

        public static void Main()
        {
            // write your code here
            buzzer.Start();

            //double note1 = 138.591;
            double note2 = 16.35;
            double note3 = 2093.0;

            tone(note2, 1.0);
            Thread.Sleep(2000);
            //tone(0);
            //tone(note2, 0.5);
            //Thread.Sleep(2000);
            //tone(0);
            //tone(note3, 1);
            //Thread.Sleep(2000);
            //tone(0);
        }

        private static void tone (double frequency)
        {
            buzzer.Frequency = frequency;            
        }
        private static void tone(double frequency, double dutyCycle)
        {
            tone(frequency);
            buzzer.DutyCycle = dutyCycle;
        }

        private static void tone(double frequency, double dutyCycle, uint duration)
        {
            tone(frequency, dutyCycle);
            buzzer.Duration = duration;
        }
    }
}
