using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InjectTron.InjectTron.Core.UseCases
{
    public interface IBankService
    {
        void TransferMoney(string fromAccount, string toAccount, decimal amount);
    }



}
