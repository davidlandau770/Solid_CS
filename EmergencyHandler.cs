using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        string PhoneNumber;
        string Email;
        string Message;
        string Storage;

        public EmergencyHandler(string phoneNumber, string email, string massege, string storage)
        {
            PhoneNumber = phoneNumber;
            Email = email;
            Message = massege;
            Storage = storage;
        }

        public void EmergencyShutdown()
        {
            TelemetrySender telemetrySender = new TelemetrySender();
            telemetrySender.SendSms(PhoneNumber,Message);
            telemetrySender.SendEmail(Email, Message);

            Console.WriteLine("Emergency shutdown triggered!");
            DatabaseLogger data = new DatabaseLogger();
            data.Log(Storage, Message);
        }
    }
}
