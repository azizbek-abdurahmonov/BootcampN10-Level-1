using N25_HT1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_HT1.Services
{
    internal class PaymentService
    {
        public bool CheckOut(double amount, DebitCard card)
        {
            if (amount <= card.Balance)
            {
                card.Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
