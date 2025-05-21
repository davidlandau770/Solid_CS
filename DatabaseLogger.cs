using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principle
{
    internal class DatabaseLogger : ILogger
    {
        public List<string> Logs = new List<string>();

        public void Log(string storage, string message)
        {
            Logs.Add($"{storage}, {message}");
            Console.WriteLine("up to database!");
        }
    }
}