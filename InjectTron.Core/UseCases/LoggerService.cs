using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectTron.InjectTron.Core.UseCases
{
    public interface ILoggerService
    {
        void Log(string message);
    }

    public class LoggerService: ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Logging message");
        }
    }
}
