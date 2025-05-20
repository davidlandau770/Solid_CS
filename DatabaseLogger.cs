using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public void Log(string store, string message)
        {
            string[] logs = new string[] { message };
            Console.WriteLine("!");
        }
    }
}