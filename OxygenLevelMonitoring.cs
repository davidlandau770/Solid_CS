using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class OxygenLevelMonitoring : ISmsAlert, IEmailAlert
    {
        public void LevelMonitoring(int level)
        {
            if (level < 20)
            {
                //TelemetrySender telemetrySender = new TelemetrySender();
                //telemetrySender.SendSms("The monitoring is low!");
                //telemetrySender.SendEmail("system@gmail.com", "The monitoring is low!");
                SendEmail("system@gmail.com", "The monitoring is low!");
                SendSms("The monitoring is low!");
            }
        }

        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email to {to}: {message}");
        }

        public void SendSms(string message)
        {
            Console.WriteLine(message);
        }
    }
}
