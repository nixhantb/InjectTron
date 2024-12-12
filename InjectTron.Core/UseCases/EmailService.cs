using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectTron.InjectTron.Core.UseCases
{
    public interface IEmailService
    {
        void SendEmail(string to, string message);
    }

    public class EmailService: IEmailService
    {
        public void SendEmail(string to, string message)
        {
            Console.WriteLine($"Sending Email to {to}: {message}");
        }
    }
}
