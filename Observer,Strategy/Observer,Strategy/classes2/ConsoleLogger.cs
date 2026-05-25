using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Strategy.classes2
{
    internal class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine($"{DateTime.Now} -> [Konzola] CPU load: {provider.CPULoad}% | Available RAM: {provider.AvailableRAM} MB");
        }

    }
}
