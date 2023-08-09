using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20_HT1
{
    internal class UzumPaymentProvider : IPaymentProvider
    {
        public double TransferInterest { get; init; } = 1; //Bu providerda 1% yechib olinadi

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
