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
            DatabaseLogger data = new DatabaseLogger();
            data.Log("message");
        }
    }
}
