using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class TelemetrySender : IEmailAlert, ISmsAlert
    {
        public void SendTelemetry()
        {
            Console.WriteLine("Telemetry sent to Earth....");
        }

        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending email to {to}: {message}");
        }

        public void SendSms(string to, string message)
        {
            Console.WriteLine($"Sending SMS to {to}: {message}");
        }
    }
}
