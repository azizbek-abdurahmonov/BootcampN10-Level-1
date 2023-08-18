using N26_HT1.Enums;
using N26_HT1.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace N26_HT1.Models
{
    internal class Money
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public MoneyType Type { get; set; }


        public static decimal? operator +(Money? moneyA, Money? moneyB)
        {
            if (moneyA.Type.Equals(moneyB.Type))
                return moneyA.ToUZS().Result + moneyB.ToUZS().Result;

            if (moneyA.Type == MoneyType.InBalance && moneyB.Type == MoneyType.Loan)
                return moneyA.ToUZS().Result - moneyB.ToUZS().Result;

            if (moneyA.Type == MoneyType.Loan && moneyB.Type == MoneyType.InBalance)
                return moneyB.ToUZS().Result - moneyA.ToUZS().Result;

            return null;
        }
    }
}
