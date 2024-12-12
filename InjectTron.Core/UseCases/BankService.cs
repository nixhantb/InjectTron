using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectTron.InjectTron.Core.UseCases
{
    public class BankService : IBankService
    {
        private readonly ILoggerService _loggerService;

        public BankService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }   

        public void TransferMoney(string fromAccount, string toAccount, decimal amount)
        {
            _loggerService.Log($"Transferring {amount} from {fromAccount} to {toAccount}");
            _loggerService.Log($"Successfully transferred ${amount}.");
        }

    }
}
