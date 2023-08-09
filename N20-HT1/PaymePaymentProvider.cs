using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace N20_HT1
{
    internal class PaymePaymentProvider : IPaymentProvider
    {
        public double TransferInterest { get; init; } = 2; //Bu providerda 2%

        public bool Transfer(IDebitCard sourceCard, IDebitCard destinationCard, double amount)
        {
            var AmountWithTransferInterest = amount + (amount / 100 * TransferInterest);
            if (AmountWithTransferInterest > sourceCard.Balance) return false;
            sourceCard.Balance -= AmountWithTransferInterest;
            destinationCard.Balance += amount;

            return true;
        }


    }
}
