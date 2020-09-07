using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractionBetween
{
    public class ConsoleLogger : ILogger
    {
        public void Debug(string msg)
        {
            Console.WriteLine($"[%] {msg}");
        }

        public void Error(string msg)
        {
            Console.WriteLine($"[!] {msg}");
        }

        public void Error(Exception ex)
        {
            Console.WriteLine($"[!] {ex.Message};\nStacktrace: {ex.StackTrace}");
        }

        public void Info(string msg)
        {
            Console.WriteLine($"[@] {msg}");
        }

        public void Success(string msg)
        {
            Console.WriteLine($"[+] {msg}");
        }

        public void Warning(string msg)
        {
            Console.WriteLine($"[#] {msg}");
        }
    }
}
