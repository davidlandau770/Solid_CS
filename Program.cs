﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmergencyHandler emergencyHandler = new EmergencyHandler("0507707707", "system@gmail.com", "hello david!", "storage 770");
            emergencyHandler.EmergencyShutdown();
        }
    }
}
