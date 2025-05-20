using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class EmergencyHandler
    {
        public void EmergencyShutdown()
        {
            Console.WriteLine("Emergency shutdown triggered!");
            File.WriteAllText("log.txt", "EMERGENCY OCCURRED");
            Email.Send("admin@spaceagency.com", "Emergency triggered");
        }

    }
}
